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
            dbhelper = controler.getDBHelper();
            roomList = dbhelper.getRoomList();

            population = new Lesson[10][];
            for (int x = 0; x < population.Length; x++)
            {
                //gen random timetable
            }
        }
        /// <summary>
        /// generate a random timeslot for a lesson
        /// </summary>
        /// <returns></returns>
        private string generateRandomTimeSlot()
        {
            Random random = new Random();
            string timeslot;
            int temp = random.Next(0,45);
            
            if (temp < 10)
            {
                timeslot = "0" + temp;
            }
            else
            {
                timeslot = temp.ToString();
            }
            return timeslot;
        }
        /// <summary>
        /// gets an available lecturer for the given timeslot;
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private Lecturer getLecturer(string time)
        {
            Lecturer thelec = null;
            Node lecNode = lecturerList.head;
            while (lecNode != null)
            {
                thelec = (Lecturer) lecNode.data;
                if (thelec.available(time))
                {
                    lecNode = null;
                }
                lecNode = lecNode.next;
            }
            return thelec;
        }

        /// <summary>
        /// generate a random population of timetables/ chromosones
        /// </summary>
        private void genRandomPop()
        {
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
