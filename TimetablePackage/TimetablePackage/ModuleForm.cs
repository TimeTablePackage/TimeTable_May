using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalRune.Windows.Docking;
using Domain;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace TimetablePackage
{
    public partial class ModuleForm : DockableForm
    {
        DomainControler controller = DomainControler.getInstance();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
       // private System.Data.OleDb.OleDbCommand oleDbSelectCommand1 ;
        string selectedRowString;
        public ModuleForm()
        {
            InitializeComponent();
        }
        private void ModuleForm_Load(object sender, EventArgs e)
        {
            DataTable moduleList = new DataTable();
            
            //bool isDeleted = false;
           
            string sqlString = "SELECT ID,Module_Name,Practical,HoursPerWeek,RoomType,MaxConsecSlots,DoubleSlots,CourseId FROM [Module] WHERE Deleted LIKE false" ;
          
            ModulesDataGridView.DataSource = controller.getDataTable(sqlString);
            ModulesDataGridView.Columns[0].HeaderText = "Module ID";
            ModulesDataGridView.Columns[1].HeaderText = "Module Name";
            ModulesDataGridView.Columns[2].HeaderText = "Is it Practical";
            ModulesDataGridView.Columns[3].HeaderText = "Weekly Hours";
            ModulesDataGridView.Columns[4].HeaderText = "Room Type";
            ModulesDataGridView.Columns[5].HeaderText = " Maximum Consecutive Hours";
            ModulesDataGridView.Columns[6].HeaderText = "Allow Double Slots?";
            ModulesDataGridView.Columns[7].HeaderText = "Course Name";
      
        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a  
                // valid connection string for a Northwind SQL Server sample 
                // database accessible to your system.
                String connectionString =
                    "Integrated Security=SSPI;Persist Security Info=False;" +
                    "Initial Catalog=Northwind;Data Source=C:\\Users\\hakan\\Documents\\GitHub\\TimeTable_May\\TimetablePackage\\TimetablePackage\\ttp.accdb";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                ModulesDataGridView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void addModuleButton_Click(object sender, EventArgs e)
        {
            ModifyModule addNewModule = new ModifyModule();
            addNewModule.Show();
        }

        private void editModuleButton_Click(object sender, EventArgs e)
        {
           Domain.Module theModule = controller.getDBHelper().getModuleById(selectedRowString);
            ModifyModule editModule = new ModifyModule(theModule);
            editModule.Show();
        }

        private void ModulesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = ModulesDataGridView.CurrentCell.RowIndex;
            //  int columnindex = buildingDataGridView.CurrentCell.ColumnIndex; 
            selectedRowString = ModulesDataGridView.Rows[rowindex].Cells[0].Value.ToString();
        }
    }
}
