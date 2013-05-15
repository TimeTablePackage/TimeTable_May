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
    public partial class ModifyModule : DockableForm
    {
        Domain.Module theModule;
        DomainControler controller = DomainControler.getInstance();
        string moduleName;
        bool isModulePractical = false ;
        int hoursPerWeek;
        string requiredRoomType;
        int maxConsecSlots;
        bool doubleSlots = false ;
        string CourseId;
        bool isAllFieldsFilled;
        bool parseSuccess;
        bool addNewModule = false;
        int maximumWeeklyHours = 40;
        int minimumWeeklyHours;
        public ModifyModule()
        {
            InitializeComponent();
            addNewModule = true;
        }
        public ModifyModule(Domain.Module theModule)
        {
            this.theModule = theModule ;
            InitializeComponent();
            this.Text = "Edit Module";
            this.modifyModuleGroupBox.Text = "Edit Module";
            loadForEdit();
        }

        private void ModifyModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttpDataSet.Module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.ttpDataSet.Module);
            // TODO: This line of code loads data into the 'ttpDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.ttpDataSet.Room);
            // TODO: This line of code loads data into the 'ttpDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.ttpDataSet.Course);
            //if (addNewModule == false)
            //{
            //    loadForEdit();
            //}
        }

        private void moduleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }
        }

        private void moduleHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void moduleMaxConTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        public void saveChanges()
        {
            moduleName = moduleNameTextBox.Text;
            requiredRoomType = requiredRoomTypeComboBox.SelectedValue.ToString();
            CourseId = courseNameComboBox.SelectedValue.ToString();
            if (allowDoubleComboBox.SelectedIndex.ToString() == "Yes")
            {
                doubleSlots = true;
            }
            if (isPracticalComboBox.SelectedValue.ToString() == "Yes")
            {
                isModulePractical = true;
            }


            foreach (Control c in this.modifyModuleGroupBox.Controls)
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
            else
            {
                // If the user has filled all the fields, make the changes.Either add a new module or edit a module
                if (addNewModule == true)
                {
                    Domain.Module module = new Domain.Module(moduleName, isModulePractical, hoursPerWeek, requiredRoomType,doubleSlots, maxConsecSlots,CourseId);
                    controller.addModule(module);
                }
                else
                { // The following code will update the module
                    theModule.name = moduleName;
                    theModule.practical = isModulePractical;
                    theModule.hoursPerWeek = hoursPerWeek;
                    theModule.RoomType = requiredRoomType ;
                    theModule.doubleSlots = doubleSlots;
                    theModule.maxConsecHours = maxConsecSlots;
                    theModule.courseId = CourseId;
                    controller.updateModule(theModule);
                }
            }
        }

        private void moduleNameTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        public void loadForEdit()
        {
            moduleNameTextBox.Text = theModule.name;
            moduleHoursTextBox.Text = theModule.hoursPerWeek.ToString();
            //requiredRoomTypeComboBox.SelectedValue = theModule.RoomType.ToString() ;
            moduleMaxConTextBox.Text = theModule.maxConsecHours.ToString();
            courseNameComboBox.SelectedValue = theModule.courseId.ToString();

            if (theModule.doubleSlots == true)
            {

                allowDoubleComboBox.SelectedIndex = 1;
            }
            if (theModule.practical == true)
            {

                isPracticalComboBox.SelectedIndex = 1 ;
            }
        }
        private void moduleHoursTextBox_Validating(object sender, CancelEventArgs e)
        {
            try//Check for the 'Maximum Hours'
            {
                parseSuccess = int.TryParse(moduleHoursTextBox.Text, out hoursPerWeek);
                if (parseSuccess == true && (hoursPerWeek < maximumWeeklyHours))
                {
                    MessageBox.Show("The number of hours cannot be greater than " + maximumWeeklyHours , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input for 'Hours Per Week'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moduleMaxConTextBox_Validating(object sender, CancelEventArgs e)
        {
            try//Check for the 'Maximum Consecutive Hours'
            {
                parseSuccess = int.TryParse(moduleMaxConTextBox.Text , out maxConsecSlots);
                if (parseSuccess == true && (maxConsecSlots > 8))
                {
                    MessageBox.Show("The  number of  maximum consecutive hours cannot be greater than " + 8, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input for 'Max. Consecutive Hours'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moduleOkayButton_Click(object sender, EventArgs e)
        {
            saveChanges();
        }
    }
}
