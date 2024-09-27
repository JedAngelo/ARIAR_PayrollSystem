using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Helpers
{
    public static class ControlsHelper
    {
        public static void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control.HasChildren)
                {
                    ClearAllTextBoxes(control); // Recursively call the method for nested controls
                }
            }
        }



    }
}
