using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Lecturer
    {
        /// <summary>
        /// ID  will be used for identifying the Lecturer in the database
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// This will be the name of the Lecturer
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The initials of the lecturer will be used for the final timetable.
        /// </summary>
        public string initials { get; set; }
        /// <summary>
        /// This is the email address of the Lecturer.
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Maximum number of hours that Lecturer is available to work.
        /// </summary>
        public int maxHours { get; set; }
        /// <summary>
        /// Maximum number of consecutive hours that a Lecturer can teach during the day.
        /// </summary>
        public int maxConsecHours { get; set; }
        /// <summary>
        /// The minimum number of hours that a Lecturer can teach.
        /// </summary>
        public int minSlotsPerDay { get; set; }
        /// <summary>
        /// Different slots of time that a lecturer is not available.
        /// </summary>
        public string slotsOff { get; set; }
        /// <summary>
        /// The Id of the dept the lecturer is in
        /// </summary>
        public string deptId { get; set; }
        /// <summary>
        /// the slots the lecturer already has class
        /// </summary>
        private string slotsOccupied;

        /// <summary>
        ///     The method constructs new object and sets properties
        /// </summary>
        public Lecturer(string name, string initials, string email, int maxHours, int maxConsecHours,
            int minSlotsPerDay, string slotsOff, string deptId)
        {
            this.name = name;
            this.initials = initials;
            this.email = email;
            this.maxHours = maxHours;
            this.maxConsecHours = maxConsecHours;
            this.minSlotsPerDay = minSlotsPerDay;
            this.slotsOff = slotsOff;
            this.deptId = deptId;
        }
        /// <summary>
        ///    This method is used when loading from database
        /// </summary>
        /// <param name="name">String value for the name of lecturer</param>
        /// <param name="initials">String value for the initials of lecturer</param>
        /// <param name="email">String value for email details</param>
        /// <param name="maxHours">Integer value for Maximum number of hours during the week</param>
        /// <param name="maxConsecHours">Integer value for maximum consecutive hours a lecturer can teach</param>
        /// <param name="minSlotsPerDay">Integer value for the minimum amount of hours that a Lecturer can teach.</param>
        /// <param name="slotsOff">String value for the time slots that a lecturer is not available.</param>
        public Lecturer(string id ,string name, string initials, string email, int maxHours, int maxConsecHours, 
            int minSlotsPerDay, string slotsOff, string deptId)
        {
            this.ID = id;
            this.name = name;
            this.initials = initials;
            this.email = email;
            this.maxHours = maxHours;
            this.maxConsecHours = maxConsecHours;
            this.minSlotsPerDay = minSlotsPerDay;
            this.slotsOff = slotsOff;
            this.deptId = deptId;
        }
        /// <summary>
        /// checks is the Lecturer available at a given time
        /// </summary>
        /// <param name="time">the time to check availablity for</param>
        /// <returns>bool whether or the lecturer is available</returns>
        public bool available(string time)
        {
            //better if checkes slots occupied first 
            //sepearte soft and hard constraint
            bool answer = false;
            string temp = slotsOff + slotsOccupied;
            while (temp != null && answer == false)
            {
                if (time == (temp = temp.Substring(0, temp.IndexOf(':'))))
                {
                    answer = true;
                } 
            }
            return answer;
        }
    }
}
