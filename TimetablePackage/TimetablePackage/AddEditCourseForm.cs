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
    public partial class AddEditCourseForm : DockableForm
    {
        bool editCourse ;
        bool isAllFieldsFilled = false ;
        String courseCode;
        String courseName;
        int numberOfStudents;
        String courseDeptId ;
        Domain.Course theCourse;
        DomainControler controller = DomainControler.getInstance();
        public AddEditCourseForm()
        {
            InitializeComponent();
        }
        public AddEditCourseForm(Domain.Course theCourse)
        {
            this.theCourse = theCourse;
            InitializeComponent();
            editCourse = true;
            this.addEditCourseGroupBox.Text = "Edit a Course";
        }

        private void AddEditCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttpDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.ttpDataSet.Department);
            if (editCourse == true)
            {
                loadForEdit();
            }   

        }
        public void loadForEdit()
        {// If the user has chosen to edit the selected course in the department.The details will be loaded to Textboxes.
            courseCodeTextBox.Text = theCourse.courseCode;
            courseNameTextBox.Text = theCourse.name;
            numOfStudentsTextBox.Text = theCourse.numOfStudents.ToString();
            addEditCourseComboBox.SelectedValue = theCourse.deptID;
        }
        public void saveChanges()
        {
            courseCode = courseCodeTextBox.Text;
            courseName = courseNameTextBox.Text;
            numberOfStudents = Int32.Parse( numOfStudentsTextBox.Text);
            courseDeptId = addEditCourseComboBox.SelectedValue.ToString();
            foreach (Control c in this.addEditCourseGroupBox.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        isAllFieldsFilled = false;
                    }
                    else
                    {
                        isAllFieldsFilled = true;
                    }

                }
            }
            if (isAllFieldsFilled == false)
            {
                MessageBox.Show("All Fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (editCourse == true)
                {
                    theCourse.courseCode = courseCode;
                    theCourse.name = courseName;
                    theCourse.numOfStudents = numberOfStudents;
                    theCourse.deptID = addEditCourseComboBox.SelectedValue.ToString();
                    controller.updateCourse(theCourse);                
                }
                else
                {

                    Domain.Course course = new Domain.Course(courseCode, courseName, numberOfStudents, courseDeptId);
                    controller.addCourse(course);
                }
            }
        }
        private void courseCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == false && e.KeyChar != (char)47 && e.KeyChar != (char)95 && e.KeyChar != (char)45 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void courseNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)32 && e.KeyChar != (char)38 && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void numOfStudentsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void courseCanButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void courseOkButton_Click(object sender, EventArgs e)
        {
            if (editCourse == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you want to save the changes", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    saveChanges();
                    this.Close();
                }
            }
            else
            {
                saveChanges();
                MessageBox.Show("A new course has been added to system successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }   
        }
    }
}
