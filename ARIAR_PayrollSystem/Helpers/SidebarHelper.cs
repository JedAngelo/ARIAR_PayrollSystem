using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Helpers
{
    internal static class SidebarHelper
    {
        private static bool firstLoad = true;
        private static int originalCol;
        public static void ChangeColWidth(TableLayoutPanel tableLayoutPanel, bool show)
        {
            if (firstLoad)
            {
                originalCol = tableLayoutPanel.GetColumnWidths()[0];
                firstLoad = false;

            }

            if (!show)
            {
                tableLayoutPanel.ColumnStyles[0].Width = 53;
            }
            else
            {
                tableLayoutPanel.ColumnStyles[0].Width = originalCol;
            }
        }
    }
}
