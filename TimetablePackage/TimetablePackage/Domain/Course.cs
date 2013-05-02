using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public  class Course
    {
        public string ID { get; set; }
        /// <summary>
        /// The code of the course
        /// </summary>
        public string courseCode { get; set; }
        /// <summary>
        /// Name of the course
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Number of students in the course
        /// </summary>
        public int numOfStudents { get; set; }

        public string deptID { get; set; }

        /// <summary>
        ///     Defuault Constructer
        /// </summary>
        /// <param name="courseCode">code of the course</param>
        /// <param name="name">name of the course</param>
        /// <param name="numOfStudents">number of students in the course</param>
        public Course(string courseCode, string name, int numOfStudents, string deptId)
        {
            this.courseCode = courseCode;
            this.name = name;
            this.numOfStudents = numOfStudents;
            this.deptID = deptId;
        } 
        /// <summary>
        ///     Constructer for database
        /// </summary>
        /// <param name="id">the id of the course</param>
        /// <param name="courseCode">code of the course</param>
        /// <param name="name">name of the course</param>
        /// <param name="numOfStudents">number of students in the course</param>
        public Course(string id, string courseCode, string name, int numOfStudents, string deptId)
        {
            this.ID = id;
            this.courseCode = courseCode;
            this.name = name;
            this.numOfStudents = numOfStudents;
            this.deptID = deptId;
        } 
      
    
    }
}
