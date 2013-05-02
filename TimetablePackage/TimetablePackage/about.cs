using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimetablePackage
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void licenceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe","licence.txt");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
