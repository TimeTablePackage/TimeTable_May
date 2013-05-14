using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Domain
{
    public class Lesson
    {
        DomainControler controler = DomainControler.getInstance();
        /// <summary>
        /// The lecturer details that teaches the Lesson.
        /// </summary>
        public Lecturer lecturer { get; set; }
        /// <summary>
        /// The Module details that the Lesson will take place for.
        /// </summary>
        public Module module { get; set; }
        /// <summary>
        ///     The default constructor of the Lesson object.
        /// </summary>
        public Lesson()
        {
        }
        /// <summary>
        ///     The constructor of Lesson object with a set of properties.
        /// </summary>
        /// <param name="lecturer">The name of the Lecturer</param>
        /// <param name="module">The name of the Module</param>
        /// <param name="room">The name/number of the Room</param>
        public Lesson(Lecturer lecturer, Module module)
        {
            this.lecturer = lecturer;
            this.module = module;
        }
        public string ToString()
        {
             return lecturer.name + "\n " + module.name + "\n";
        }
        //get the fitness of this Lesson
        public int getFitness(Room room, int timeSlotInt)
        {
            string timeSlot = null;
            int fitness = 0;
            Util util = controler.getUtil();

            //change timeslot to string;
            if (timeSlotInt < 10)
            {
                timeSlot = "0" + timeSlotInt;
            }
            else
            {
                timeSlot = timeSlotInt.ToString();
            }
            //if room is too small
            if (room.capacity < controler.getDBHelper().getCourseById(module.courseId).numOfStudents)
            {
                fitness += 90;
            }
            //if room is not available
            if (util.containsSlot(timeSlot, room.slotsOff))
            {
                fitness += 80;
            }
            //if lecturer dosent want this slot
            if (util.containsSlot(timeSlot, lecturer.slotsOff))
            {
                fitness += 50;
            }
            //
            if (room.roomType != module.RoomType)
            {
                fitness += 60;
            }
            return fitness;

        }
    }
}
