using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Helpers
{
    internal static class Switcher
    {
        public static async void SwitchPanel(Panel currentPanel, Panel switchPanel)
        {
            currentPanel.Controls.Clear();
            currentPanel.Controls.Add(switchPanel);
        }
        public static void SwitchGunaTabGroup(Guna2TabControl currentTabGroup, Guna2TabControl switchTabGroup)
        {
            currentTabGroup.TabPages.Clear();

            foreach (TabPage tabPage in switchTabGroup.TabPages)
            {
                currentTabGroup.TabPages.Add(tabPage);
            }
        }
    }
}
