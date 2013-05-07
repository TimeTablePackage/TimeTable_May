using Services;
using System;

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
            temp();
        }
        /// <summary>
        /// generate a random timeslot for a lesson
        /// </summary>
        /// <returns></returns>
        private int generateRandomTimeSlot()
        {
            return new Random().Next(0,40);
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
                int numOfLoops = new Random().Next(1, moduleList.getLenght()+1);
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
        /// get a room for the module
        /// </summary>
        /// <param name="theModule">the module</param>
        /// <returns>a room</returns>
        private Room getRoom(Module theModule)
        {
            int numOfLoops = new Random().Next(1,roomList.getLenght()+1);
            Room theRoom = null;
            Node roomNode = roomList.head;

            for (int i = 0; i < numOfLoops; i++)
            {
                theRoom = (Room)roomNode.data;
            }
            return theRoom;
        }
        /// <summary>
        /// generate a random population of timetables/ chromosones
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
        /// crossover two parents to produce children;
        /// </summary>
        /// <param name="father">one parent chromosome</param>
        /// <param name="mother">another parent chromosome</param>
        /// <returns>children chromosones</returns>
       /* private int[][] crossover(Lesson[][] father, Lesson[][] mother)
        {
           ///int point1 = new Random().Next(1,father
        } */
        
        private void temp()
        {
            Lesson theLesson;
            bool allocated = false;

            for (int i = 0; i < 16 /* the total sum of hours needed for moduels*/; i++)
            {
                theLesson = genRandomLesson();
                
                while (!allocated)
                {
                    int 
                    if (!contains(population[0][1], theLesson))
                    {
                        
                    }

                    
                }
            }
            dbhelper.insertLessons(population[0][0]);

        }


        private bool contains(object[] theArray, object search)
        {
            bool answer = false;

            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] == search)
                {
                    answer = true;
                }
            }
            return answer;
        }
    }
}
