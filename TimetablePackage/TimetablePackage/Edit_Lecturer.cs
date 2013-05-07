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

namespace TimetablePackage
{
    
    public partial class Edit_Lecturer : DockableForm 
    {
        Domain.Lecturer thelec;
        String tempSlotsOff;
        String slotsOff;
        DomainControler controller = DomainControler.getInstance();
        bool insert;

        public Edit_Lecturer()
        {
            InitializeComponent();
            insert = true;
            this.editLecturerGroupBox.Text = "Add a Lecturer";
            this.TabText = "Add a Lecturer";
            this.Text = "Add a Lecturer";    
        }

        public Edit_Lecturer(Domain.Lecturer theLec)
        {
            this.thelec = theLec;
            InitializeComponent();
            insert = false;
        }
        
        private void okayButton_Click(object sender, EventArgs e)
        {
            saveChanges();            
        }
        public void saveChanges()
        {
            String name = editLecNameTextBox.Text;
            String initials = editLecInitialsTextBox.Text;
            String email = editLecEmailTextBox.Text;
            int maxHours = Convert.ToInt32(editLecMaxHoursTextBox.Text);
            int maxConsecHours = Convert.ToInt32(editLecMaxConsecHours.Text);
            int minSlotsPerday = Convert.ToInt32(editLecMinimumSlotsTextBox.Text);
            String slotsOff = "";
            String department = editLectDepartmentTextBox.Text;

            Domain.Lecturer lecturer = new Domain.Lecturer(name, initials, email, maxHours, maxConsecHours, minSlotsPerday, slotsOff, department);

            controller.addLecturer(lecturer);

        }

        public void loadForEdit()
        {
            editLecNameTextBox.Text = thelec.name;
            editLecInitialsTextBox.Text = thelec.initials;
            editLecEmailTextBox.Text = thelec.email;
            editLecMaxHoursTextBox.Text = thelec.maxHours.ToString();
            editLecMaxConsecHours.Text = thelec.maxConsecHours.ToString();
            editLecMinimumSlotsTextBox.Text = thelec.minSlotsPerDay.ToString();
            editLectDepartmentTextBox.Text = thelec.deptId.ToString();
        }

            private void commonEventHandler(object sender, System.EventArgs e)
            {
                 CheckBox myCheckBox = (CheckBox)sender;
                 if( myCheckBox.CheckState == CheckState.Checked )
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
                if (insert == false)
                {
                    loadForEdit();
                }
            }
            
        
            
    }
}
