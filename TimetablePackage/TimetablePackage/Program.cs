using DigitalRune.Windows.Docking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TimetablePackage
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             // Set a consistent render mode for toolstrips and DockPanel.

             ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
             ToolStripManager.VisualStylesEnabled = false;
             DockPanelManager.RenderMode = DockPanelRenderMode.Office2007Blue;


            Application.Run(new Main());
        }
    }
}
