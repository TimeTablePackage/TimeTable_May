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
        string selectedRecordToEdit = "";
        string courseCode = "";
        string fillCourseSqlString = "SELECT Code,CourseName,NumOfStudents,DeptID FROM Course WHERE Deleted LIKE false";
        DomainControler controller = DomainControler.getInstance();
        public CourseForm()
        {
            InitializeComponent();
        }


        private void CourseForm_Load(object sender, EventArgs e)
        {
            //In the Load event of CourseForm DataGridView boxes will be filled with data from the database.
            fillCourse(fillCourseSqlString);
            fillDepartment();
        }

        //The fillCourse method will load the relevant data from the database to the courseDataGridView.
        private void fillCourse(string sqlString)
        {
            CourseDataGridView.DataSource = controller.getDataTable(sqlString);
            CourseDataGridView.Columns[0].HeaderText = "Course Code";
            CourseDataGridView.Columns[1].HeaderText = "Course Name";
            CourseDataGridView.Columns[2].HeaderText = "Number of Students";
            CourseDataGridView.Columns[3].HeaderText = "Department";
        }
        //The fillDepartment method will load the relevant data from the database to the DepartmentGridView.
        private void fillDepartment()
        {
            string sqlString = "SELECT ID,Dept_Name FROM Department WHERE Deleted LIKE false";
            DepartmentDataGridView.DataSource = controller.getDataTable(sqlString);
            DepartmentDataGridView.Columns[0].HeaderText = "ID";
            DepartmentDataGridView.Columns[1].HeaderText = "Department Name";
        }

        //The Click Event of "Add" Button Will Pop-up a Form to Fill the Details of a new Course.
        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddEditCourseForm addCourseForm = new AddEditCourseForm();
            addCourseForm.Show();
        }

        //The Click Event Of Remove Button Will Remove the Selected Record from the Database.
        //If There is no record in the database ,it will inform user with an appropriate message.
        private void deleteCourseButton_Click(object sender, EventArgs e)
        { 
            if (CourseDataGridView.RowCount > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    controller.deleteCourse(courseCode);
                    MessageBox.Show("Record has been removed successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillCourse(fillCourseSqlString);
                }
            }
            else
             {
                 MessageBox.Show("There is no record to be removed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        //The Click Event of "Edit" Button Will Pop-up a Form with details of the Selected Record.
        //If there is no record in the databse,the software will inform the user with an appropriate message.
        private void editCourseButton_Click(object sender, EventArgs e)
        {
            if (CourseDataGridView.RowCount > 0)
            {
                Domain.Course theCourse = controller.getDBHelper().getCourseById(selectedRecordToEdit);
                AddEditCourseForm addCourseForm = new AddEditCourseForm(theCourse);
                addCourseForm.Show();
            }
            else
            {
                MessageBox.Show("There is no record found to be edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //The following CellEnter event allows user to identify which record is being dealt with.
        private void CourseDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = CourseDataGridView.CurrentCell.RowIndex;
            selectedRecordToEdit = CourseDataGridView.Rows[rowindex].Cells[0].Value.ToString();
            courseCode = CourseDataGridView.Rows[rowindex].Cells[0].Value.ToString(); ;
        }

        //The following CellEnter event allows user to see the Courses on the Selected Department.
        //The courses on the CourseDataGridView will Change simultaneously with the Selected Department.
        private void DepartmentDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string selectedRowString;
            int rowindex = DepartmentDataGridView.CurrentCell.RowIndex;
            selectedRowString = DepartmentDataGridView.Rows[rowindex].Cells[0].Value.ToString();
            fillCourse("SELECT Code,CourseName,NumOfStudents,DeptID FROM Course WHERE DeptID LIKE " + selectedRowString + "AND Deleted LIKE false");
        }
    }
}
