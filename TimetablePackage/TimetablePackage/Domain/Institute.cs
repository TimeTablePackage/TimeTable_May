using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Institute
    {
        private static int autoNumber { get; set; }
        /// <summary>
        /// The Name of the Instuite
        /// </summary>
        private string name { get; set; }
        /// <summary>
        /// id of the instutite
        /// </summary>
        private string Id { get; set; }
        /// <summary>
        ///     Defualt Constructer that sets name.
        /// </summary>
        /// <param name="name">the Name</param>
        public Institute(string name)
        {
           this.Id = autoNumber++.ToString();
           this.name =  name;
        }
        /// <summary>
        /// Constructer for database
        /// </summary>
        /// <param name="id">The Id</param>
        /// /// <param name="name">The Name</param>
        public Institute(string id, string name)
        {
            this.Id = id;
            this.name = name;
        }

    }//class
}
