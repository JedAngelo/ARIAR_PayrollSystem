using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Helpers
{
    internal static class Switcher
    {

        public static void SwitchPanel(Panel currentPanel, Form formToEmbed)
        {
            // Ensure the panel is not null
            //if (currentPanel == null || formToEmbed == null)
            //{
            //    throw new ArgumentNullException("Panel or Form cannot be null.");

            //}

            currentPanel.Visible = false;
            // Set the form properties to allow embedding
            formToEmbed.TopLevel = false; // Make the form not a top-level window
            formToEmbed.FormBorderStyle = FormBorderStyle.None; // Optional: Remove borders
            formToEmbed.Dock = DockStyle.Fill; // Dock the form to fill the panel

            // Clear the current controls in the panel (if needed)
            currentPanel.Controls.Clear();

            // Add the form to the panel's controls
            currentPanel.Controls.Add(formToEmbed);
            formToEmbed.Show(); // Show the form

        }






        public static void ShowTableLayout(TableLayoutPanel currentTableLayout, TableLayoutPanel switchTableLayout)
        {
            //currentTableLayout.Controls.Clear();
            //currentTableLayout.Controls.Add(switchTableLayout);

            currentTableLayout.Visible = false;
            switchTableLayout.Visible = true;
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
