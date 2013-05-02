using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Department
    {
        public string ID { get; set; }
        /// <summary>
        /// The name of the Department
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///     Defuault Constructer
        /// </summary>
        public Department()
        {
        }
        /// <summary>
        ///     Constructer that sets name
        /// </summary>
        /// <param name="name">The name of the Department</param>
        public Department(String name)
        {
            this.name = name;
        }
        /// <summary>
        ///     Constructer for load from database
        /// </summary>
        /// <param name="id">the id of the departmnet</param>
        /// <param name="name">The name of the Department</param>
        public Department(string id,string name)
        {
            this.ID = id;
            this.name = name;
        }  
    }
}
