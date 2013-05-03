using Services;
using System;

namespace Domain
{
    class Generate
    {
        private DomainControler controler = DomainControler.getInstance();
        private DataBase dbhelper;
        private LinkedList roomList;
        private LinkedList moduleList;
        private LinkedList lecturerList;
        private Lesson[][] population; // the population of chromozones
        
        /// <summary>
        /// Constructer
        /// </summary>
        public Generate()
        {
            population = new Lesson[10][];
            for (int x = 0; x < population.Length; x++)
            {
                    population[x] = new Lesson[40];
            }
            dbhelper = controler.getDBHelper();
            roomList = dbhelper.getRoomList();
            moduleList = dbhelper.getModuleList();
            genRandomPop();
            
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

            for (int i = 0; i < lecturers.Length && !exit; i++)
            {
                thelec = dbhelper.getLecturerById(lecturers[i]);
                if (thelec.hoursAllocated < thelec.maxHours)
                {
                    exit = true;
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
            bool found = false;
            Module randModule = null;
            Node moduleNode = moduleList.head;
            // pick a random place to stop in the list
            while (!found)
            {
                int numOfLoops = new Random().Next(0, moduleList.getLenght());
                for (int i = 0; i < numOfLoops; i++)
                {
                    randModule = (Module)moduleNode.data;
                    //if this module is till below the max hours per week
                    if (randModule.hoursAllocated < randModule.hoursPerWeek)
                    {
                        found = true;
                    }
                } 
            }
            return randModule;
        }

        private Room getRoom(Module theModule)
        {
            Room theRoom = null;
            Node roomNode = roomList.head;

            while (roomNode!=null)
            {
                theRoom = (Room)roomNode.data;
                if (theRoom .capacity > dbhelper.getCourseById(theModule.courseId).numOfStudents)
                {
                    roomNode = null;
                }
            }
            return theRoom;
        }
        /// <summary>
        /// generate a random population of timetables/ chromosones
        /// </summary>
        private void genRandomPop()
        {
            int timeslot;
            Module theModule;
            Lecturer theLec;
            Room theRoom;
            Lesson theLesson;

            for (int i = 0; i < population[0].Length; i++)
            {
                timeslot = generateRandomTimeSlot();
                theModule = getRandomModule();
                theLec = getLecturer(theModule);
                theRoom = getRoom(theModule);
                theLesson = new Lesson(theLec, theModule, theRoom);
                theModule.AllocatedToALesson();
                theLec.AllocatedToALesson();
                population[0][i] = theLesson;
            }
            


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
        private int[] crossover(int[] father, int[] mother)
        {
            return new int[1];
        }
    }
}
