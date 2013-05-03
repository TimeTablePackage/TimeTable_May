using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalRune.Windows.Docking;
using System.Data.SqlClient;
using Domain;
namespace TimetablePackage
{
    public partial class BuildingForm : DockableForm
    {
        DomainControler controller = DomainControler.getInstance();
        public BuildingForm()
        {
            InitializeComponent();
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttpDataSet.Building' table. You can move, or remove it, as needed.
            this.buildingTableAdapter.Fill(this.ttpDataSet.Building);
            // TODO: This line of code loads data into the 'ttpDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.ttpDataSet.Room);
        }

      /*  private void buildingDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            string selectedRowString;

            int rowindex = buildingDataGridView.CurrentCell.RowIndex;
          //  int columnindex = buildingDataGridView.CurrentCell.ColumnIndex; 

           selectedRowString= buildingDataGridView.Rows[rowindex].Cells[0].Value.ToString();

            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ttp.accdb";
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = ConnectionString;

            string sql = "SELECT Room.[Number], Room.BuildingID, Room.Capacity, Room.SlotsOff FROM Room WHERE BuildingID LIKE '" + selectedRowString + "'";
            SqlDataAdapter myAdapter = new SqlDataAdapter(sql, myConnection);

            DataSet myDataSet = new DataSet("BuildingRooms");
            myAdapter.Fill(myDataSet, "BuildingRooms");

            roomdataGridView.DataSource = myDataSet.DefaultViewManager;
        }*/

        private void buildingDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string selectedRowString;
            string sqlString;
            int rowindex = buildingDataGridView.CurrentCell.RowIndex;
            //  int columnindex = buildingDataGridView.CurrentCell.ColumnIndex; 

            selectedRowString = buildingDataGridView.Rows[rowindex].Cells[0].Value.ToString();
            sqlString = "SELECT * FROM Room WHERE BuildingID LIKE " + selectedRowString ;
           roomdataGridView.DataSource =  controller.getDataTable(sqlString);
        }

        private void editBuildingButton_Click(object sender, EventArgs e)
        {

        }

        private void addBuildingButton_Click(object sender, EventArgs e)
        {

        }

        private void removeBuildingButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
