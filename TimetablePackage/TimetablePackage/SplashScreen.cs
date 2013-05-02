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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            splashScreenProgressBar.Increment(2);
            if (splashScreenProgressBar.Value == 100)
            {
                splashScreenTimer.Stop();
            }
        }

    }
}
