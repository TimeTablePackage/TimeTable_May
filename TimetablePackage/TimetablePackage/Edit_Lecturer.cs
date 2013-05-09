using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;
using DigitalRune.Windows.Docking;
using System.Text.RegularExpressions;

namespace TimetablePackage
{

    public partial class Edit_Lecturer : DockableForm
    {
        Domain.Lecturer thelec;
        String tempSlotsOff;
        String name ;
        String initials ;
        String email;
        int maxHours;
        int maxConsecHours;
        int minSlotsPerday;
        String slotsOff = "";
        String department ;
        bool isAllFieldsFilled = true;
        bool parseSuccess = false;
        DomainControler controller = DomainControler.getInstance();
        bool addNewLecture;
        int minimumHours = 1;
        int maximumWeeklyHours = 40;
        int dailyHours = 8;

        public Edit_Lecturer()
        {
            InitializeComponent();
            addNewLecture = true;
            this.LecturerGroupBox.Text = "Add a Lecturer";
            this.TabText = "Add a Lecturer";
            this.Text = "Add a Lecturer";
        }

        public Edit_Lecturer(Domain.Lecturer theLec)
        {
            this.thelec = theLec;
            InitializeComponent();
            addNewLecture = false;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            saveChanges();
        }
        public void saveChanges()
        {
            name = LecNameTextBox.Text;
            initials = LecInitialsTextBox.Text;
            email = LecEmailTextBox.Text;
            department = LectDepartmentComboBox.SelectedValue.ToString();
            isAllFieldsFilled = true ;

            foreach (Control c in this.LecturerGroupBox.Controls)
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
            if (isAllFieldsFilled == true)
            {    // When the Field is not empty,Check if the fields Contains a valid data e.g, int32
                if (addNewLecture == true)
                {
                    Domain.Lecturer lecturer = new Domain.Lecturer(name, initials, email, maxHours, maxConsecHours, minSlotsPerday, slotsOff, department);
                    controller.addLecturer(lecturer);
                }
                else
                { // The following code will update the lecturer
                    thelec.name = name;
                    thelec.initials = initials;
                    thelec.email = email;
                    thelec.maxHours = maxHours;
                    thelec.maxConsecHours = maxConsecHours;
                    thelec.minSlotsPerDay = minSlotsPerday;
                    thelec.deptId = LectDepartmentComboBox.SelectedValue.ToString();

                    controller.updateLecturer(thelec);
                }
                
            }
        }

 


           // if (maxHours < minSlotsPerday * 5 )
          //  {
           //     MessageBox.Show("The total number of minimum daily hours cannot be greater than Maximum number of hours","Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
           // }
           // Domain.Lecturer lecturer = new Domain.Lecturer(name, initials, email, maxHours, maxConsecHours, minSlotsPerday, slotsOff, department);

           // controller.addLecturer(lecturer);

        public void loadForEdit()
        {
            LecNameTextBox.Text = thelec.name;
            LecInitialsTextBox.Text = thelec.initials;
            LecEmailTextBox.Text = thelec.email;
            LecMaxHoursTextBox.Text = thelec.maxHours.ToString();
            LecMaxConsecHours.Text = thelec.maxConsecHours.ToString();
            LecMinimumSlotsTextBox.Text = thelec.minSlotsPerDay.ToString();
            LectDepartmentComboBox.SelectedValue = thelec.deptId.ToString();
        }

        private void commonEventHandler(object sender, System.EventArgs e)
        {
            CheckBox myCheckBox = (CheckBox)sender;
            if (myCheckBox.CheckState == CheckState.Checked)
            {
                myCheckBox.ImageKey = "tick.png";
                tempSlotsOff += myCheckBox.Tag.ToString() + ":";
            }
            else if (myCheckBox.CheckState == CheckState.Unchecked)
            {
                myCheckBox.ImageKey = "cross.png";
                slotsOff = tempSlotsOff.Replace(myCheckBox.Tag.ToString() + ":", "");
            }
        }
        private void Edit_Lecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttpDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.ttpDataSet.Department);
            if (addNewLecture == false)
            {
                loadForEdit();
            }
        }
        private void editLecNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            acceptLetterOnly(e);
        }
        public void acceptLetterOnly(KeyPressEventArgs e)
        { // This method will allow user to only input letters in the textbox.
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)32)
            {
                e.Handled = true;
            }
        }
        private void editLecInitialsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//Call for the 'acceptLetterOnly' method
            acceptLetterOnly(e);
        }
        private void editLecMaxHoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//Call for the 'acceptLetterOnly' method
            acceptDigitsOnly(e);
        }
        public void acceptDigitsOnly(KeyPressEventArgs e)
        { // This method will allow user to input only digits in the textbox.
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08  )
            {
                e.Handled = true;
            }
        }
        private void editLecMaxConsecHours_KeyPress(object sender, KeyPressEventArgs e)
        {//Call for the 'acceptDigitsOnly' method
            acceptDigitsOnly(e);
        }
        private void editLecMinimumSlotsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//Call for the 'acceptDigitsOnly' method
            acceptDigitsOnly(e);
        }
        private void editLecEmailTextBox_Validating(object sender, CancelEventArgs e)
        { // The Validating Event of the TextBox will check if the user input is a valid email address.
            //validEmailStructure is the structure of a typical e-mail address.Validity will be checked for the characters only
            string validEmailStructrure = @"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            bool isValidEmail = System.Text.RegularExpressions.Regex.IsMatch(LecEmailTextBox.Text,validEmailStructrure);

            if (LecEmailTextBox.Text.Length > 0)
            {
                if (isValidEmail == false)
                {
                    MessageBox.Show("Valid e-mail address is expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LecEmailTextBox.SelectAll();
                    e.Cancel = true;
                }
            }

        }

        private void editLecMaxHoursTextBox_Validating(object sender, CancelEventArgs e)
        {
            try//Check for the 'Maximum Hours'
            {
                parseSuccess = int.TryParse(LecMaxHoursTextBox.Text, out maxHours);
                if (parseSuccess == true && (maxHours < minimumHours || maxHours > maximumWeeklyHours))
                {
                    MessageBox.Show("The number of hours cannot be greater than " + maximumWeeklyHours + " or less than " + minimumHours, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input for 'Maximum Hours'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LecMinimumSlotsTextBox_Validating(object sender, CancelEventArgs e)
        {
            try//Check for the 'Minimum Daily Hours'
            {
                parseSuccess = int.TryParse(LecMinimumSlotsTextBox.Text, out minSlotsPerday);

                if (parseSuccess == true && (minSlotsPerday > dailyHours) || (minSlotsPerday > maxHours) || (minSlotsPerday * 5 > maxHours))
                {
                    MessageBox.Show("Minimum number of hours cannot be greater than " + dailyHours, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input for 'Minimum Daily Slots'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LecMaxConsecHours_Validating(object sender, CancelEventArgs e)
        {
            try//Check for the 'Maximum Consecutive Hours'
            {
                parseSuccess = int.TryParse(LecMaxConsecHours.Text, out maxConsecHours);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your input for 'Maximum Consecutive Hours'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
