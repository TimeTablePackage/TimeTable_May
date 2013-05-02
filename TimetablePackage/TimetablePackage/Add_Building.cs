using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TimetablePackage
{
    public partial class Add_Building : Form
    {
        public Add_Building(String InitialTextBoxValue)
        {
            InitializeComponent();
            this.TextBox1.Text = InitialTextBoxValue;
        }

        public String TextBoxValue // retrieving a value from
        {
            get
                {
                    return this.TextBox1.Text;
                }
         }

    }
}
