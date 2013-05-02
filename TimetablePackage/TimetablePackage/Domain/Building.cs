using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Building
    {
        private DomainControler controler = DomainControler.getInstance();
        private DataBase dbhelper;
        /// <summary>
        /// Generates a Id for new Building
        /// </summary>
        private static int autoNumber { get; set; }
        /// <summary>
        /// A string containing the Id of the building.
        /// mainly used in the database
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// A string containing the name of the college
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Defualft constructer;
        /// </summary>
        public Building()
        {
            this.ID = ID;
        }
        /// <summary>
        /// Constructer for database load.
        /// </summary>
        /// <param name="id">the id of the building</param>
        /// <param name="name">string containing the name of the building</param>
        public Building(string id, string name)
        {
            this.ID = id;
            this.name = name;
        }

        public LinkedList getRooms()
        {
           return dbhelper.getRoomList(this);
        }
        
    }
}
