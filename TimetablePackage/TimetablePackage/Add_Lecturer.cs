using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace TimetablePackage
{
    
    public partial class Add_Lecturer : Form
    {
        DomainControler controller = DomainControler.getInstance();
        public Add_Lecturer()
        {
            InitializeComponent();
        }
        
        private void okayButton_Click(object sender, EventArgs e)
        {
            String name = lecNameTextBox.Text ;
            String initials = lecInitialsTextBox.Text ;
            String email = lecEmailTextBox.Text ;
            int maxHours =Convert.ToInt32( lecMaxHoursTextBox.Text) ;
            int maxConsecHours  = Convert.ToInt32(lecMaxConsecHours.Text);
            int minSlotsPerday = Convert.ToInt32(lecMinimumSlotsTextBox.Text);
            String slotsOff = lecSlotsOffTextBox.Text;
            String department = lectDepartmentTextBox.Text ;

            Domain.Lecturer lecturer = new Domain.Lecturer(name, initials, email, maxHours, maxConsecHours, minSlotsPerday, slotsOff, department);

            controller.addLecturer(lecturer);
            
        }
    }
}
