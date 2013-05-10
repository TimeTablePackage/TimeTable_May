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
            // TODO: This line of code loads data into the 'ttpDataSet.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.ttpDataSet.Lecturer);

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
