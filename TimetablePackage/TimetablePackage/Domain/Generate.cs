using Services;
using System;
using System.Windows.Forms;

namespace Domain
{
    public class Generate
    {
        private DomainControler controler = DomainControler.getInstance();
        private DataBase dbhelper;
        private Room[] roomList;
        private LinkedList moduleList;
        private int[] lessonsPerSlotCount;
        /// <summary>
        /// Array of chromosomes
        /// </summary>
        private Lesson[][][] population;
        /// <summary>
        /// Constructer
        /// </summary>
        public Generate()
        {
            InitializeVaribales();
            populate();
        }
        private void InitializeVaribales()
        {
            dbhelper = controler.getDBHelper();
            //get the array of rooms
            roomList = new Room[dbhelper.getRoomList().getLenght()];
            //int numOfRooms = roomList.getLenght();
            population = new Lesson[10][][];
            for (int x = 0; x < population.Length; x++)
            {
                population[x] = new Lesson[40][];
                for (int y = 0; y < population[x].Length; y++)
                {
                    //max number of lessons at one time possible is equals to number of rooms;
                    population[x][y] = new Lesson[roomList.Length];
                }
            }
            moduleList = dbhelper.getModuleList();
            //array that keeps track of the number of lessons in each time slot
            lessonsPerSlotCount = new int[40];
            Node roomNode = dbhelper.getRoomList().head;
            for (int i = 0; i < roomList.Length; i++)
            {
                roomList[i] = (Room)roomNode.data;
                roomNode = roomNode.next;
            }
        }
        /// <summary>
        /// auto-generate the population
        /// </summary>
        private void populate()
        {
            Module tempModule;
            int numOfLoops;
            Lesson[][] Chromosome = population[0];
            Lesson newLesson;
            Node moduleNode = moduleList.head;
            while (moduleNode != null)
            {
                tempModule = (Module)moduleNode.data;
                numOfLoops = tempModule.hoursPerWeek;
                for (int i = 0; i < numOfLoops; i++)
                {
                    newLesson = new Lesson(getLecturer(tempModule), tempModule);
                    addToChromosome(newLesson, Chromosome);
                }
                moduleNode = moduleNode.next;
            }
        }
        private void addToChromosome(Lesson lesson, Lesson[][] chromosome)
        {
            bool added = false;
            for (int i = 0; i < chromosome.Length && !added; i++)
            {
                if (!(checkInsert(chromosome[i], lesson)))
                {
                    for (int x = 0; x < chromosome[i].Length && !added; x++)
                    {
                        if (chromosome[i][x] == null)
                        {
                            chromosome[i][x] = lesson;
                            added = true;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Check if a object is in the array
        /// </summary>
        /// <param name="genome">the array</param>
        /// <param name="obj">the module/lecturer/room to check for</param>
        /// <returns>boolean</returns>
        private bool checkInsert(Lesson[] genome, Lesson lesson)
        {
            bool answer = false;

            for (int i = 0; i < genome.Length && answer == false; i++)
            { 
                if (genome[i] != null)
                {
                    if (genome[i].module.courseId == lesson.module.courseId)
	                {
		                answer = true;
	                }
                    else if (lesson.lecturer == genome[i].lecturer)
                    {
                        answer = true;
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
            Lesson theLesson = null;
            theModule = getRandomModule();
            theLec = getLecturer(theModule);
            theLesson = new Lesson(theLec, theModule);
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
            Lecturer thelec = null;
            try
            {
                bool exit = false;
                string[] lecturers = theModule.lecturers;

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
            }
            catch (Exception)
            {


            }
            return thelec;
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
        /// not going to work :(
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
        //temp just to display!!
        public Lesson[][] getTimetable()
        {
            return population[0];
        }

        private 
    }
}

