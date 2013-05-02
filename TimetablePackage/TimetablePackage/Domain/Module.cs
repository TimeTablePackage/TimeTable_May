using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Domain
{
    public class Module
    {
        ///<summary>
        /// ID will be used for identifying the  Module in the database.
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Name of the module.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Boolean value specifies whether Module has a practical lecture or not.
        /// </summary>
        public bool practical { get; set; }
        /// <summary>
        /// The number of hours per week that the Module will be taught.
        /// </summary>
        public int hoursPerWeek { get; set; }
        /// <summary>
        /// The room type that is required by the Module for the classes.
        /// </summary>
        public string RoomType { get; set; }
        /// <summary>
        /// Specifies whether the Module can have double lectures or not.
        /// </summary>
        public bool doubleSlots { get; set; }
        /// <summary>
        /// Specifies the maximum consecutive hours that the Module can be taught during the day.
        /// </summary>
        public int maxConsecHours { get; set; }
        /// <summary>
        /// Id of the course the module is on
        /// </summary>
        public string courseId { get; set; }


        /// <summary>
        ///  This method constructs a new Module object and sets the properties.
        /// </summary>
        ///  /// <param name="name">String value will be assigned as the name of the Module</param>
        /// <param name="pratical">Boolean value specifies whether Module have a practical or not</param>
        /// <param name="hoursPerWeek">Integer value will be assigned as the number of hours the Module will be taught.</param>
        /// <param name="roomType">String value contains information about the Room type required for the Module</param>
        /// <param name="doubleSlots">Boolean value specifies wheter double lectures are allowed for the Module</param>
        /// <param name="maxConsecHours">Integer value will define the maximum consecutive hours during the day.</param>
        /// <param name="slotsOff">String value contains information about timeslots that the Module can not be taught</param>
        /// <param name="lecturerList">LinkedList with a List of Lecturers</param>
        /// <param name="courseId">The course the module is on</param>
        public Module(string name, bool pratical, int hoursPerWeek, string roomType, bool doubleSlots, int maxConsecHours, string courseId)
        {
            this.name = name;
            this.practical = practical;
            this.hoursPerWeek = hoursPerWeek;
            this.RoomType = roomType;
            this.doubleSlots = doubleSlots;
            this.maxConsecHours = maxConsecHours;
            this.courseId = courseId;
        }
        /// <summary>
        /// Construter for database
        /// </summary>
        /// <param name="id">id of the module</param>
        /// <param name="name">String value will be assigned as the name of the Module</param>
        /// <param name="pratical">Boolean value specifies whether Module have a practical or not</param>
        /// <param name="hoursPerWeek">Integer value will be assigned as the number of hours the Module will be taught.</param>
        /// <param name="roomType">String value contains information about the Room type required for the Module</param>
        /// <param name="doubleSlots">Boolean value specifies wheter double lectures are allowed for the Module</param>
        /// <param name="maxConsecHours">Integer value will define the maximum consecutive hours during the day.</param>
        /// <param name="slotsOff">String value contains information about timeslots that the Module can not be taught</param>
        /// <param name="lecturerList">LinkedList with a List of Lecturers</param>
        /// <param name="courseId">The course the module is on</param>
        public Module(string id, string name, bool pratical, int hoursPerWeek, string roomType, bool doubleSlots, int maxConsecHours, string courseId)
        {
            this.ID = id;
            this.name = name;
            this.practical = practical;
            this.hoursPerWeek = hoursPerWeek;
            this.RoomType = roomType;
            this.doubleSlots = doubleSlots;
            this.maxConsecHours = maxConsecHours;
            this.courseId = courseId;
        }
    }
}
