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
    public partial class CourseForm : DockableForm
    {
        string selectedRowString;
        DomainControler controller = DomainControler.getInstance();
        public CourseForm()
        {
            InitializeComponent();
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttpDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.ttpDataSet.Department);
            // TODO: This line of code loads data into the 'ttpDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.ttpDataSet.Course);

        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddEditCourseForm addCourseForm = new AddEditCourseForm();
            addCourseForm.Show();
        }

        private void deleteCourseButton_Click(object sender, EventArgs e)
        {

        }

        private void editCourseButton_Click(object sender, EventArgs e)
        {
            Domain.Course theCourse = controller.getDBHelper().getCourseById(selectedRowString);
            AddEditCourseForm addCourseForm = new AddEditCourseForm(theCourse);
            addCourseForm.Show();
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

        private void CourseDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = CourseDataGridView.CurrentCell.RowIndex;

            selectedRowString = CourseDataGridView.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void DepartmentDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string selectedRowString;
            string sqlString;
            int rowindex = DepartmentDataGridView.CurrentCell.RowIndex;


            selectedRowString = DepartmentDataGridView.Rows[rowindex].Cells[0].Value.ToString();
            sqlString = "SELECT * FROM Course WHERE DeptID LIKE " + selectedRowString;
            CourseDataGridView.DataSource = controller.getDataTable(sqlString);
        }
    }
}
