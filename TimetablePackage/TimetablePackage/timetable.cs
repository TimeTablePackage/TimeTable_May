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
    public partial class timetable : DockableForm
    {
        DomainControler controler = DomainControler.getInstance();

        public timetable() { }
        public timetable(DataTable timetable)
        {
            InitializeComponent();
            dataGridView1.DataSource = timetable;
        }

        private void timetable_Load(object sender, EventArgs e)
        {
            
        }
    }
}
