using ARIAR_PayrollSystem.Forms;
using ARIAR_PayrollSystem.Forms.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FingerPrintEnrollment());
            Application.Run(new MainForm());

            //Application.Run(new Login());
        }
    }
}
