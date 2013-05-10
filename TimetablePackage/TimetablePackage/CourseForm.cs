using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalRune.Windows.Docking;

namespace TimetablePackage
{
    public partial class CourseForm : DockableForm
    {
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
