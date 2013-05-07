using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
		public class Room 
        {
            /// <summary>
            /// ID will be used for identifying the Room in the database.
            /// </summary>
            public string ID { get; set; }
            /// <summary>
            /// The maximum number of students that a room can host.
            /// </summary>
            public int capacity { get; set; }
            /// <summary>
            /// The room number is the number/name of the room in the building.
            /// </summary>
            public string roomNumber { get; set; }
            /// <summary>
            /// The room type specifies the purpose of the room used for.
            /// </summary>
            public string roomType { get; set; }
            /// <summary>
            /// The time slots that a room is not available for hosting a class
            /// </summary>
            public string slotsOff { get; set; }
            /// <summary>
            /// id of the building the room is in
            /// </summary>
            public string buildingId { get; set; }

            private string slotsUsed;
            
            /// <summary>
            /// Default constructor of the Room class.
            /// </summary>
            /// <param name="roomNum">number of the room</param>
            /// <param name="capacity">number of students room can hold</param>
            /// <param name="roomType">Lab or Lecturer hall</param>
            /// <param name="slotsOff">time room is not available</param>
            public Room(string roomNum, int capacity, string roomType, string slotsOff)
            {
                this.roomNumber = roomNum;
                this.capacity = capacity;
                this.roomNumber = roomType;
                this.slotsOff = slotsOff;
            }
            /// <summary>
            /// constructer for database
            /// </summary>
            /// <param name="id">id of room</param>
            /// <param name="roomNum">number of the room</param>
            /// <param name="capacity">number of students room can hold</param>
            /// <param name="roomType">Lab or Lecturer hall</param>
            /// <param name="slotsOff">time room is not available</param>
            public Room(string id, string roomNum, int capacity, string roomType, string slotsOff, string buildingId)
            {
                this.ID = id;
                this.roomNumber = roomNum;
                this.capacity = capacity;
                this.roomNumber = roomType;
                this.slotsOff = slotsOff;
                this.buildingId = buildingId;
            }

            public Boolean available(String time)
            {
                string temp = slotsOff + slotsUsed;
                bool answer = false;

                while (temp != null)
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
