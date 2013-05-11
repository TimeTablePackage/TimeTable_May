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
        bool editCourse;
        bool isAllFieldsFilled;
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
            foreach (Control c in this.addEditCourseGroupBox.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        isAllFieldsFilled = false;
                    }
                }
            }
            if (isAllFieldsFilled == false)
            {
                MessageBox.Show("All Fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                controller.addCourse(theCourse);
            }
        }
    }
}
