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
        public void addCourse(Course theCourse)
        {
            dataBaseHelper.insertCourse(theCourse);
            dataBaseHelper.update();
        }
        public void addModule(Module theModule)
        {
            dataBaseHelper.insertModule(theModule);
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
            dataBaseHelper.updateLecturer(theLec);
            dataBaseHelper.update();
        }


        public void deleteLecturer(string id)
        {
            //to be constructed!
        }
        public void deleteCourse(string code)
        {
            dataBaseHelper.deleteCourse(code);
            dataBaseHelper.update();
        }
        public DataTable getDataTable(string sqlstatement)
        {
            return dataBaseHelper.getDataTable(sqlstatement);
           // return dataBaseHelper.getDataTable(
        }

        public void updateCourse(Course theCourse)
        {
            dataBaseHelper.updateCourse(theCourse);
            dataBaseHelper.update();
        }
        public void updateModule(Module theModule)
        {
            dataBaseHelper.updateModule(theModule);
            dataBaseHelper.update();
        }

    }//class
}
