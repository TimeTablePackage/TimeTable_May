using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DigitalRune.Windows.Docking;
using System.Threading;
using Domain;


namespace TimetablePackage
{
    public partial class Main : Form
    {
        private DomainControler controler;

        public Main()
        {
            Thread t = new Thread(new ThreadStart(Splashscreen));
            t.Start();
            Thread.Sleep(2500);
            InitializeComponent();
            t.Abort();
            controler = DomainControler.getInstance();
        }

        public void Splashscreen()
        {
            Application.Run(new SplashScreen());
        }


       

        private void Main_Load(object sender, EventArgs e)
        {
            timetable  document = new timetable();

            // Show document
            if (DockTabPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                document.MdiParent = this;
                document.Show();
            }
            else
            {
                document.Show(DockTabPanel);
            }     
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about aboutbox = new about();

            aboutbox.Show();
        }

        private void settingButton_Click(object sender, EventArgs e)
        { //Open the settingsForm when the user clicks "Settings" button
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private bool CheckForm(Form form)
        {
            string formName = form.Name;
            form = Application.OpenForms[formName];
            if (form != null)
                return true;
            else
                return false;
        }
        
        private void ribbonButton1_Click(object sender, EventArgs e)
        {
           Lecturer LecturerForm = new Lecturer();
            // Show document
           if (DockTabPanel.DocumentStyle == DocumentStyle.SystemMdi)
           {
               LecturerForm.MdiParent = this;
               LecturerForm.Show();
           }
           else
           {
               if (!CheckForm(LecturerForm))
               {
                   LecturerForm.Show(this.DockTabPanel);
               }
               else
               {
                   LecturerForm.WindowState = FormWindowState.Normal;
                   LecturerForm.BringToFront();
                   LecturerForm.Activate();
               }
           }
            
        }
        private void addLecturer_Click(object sender, EventArgs e)
        {
            Edit_Lecturer openWindow = new Edit_Lecturer();
            openWindow.Show(); 
        }

        private void moduleListButton_Click(object sender, EventArgs e)
        {
            ModuleForm document = new ModuleForm();

            // Show document
            if (DockTabPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                document.MdiParent = this;
                document.Show();
            }
            else
            {
                if (!CheckForm(document))
                {
                    document.Show(this.DockTabPanel);
                }
                else
                {
                    document.WindowState = FormWindowState.Normal;
                    document.BringToFront();
                    document.Activate();
                }
            }
        }

        private void courseListButton_Click(object sender, EventArgs e)
        {
            CourseForm document = new CourseForm();

            // Show document
            if (DockTabPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                document.MdiParent = this;
                document.Show();
            }
            else
            {
                if (!CheckForm(document))
                {
                    document.Show(this.DockTabPanel);
                }
                else
                {
                    document.WindowState = FormWindowState.Normal;
                    document.BringToFront();
                    document.Activate();
                }
            }
        }

        

        private void buildingListButton_Click_1(object sender, EventArgs e)
        {
            BuildingForm document = new BuildingForm();

            // Show document
            if (DockTabPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                document.MdiParent = this;
                document.Show();
            }
            else
            {
                if (!CheckForm(document))
                {
                    document.Show(this.DockTabPanel);
                }
                else
                {
                    document.WindowState = FormWindowState.Normal;
                    document.BringToFront();
                    document.Activate();
                }
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Generate gen = new Generate();
            timetable document = new timetable();

            // Show document
            if (DockTabPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                document.MdiParent = this;
                document.Show();
            }
            else
            {
                document.Show(DockTabPanel);
            }
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddEditCourseForm addNewCourseForm = new AddEditCourseForm();
            addNewCourseForm.Show();
        }

        private void addModuleButton_Click(object sender, EventArgs e)
        {
            ModifyModule addNewModule = new ModifyModule();
            addNewModule.Show();
        }
    }
}
