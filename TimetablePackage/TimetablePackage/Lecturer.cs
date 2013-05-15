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

namespace TimetablePackage
{
    public partial class Lecturer : DockableForm
    {
        string selectedRowString;
        //DomainControler controller = DomainControler.getInstance();
        public Lecturer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            string sqlString = "SELECT ID,Email,Lec_Name,Initials,MaxHours,MaxConsecHours,MinSlotsPerDay,DepartmentId FROM Lecturer WHERE Deleted LIKE false";
            lecturerDataGridView.DataSource = controller.getDataTable(sqlString);
            lecturerDataGridView.Columns[0].HeaderText = "ID";
            lecturerDataGridView.Columns[1].HeaderText = "E-mail";
            lecturerDataGridView.Columns[2].HeaderText = "Lecturer Name";
            lecturerDataGridView.Columns[3].HeaderText = "Initials";
            lecturerDataGridView.Columns[4].HeaderText = "Maximum Hours";
            lecturerDataGridView.Columns[5].HeaderText = " Maximum Consecutive Hours";
            lecturerDataGridView.Columns[6].HeaderText = "Minimum Hours Per Day";
            lecturerDataGridView.Columns[7].HeaderText = "Department";
        }

        private void addLecturerButton_Click(object sender, EventArgs e)
        {
            //Opens a New Window for Adding a new Lecturer.
            Edit_Lecturer addNewLecturer = new Edit_Lecturer();
            addNewLecturer.Show();

        }

        private void editLecturerButton_Click(object sender, EventArgs e)
        {
            Domain.Lecturer theLec= controller.getDBHelper().getLecturerById(selectedRowString) ;
            Edit_Lecturer editLecturer = new Edit_Lecturer(theLec);
            editLecturer.Show();
        }

        private void lecturerDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = lecturerDataGridView.CurrentCell.RowIndex;
            //  int columnindex = buildingDataGridView.CurrentCell.ColumnIndex; 
            selectedRowString = lecturerDataGridView.Rows[rowindex].Cells[0].Value.ToString();
                     
        }
    }
}
