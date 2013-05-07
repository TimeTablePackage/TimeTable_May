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
        DomainControler controller = DomainControler.getInstance();
        bool insert;

        public Edit_Lecturer()
        {
            InitializeComponent();
            insert = true;
        }

        public Edit_Lecturer(Domain.Lecturer theLec)
        {
            this.thelec = thelec;
            InitializeComponent();
            insert = false;
        }
        
        private void okayButton_Click(object sender, EventArgs e)
        {
            String name = editLecNameTextBox.Text ;
            String initials = editLecInitialsTextBox.Text ;
            String email = editLecEmailTextBox.Text ;
            int maxHours =Convert.ToInt32( editLecMaxHoursTextBox.Text) ;
            int maxConsecHours  = Convert.ToInt32(editLecMaxConsecHours.Text);
            int minSlotsPerday = Convert.ToInt32(editLecMinimumSlotsTextBox.Text);
            String slotsOff = "";
            String department = editLectDepartmentTextBox.Text ;

            Domain.Lecturer lecturer = new Domain.Lecturer(name, initials, email, maxHours, maxConsecHours, minSlotsPerday, slotsOff, department);

            controller.addLecturer(lecturer);
            
        }

            private void commonEventHandler(object sender, System.EventArgs e)
            {
                 CheckBox myCheckBox = (CheckBox)sender ;
                
                 if( myCheckBox.CheckState == CheckState.Checked )
                    {
                        myCheckBox.ImageKey = "tick.png";
                        tempSlotsOff += myCheckBox.Tag.ToString() + ":";
                    }
                else if (myCheckBox.CheckState == CheckState.Unchecked)
                    {
                        myCheckBox.ImageKey = "cross.png";
                        String slotsOff = tempSlotsOff.Replace(myCheckBox.Tag.ToString() + ":", "");
                    }     
            }
        
            
    }
}
