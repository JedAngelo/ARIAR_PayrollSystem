using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Helpers
{
    public class TabcontrolHelper
    {
        public static void AutoFitTabs(Guna.UI2.WinForms.Guna2TabControl tabControl)
        {
            // Ensure the tab control is not null
            if (tabControl == null)
                throw new ArgumentNullException(nameof(tabControl));

            int tabCount = tabControl.TabCount;
            int totalWidth = tabControl.Width;

            if (tabCount > 0)
            {
                // Calculate the width for each tab button
                int tabWidth = totalWidth / tabCount;
                for (int i = 0; i < tabCount; i++)
                {
                    tabControl.TabButtonSize = new Size(tabWidth, tabControl.TabButtonSize.Height);
                }
            }
        }
    }
}
