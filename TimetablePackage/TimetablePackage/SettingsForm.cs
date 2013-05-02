using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TimetablePackage.Properties;
using System.Globalization;

namespace TimetablePackage
{

    public partial class SettingsForm : Form
    {
        DialogResult dresult;
        Main m_form;
        public SettingsForm()
        {
            
            InitializeComponent();
           // m_form = main;
        }
       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void settingsFormSaveButton_Click(object sender, EventArgs e)
        {

            Settings.Default["MainTitle"] = insNameTextBox.Text;
            Settings.Default["InstitutionName"] = insNameTextBox.Text;
            Settings.Default["AddressLine1"] = addLine1TextBox.Text;
            Settings.Default["AddressLine2"] = addLine2TextBox.Text;
            Settings.Default["AddressLine3"] = addLine3TextBox.Text;
            Settings.Default["CityName"] = cityTextBox.Text;
            Settings.Default["Country"] = countryComboBox.SelectedIndex.ToString();
            Settings.Default["WebSiteInfo"] = websiteTextBox.Text;
            Settings.Default["Telephone"] = telephoneTextBox.Text;
            Settings.Default["AcademicYearInfo"] = academicYearTextBox.Text;



            
              if (englishRadioButton.Checked == true )
                {
                    Settings.Default["isDefault"] = true;
                    Settings.Default["isTurkish"] = false;
                    Settings.Default["isFrench"] = false;
                }
               else if (turkishRadioButton.Checked == true)
                {
                Settings.Default["isTurkish"] = true ;
                Settings.Default["isDefault"] = false;
                Settings.Default["isFrench"] = false;
                }
             else if (frenchRadioButton.Checked == true)
               {
                Settings.Default["isFrench"] = true ;
                Settings.Default["isTurkish"] = false;
                Settings.Default["isDefault"] = false;  
               }
            Properties.Settings.Default.Save();
            //If the application language is changed,restart needed to apply the changes.
            if (englishRadioButton.Checked == true || turkishRadioButton.Checked == true || frenchRadioButton.Checked == true)
            {

            dresult = MessageBox.Show("Change of Application Language requires application restart,Choose yes to restart now", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            if ( dresult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
            
        


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            insNameTextBox.Text=Settings.Default["InstitutionName"].ToString();
            addLine1TextBox.Text= Settings.Default["AddressLine1"].ToString()  ;
            addLine2TextBox.Text=Settings.Default["AddressLine2"].ToString()  ;
            addLine3TextBox.Text=Settings.Default["AddressLine3"].ToString()  ;
            cityTextBox.Text =Settings.Default["CityName"].ToString()  ;
            countryComboBox.SelectedItem= Settings.Default["Country"]  ;
            websiteTextBox.Text =Settings.Default["WebSiteInfo"].ToString()  ;
            telephoneTextBox.Text = Settings.Default["Telephone"].ToString();
            academicYearTextBox.Text = Settings.Default["AcademicYearInfo"].ToString();
      
            if (Settings.Default["isTurkish"].Equals(true))
            {
                turkishRadioButton.Checked = true;
            }
            else if (Settings.Default["isDefault"].Equals(true))
            {
                englishRadioButton.Checked = true;
            }
            else
            {
                frenchRadioButton.Checked = true;
            }
        }      
    }
}
