using PayrollSystem.Forms;
using PayrollSystem.Forms.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
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
            //Application.Run(new MainForm());

            RunApplication();
        }
        private static void RunApplication()
        {
            Application.Run(new Login());
        }
    }
}
