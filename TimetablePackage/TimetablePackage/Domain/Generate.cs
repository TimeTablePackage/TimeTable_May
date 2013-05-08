using Services;
using System;
using System.Windows.Forms;

namespace Domain
{
    public class Generate
    {
        private DomainControler controler = DomainControler.getInstance();
        private DataBase dbhelper;
        private LinkedList roomList;
        private LinkedList moduleList;
        /// <summary>
        /// Array of chromosomes
        /// </summary>
        private Lesson[][][] population;
        /// <summary>
        /// Constructer
        /// </summary>
        public Generate()
        {
            //int numOfRooms = roomList.getLenght();
            population = new Lesson[10][][];
            for (int x = 0; x < population.Length; x++)
            {
                population[x] = new Lesson[40][];
                for (int y = 0; y < population[x].Length; y++)
                {
                    //max number of lessons at one time possible is equals to number of rooms;
                    population[x][y] = new Lesson[20];
                }
            }
            dbhelper = controler.getDBHelper();
            roomList = dbhelper.getRoomList();
            moduleList = dbhelper.getModuleList();
            if (!(roomList.getLenght() * 40 < dbhelper.totalModuleHours()))
            {
                populate();
            }
            else
            {
                MessageBox.Show("Not enough resources(rooms) to complete timetable");
            }
        }
        /// <summary>
        /// auto-generate the population
        /// </summary>
        private void populate()
        {
            for (int x = 0; x < dbhelper.totalModuleHours(); x++)
            {
                addToPop(population[0], genRandomLesson());
                dbhelper.insertLessons(population[0]);
            }

        }
        /// <summary>
        /// add a lesson to suitable place in the popluation i.e. 
        /// </summary>
        /// <param name="theLesson"></param>
        private void addToPop(Lesson[][] theChromosome, Lesson theLesson)
        {
            bool allocated = false;

            // for each chromosome
            for (int y = 0; y < theChromosome[0].Length && !allocated; y++)
            {
                //ensure the same module/leturer/room is not repeated in one timeslot!
                if (!(contains(theChromosome[y], theLesson.lecturer) ||
                    contains(theChromosome[y], theLesson.module) ||
                    contains(theChromosome[y], theLesson.room)))
                {
                    for (int z = 0; z < theChromosome[y].Length && !allocated; z++)
                    {
                        if (theChromosome[y][z] == null)
                        {
                            theChromosome[y][z] = theLesson;
                            allocated = true;
                        }
                    }
                }

            }
        }
        /// <summary>
        /// Check if a object is in the array
        /// </summary>
        /// <param name="theLessons">the array</param>
        /// <param name="obj">the module/lecturer/room to check for</param>
        /// <returns>boolean</returns>
        private bool contains(Lesson[] theLessons, object obj)
        {
            bool answer = false;

            for (int i = 0; i < theLessons.Length; i++)
            {
                if (theLessons[i] != null)
                {
                    //try to cast as a lecturer 
                    try
                    {
                        if (theLessons[i].lecturer == (Lecturer)obj)
                        {
                            answer = true;
                        }
                    }
                    catch
                    {
                        //or as a module 
                        try
                        {
                            if (theLessons[i].module == obj)
                            {
                                answer = true;
                            }
                        }
                        catch
                        {
                            // must be a room so.
                            try
                            {
                                if (theLessons[i].room == obj)
                                {
                                    answer = true;
                                }
                            }
                            catch
                            {

                            }

                        }
                    }
                }
            }
            return answer;
        }
        /// <summary>
        /// generate a random lesson
        /// </summary>
        private Lesson genRandomLesson()
        {
            Module theModule;
            Lecturer theLec;
            Room theRoom;
            Lesson theLesson = null;

            theModule = getRandomModule();
            theLec = getLecturer(theModule);
            theRoom = getRoom(theModule);
            theLesson = new Lesson(theLec, theModule, theRoom);
            theModule.AllocatedToALesson();
            theLec.AllocatedToALesson();

            return theLesson;
        }
        /// <summary>
        /// Get a random Module
        /// </summary>
        /// <returns>a random module</returns>
        private Module getRandomModule()
        {
            int tries = 0;
            bool found = false;
            Module randModule = null;
            Node moduleNode;
            // pick a random place to stop in the list
            // try for a thouasnd times if no result exit;
            while (!found && tries++ < 1000)
            {
                moduleNode = moduleList.head;
                randModule = (Module)moduleNode.data;
                int numOfLoops = new Random().Next(1, moduleList.getLenght() + 1);
                for (int i = 0; i < numOfLoops; i++)
                {
                    randModule = (Module)moduleNode.data;
                    //if this module is till below the max hours per week
                    if (randModule.hoursAllocated < randModule.hoursPerWeek)
                    {
                        found = true;
                    }
                    moduleNode = moduleNode.next;
                }
            }
            if (!found) randModule = null;
            return randModule;
        }
        /// <summary>
        /// gets an available lecturer for the given module;
        /// </summary>
        /// <returns></returns>
        private Lecturer getLecturer(Module theModule)
        {
            bool exit = false;
            string[] lecturers = theModule.lecturers;
            Lecturer thelec = null;
            //search for lecturer
            for (int i = 0; i < lecturers.Length && !exit; i++)
            {
                thelec = dbhelper.getLecturerById(lecturers[i]);
                if (thelec.hoursAllocated < thelec.maxHours)
                {
                    exit = true;
                }
            }
            //if no lecturer suitable get random one
            if (!exit)
            {
                //random number
                int numOfLoops = new Random().Next(1, lecturers.Length + 1);
                for (int i = 0; i < numOfLoops; i++)
                {
                    thelec = dbhelper.getLecturerById(lecturers[i]);
                }
            }
            return thelec;
        }
        /// <summary>
        /// get a room for the module
        /// </summary>
        /// <param name="theModule">the module</param>
        /// <returns>a room</returns>
        private Room getRoom(Module theModule)
        {
            int numOfLoops = new Random().Next(1, roomList.getLenght() + 1);
            Room theRoom = null;
            Node roomNode = roomList.head;

            for (int i = 0; i < numOfLoops; i++)
            {
                theRoom = (Room)roomNode.data;
            }
            return theRoom;
        }
        /// <summary>
        /// checks whether or not to go to the next generation based
        /// on highest fitness and number of generations
        /// </summary>
        /// <returns>boolean</returns>
        private bool nextGen()
        {
            bool answer = false;
            return answer;
        }
        /// <summary>
        /// sort the population by fitness
        /// </summary>
        private void sortPopulation()
        {

        }
        /// <summary>
        /// Crossover two chromosomes and retrurn the values
        /// </summary>
        /// <param name="father">chromosome to crossover</param>
        /// <param name="mother">chromosome to crossover</param>
        /// <param name="newFather">the 1st child</param>
        /// <param name="newMother">the 2nd child</param>
        private void crossover(Lesson[][] father, Lesson[][] mother, 
            out Lesson[][] newFather, out Lesson[][] newMother)
        { 
            //Lesson[][] newFather, newMother ;
            //the time slots already swapped between parents
            int[] alreadySwapped = new int[20];
            //temp location to hold a genome while swapping
            Lesson[] temp;
            //swap 20 random genomes from father to mother
            for (int i = 0; i < 20 /*i.e. hlaf the timeslots are swapped*/; i++)
            {
                bool exit = true;
                int timeSlot = 0; 
                // dont swap the same genome twice;
                do
                {
                    timeSlot = new Random().Next(0, 21);
                    for (int x = 0; x < alreadySwapped.Length; x++)
                    {
                        if (timeSlot == alreadySwapped[i])
                        {
                            exit = false;
                        }
                    } 
                } while (!exit);

                temp = father[timeSlot];
                father[timeSlot] = mother[timeSlot];
                mother[timeSlot] = temp;
            }
            newFather = father;
            newMother = mother;
        }
       
 

 
    }

}

