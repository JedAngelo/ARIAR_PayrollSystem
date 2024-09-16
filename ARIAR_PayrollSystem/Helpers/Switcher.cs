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
        public static void SwitchPanel(Panel currentPanel, Panel switchPanel)
        {
            currentPanel.Controls.Clear();
            currentPanel.Controls.Add(switchPanel);
        }
    }
}
