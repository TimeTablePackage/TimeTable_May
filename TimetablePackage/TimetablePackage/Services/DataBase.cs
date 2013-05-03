using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Services
{   
   public class DataBase
    {
       private LinkedList deptList = new LinkedList();
       private LinkedList buildingList = new LinkedList();
       private LinkedList roomList = new LinkedList();
       private LinkedList moduleList = new LinkedList();
       private LinkedList lecturerList = new LinkedList();
       private LinkedList courseList = new LinkedList();

        /// <summary>
        /// A string for the OleDbConnection object to connect to the access database
        /// </summary>
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ttp.accdb";
        /// <summary>
        /// A OleDbConnection object to connect to the access database
        /// </summary>
        private OleDbConnection conn ;
        /// <summary>
        /// A string for the OleDbCommand object to excute SQL commands on the access database
        /// </summary>
        private OleDbCommand cmd;
        /// <summary>
        /// A OleDbDataReader to read the results of the SQL commands
        /// </summary>
        private OleDbDataReader reader;

        public DataBase()
        {
        }
        /// <summary>
        ///     Connect to access database
        /// </summary>
        private void OpenConection()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = connectionString ;
            try
             {
                conn.Open();
             }
            catch 
             {
                 Console.Write("no connection");
                //MessageBox.Show("Failed to connect to data source");
             }
        }
        /// <summary>
        ///     Disconnect from database
        /// </summary>
        private void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                Console.Write("No connection");
                //MessageBox.Show("Failed to close connection to data source");
            }
        }
        /// <summary>
        ///    Excute non-Query command on database i.e. INSERT or UPDATE
        /// </summary>
        /// <param name="sqlStatment">The SQL Command</param>
        private void excuteNonQuery(String sqlString)
        {
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        /// <summary>
        ///     Update a Lecturer in the database
        /// </summary>
        /// <param name="lecturers">The updated Lecturer</param>
        public void updateLecturer(Lecturer lecturer)
        {
            string sql;
            sql = "UPDATE Lecturer";
            sql += "Lec_Name='" + lecturer.name + "', ";
            sql += "Initials='" + lecturer.initials + "', ";
            sql += "Email='" + lecturer.email + "', ";
            sql += "MaxHours=" + lecturer.maxHours + ", ";
            sql += "MaxConsecHours=" + lecturer.maxConsecHours + ", ";
            sql += "MinSlotsPerDay=" + lecturer.minSlotsPerDay + ", ";
            sql += "SlotsOff='" + lecturer.slotsOff + "' ";
            sql += "WHERE ID LIKE '" + lecturer.ID + "'";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Add a new Lecturer to the database
        /// </summary>
        /// <param name="lecturer">The new Lecturer</param>
        public void insertLecturer(Lecturer lecturer)
        {
            string sql;
            sql = "INSERT INTO Lecturer ( Lec_Name, Initials, Email, MaxHours, MaxConsecHours, MinSlotsPerDay, SlotsOff, DepartmentId, Deleted) VALUES(";
            sql += "'" + lecturer.name + "', ";
            sql += "'" + lecturer.initials + "', ";
            sql += "'" + lecturer.email + "', ";
            sql += lecturer.maxHours + ", ";
            sql += lecturer.maxConsecHours + ", ";
            sql += lecturer.minSlotsPerDay + ", ";
            sql += "'" + lecturer.slotsOff + "',";
            sql += "'"+ lecturer.deptId +"',false)";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Update a Module in the database
        /// </summary>
        /// <param name="module">The updated Module</param>
        public void updateModule(Module module)
        {
            string sql;
            sql = "UPDATE Module";
            sql += "Module_Name='" + module.name + "', ";
            sql += "Practical=" + module.practical + ",";
            sql += "HoursPerWeek=" + module.hoursPerWeek + ", ";
            sql += "RoomType='" + module.RoomType + "', ";
            sql += "MaxConsecHours=" + module.maxConsecHours + ", ";
            sql += "DoubleSlots=" + module.doubleSlots;
            sql += ", CourseCode='" + module.courseId + "'";
            sql += "WHERE ID LIKE " + module.ID;
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Insert a new Module into the database
        /// </summary>
        /// <param name="module">The new Module</param>
        public void insertModule(Module module)
        {
            string sql;
            sql = "INSERT INTO Module (Module_Name, Practical, HoursPerWeek, RoomType, MaxConsecHours, DoubleSlots, CourseId, Deleted) VALUES(";
            sql += "'" + module.name + "', ";
            sql += module.practical + ",";
            sql += module.hoursPerWeek + ", ";
            sql += "'" + module.RoomType + "',";
            sql += module.maxConsecHours + ", ";
            sql += module.doubleSlots;
            sql += module.courseId + ", false)";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Update a Room in the database
        /// </summary>
        /// <param name="room">The updated Room</param>
        public void updateRoom(Room room)
        {
            string sql;
            sql = "UPDATE Room";
            sql += "Number='" + room.roomNumber + "', ";
            sql += "BuildingID='" + room.buildingId + "', ";
            sql += "Capacity=" + room.capacity + ", ";
            sql += "RoomType='" + room.roomType + "', ";
            sql += "SlotsOff='" + room.slotsOff + "', ";
            sql += "WHERE ID LIKE " + room.ID;
            excuteNonQuery(sql);
        }
        /// <summary>
        ///  Insert Room to the database
        /// </summary>
        /// <param name="room">The Room to be inserted</param>
        public void insertRoom(Room room)
        {
            string sql;
            sql = "INSERT INTO Room (Number, Capacity, RoomType, SlotsOff, Deleted) VALUES(";
            sql += "'"+room.roomNumber+"', ";
            sql += room.capacity + ", ";
            sql += "'" + room.roomType + "', ";
            sql += "'" + room.slotsOff + "', false ";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Update a Department
        /// </summary>
        /// <param name="dept">The updated Department</param>
        public void updateDept(Department dept)
        {
            string sql;
            sql = "Update Department Dept_Name=";
            sql += "'" + dept.name + "'";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Insert a department into the database
        /// </summary>
        /// <param name="dept">The Department to be inserted</param>
        public void insertDept(Department dept)
        {
            string sql = "INSERT INTO Department VALUES('"+ dept.name + "')";
            excuteNonQuery(sql);
        }
        /// <summary>
        /// update a course in the database
        /// </summary>
        /// <param name="course">the updated course</param>
        public void updateCourse(Course course)
        {
            string sql;
            sql = "UPDATE Course";
            sql += "Code=" + course.courseCode + ",";
            sql += "Course_Name='" + course.name + "', ";
            sql += "NumOfStudents=" + course.numOfStudents + ", ";
            sql += "DeptId='" + course.deptID + "', ";
            sql += "WHERE ID LIKE " + course.ID;
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Load all rooms
        /// </summary>
        /// <summary>
        /// insert building into database
        /// </summary>
        /// <param name="build"></param>
        public void insertBuild(Building build)
        {
            string sql = "INSERT INTO Building  VALUES('" + build.name + "')";
            excuteNonQuery(sql);
        }
        /// <summary>
        /// update a building
        /// </summary>
        /// <param name="build"></param>
        public void updateBuild(Building build)
        {
            string sql;
            sql = "Update Building Building_Name=";
            sql += "'" + build.name + "'";
            excuteNonQuery(sql);
        }
        /// <summary>
        /// load lecturer from database
        /// </summary>
        /// 
        private void loadLectuerList()
       {
            Lecturer newLec;
            string sqlStatment = "SELECT * FROM Lecturer";
            try{
                    OpenConection();
                    cmd = new OleDbCommand(sqlStatment, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Deleted"].ToString().Equals("False"))
                        {
                            newLec = new Lecturer(reader["ID"].ToString(),
                                reader["Lec_Name"].ToString(),
                                reader["Initials"].ToString(),
                                reader["Email"].ToString(),
                                Convert.ToInt32(reader["MaxHours"]),
                                Convert.ToInt32(reader["MaxConsecHours"]),
                                Convert.ToInt32(reader["MinSlotsPerDay"]),
                                reader["SlotsOff"].ToString(),reader["DepartmentID"].ToString());
                                lecturerList.addAtTail(newLec);
                        }
                    }
                    CloseConnection();
                }
                catch 
                {
                    // MessageBox.Show("Failed to get data from source");
                } 
        }
        /// <summary>
        ///     Load LinkedList of Course 
        /// </summary>
        private void loadCourseList()
        {
            Course tempCourse ;

            string sqlStatment = "SELECT * FROM Course"; 
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempCourse = new Course(reader["ID"].ToString(), 
                            reader["Code"].ToString(),
                            reader["CourseName"].ToString(), 
                            Convert.ToInt32(reader["NumOfStudents"]),
                            reader["DeptID"].ToString()
                            );
                        courseList.addAtTail(tempCourse);
                    }
                    
                }
                CloseConnection();
            }
            catch 
            {
                // MessageBox.Show("Failed to get data from source");
            }
        }
        /// <summary>
        /// load room list from the database
        /// </summary>
        private void loadRoomList()
        {
            Room tempRoom;
            string sqlStatment = "SELECT * FROM Room ";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempRoom = new Room(
                        reader["ID"].ToString(),
                        reader["Number"].ToString(),
                        Convert.ToInt32(reader["Capacity"]),
                        reader["RoomType"].ToString(),
                        reader["SlotsOff"].ToString(),
                        reader["BuildingID"].ToString());
                        roomList.addAtTail(tempRoom);
                    }
                }
                CloseConnection();
            }
            catch
            {
                // MessageBox.Show("Failed to get data from source");
            }
         }
         /// <summary>
         /// load all the depts from the database
         /// </summary>
        private void loadDepartmentList()
        {
            Department tempDept ;
            string sqlStatment = "SELECT * FROM Department";
            try 
	        {	        
		        OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempDept = new Department(
                            reader["ID"].ToString(),
                            reader["Dept_Name"].ToString());
                        deptList.addAtTail(tempDept);
                    }
                }
                CloseConnection();
	        }
	        catch (Exception e)
	        {
                MessageBox.Show(e.ToString());
	        }
        }
        /// <summary>
        /// load all the buildings from the database
        /// </summary>
        private void loadBuildingList()
        {
            Building tempBuild;
            string sqlStatment = "SELECT * FROM Building";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempBuild = new Building(
                            reader["ID"].ToString(), 
                            reader["Building_Name"].ToString());
                        buildingList.addAtTail(tempBuild);
                    }
                }
                CloseConnection();
            }
            catch 
            {

            }
        }
        /// <summary>
        ///     Loads all modules
        /// </summary>
        private void LoadModuleList()
        {
            Module tempModule;
            string sqlStatment = "SELECT * FROM [Module]";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempModule = new Module(
                        reader["ID"].ToString(),
                        reader["Module_Name"].ToString(),
                        Convert.ToBoolean(reader["Practical"]),
                        Convert.ToInt32(reader["HoursPerWeek"]),
                        reader["RoomType"].ToString(),
                        Convert.ToBoolean(reader["DoubleSlots"]),
                        Convert.ToInt32(reader["MaxConsecSlots"]),
                        reader["CourseId"].ToString());
                        moduleList.addAtTail(tempModule);
                        
                    }
                }
                CloseConnection();
                addLecToModule();
            }
            catch
            {
                throw;
            }

        }

        private void addLecToModule()
        {

            Node moduleNode = moduleList.head;
            Module theModule;

            while (moduleNode!=null)
            {
                theModule = (Module)moduleNode.data;
                String[] lecturers = theModule.lecturers;
                try
                {
                    OpenConection();
                    cmd = new OleDbCommand("SELECT * FROM [Lecturer/Module] WHERE Module_ID LIKE '" + theModule.ID + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        theModule.addLecturer(reader["Lecturer_ID"].ToString());
                    }
                    CloseConnection();
                }
                catch (Exception)
                {
                    throw;
                }
                moduleNode = moduleNode.next;
            }
        }

        /// <summary>
        /// update the linked lists
        /// </summary>
        public void update()
        {
            loadBuildingList();
            loadCourseList();
            loadDepartmentList();
            loadRoomList();
            loadLectuerList();
            LoadModuleList();
        }
        /// <summary>
        /// find room for a building
        /// </summary>
        /// <param name="build">the building the rooms are in</param>
        /// <returns>linked list of rooms in a building</returns>
        public LinkedList getRoomList(Building build)
        {
            LinkedList list = new LinkedList();
            Node roomNode = roomList.head;

            while (roomNode != null)
            {
                Room tempRoom = (Room)roomNode.data;
                if (tempRoom.buildingId == build.ID)
                {
                    list.addAtTail(tempRoom);
                }
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public LinkedList getModuleList()
        {
            return moduleList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public LinkedList getRoomList()
        {
            return roomList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public LinkedList getLecturerList()
        {
            return lecturerList;
        }
        /// <summary>
        /// find a lecturer based on their Idt
        /// </summary>
        /// <param name="id">the id of the lecturer</param>
        /// <returns>the lecturer object</returns>
        public Lecturer getLecturerById(string id)
        {
            Lecturer theLec;
            Node lecNode = lecturerList.head;
            theLec = (Lecturer) lecNode.data;
            while (theLec.ID != id && lecNode != null)
            {
                theLec = (Lecturer)lecNode.data;
                lecNode = lecNode.next;
            }
            return theLec;
        }
        /// <summary>
        /// return a course based on its is
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Course getCourseById(string id)
        {
            Course theCourse;
            Node courseNode = courseList.head;
            theCourse = (Course) courseNode.data;
            while (theCourse.ID != id && courseNode != null)
            {
                theCourse = (Course)courseNode.data;
                courseNode = courseNode.next;
            }
            return theCourse;
        }


    }

}

