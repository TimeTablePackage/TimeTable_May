﻿using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace Domain
{
    public sealed class DomainControler
    {
        public static DomainControler instance = new DomainControler();
        /// <summary>
        /// Class to load/save objects from/to the database
        /// </summary>
        private DataBase dataBaseHelper;
        /// <summary>
        /// The institute the timetable is for
        /// </summary>
        private Institute institute;
        /// <summary>
        /// Private constructer called on start-up, loads the data from the database
        /// </summary>
        private DomainControler()
        {
            dataBaseHelper = new DataBase();
            dataBaseHelper.update();
            institute = new Institute("it carlow");
        }
        /// <summary>
        /// Get an instance of the controller
        /// </summary>
        /// <returns></returns>
        public static DomainControler getInstance()
        {
                return instance;
        }
        /// <summary>
        /// get an instance of the database helper
        /// </summary>
        /// <returns></returns>
        public DataBase getDBHelper()
        {
            return dataBaseHelper;

        }

        public void addRoom(Room theRoom)
        {
            dataBaseHelper.insertRoom(theRoom);
            dataBaseHelper.update();
        }

        public void addLecturer(Lecturer theLec)
        {
            dataBaseHelper.insertLecturer(theLec);
            dataBaseHelper.update();
            
        }

        /// <summary>
        ///    Update the values in the Lecturer
        /// </summary>
        /// <param name="name">String value for the name of lecturer</param>
        /// <param name="initials">String value for the initials of lecturer</param>
        /// <param name="email">String value for email details</param>
        /// <param name="maxHours">Integer value for Maximum number of hours during the week</param>
        /// <param name="maxConsecHours">Integer value for maximum consecutive hours a lecturer can teach</param>
        /// <param name="minSlotsPerDay">Integer value for the minimum amount of hours that a Lecturer can teach.</param>
        /// <param name="slotsOff">String value for the time slots that a lecturer is not available.</param>
        public void updateLecturer(Lecturer theLec)
        {
<<<<<<< HEAD
            // Department department = institute.getDeptById(deptId);
            //Lecturer lecturer = department.getLecById(lecId);
            //lecturer.update(name, initials, email, maxHours, maxConsecHours, minSlotsPerDay, slotsOff, deptId);
=======
            dataBaseHelper.updateLecturer(theLec);
            dataBaseHelper.update();
>>>>>>> origin/ayhan4
        }


        public void deleteLecturer(string id)
        {
            //to be constructed!
        }

        public DataTable getDataTable(string sqlstatement)
        {
            return dataBaseHelper.getDataTable(sqlstatement);
        }

        public string[][] GenerateTimetable()
        {
            Generate gen = new Generate();
            Lesson[][] timeTable = gen.getTimetable();
            string[][] timeTableStr = new string[timeTable[0].Length][];
            for (int i = 0; i < timeTableStr.Length; i++)
            {
                timeTableStr[i] = new string[timeTable.Length];
                for (int y = 0; y < timeTableStr[i].Length; y++)
                {
                    if (timeTable[y][i] != null)
                    {
                        timeTableStr[i][y] = timeTable[y][i].ToString();
                    }
                    else
                    {
                        timeTableStr[i][y] = "off";
                    }
                }
            }
            return timeTableStr;
            
        }

    }//class
}
