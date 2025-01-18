using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals.ModalHelpers
{
    public class ModalHelper
    {
        private Panel CreateOverlay(Form parentForm)
        {
            // Create a new panel to act as the darkened background
            Panel overlayPanel = new Panel
            {
                Size = parentForm.ClientSize,
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(128, 0, 0, 0), // Semi-transparent black
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Visible = true
            };

            // Add the panel to the parent form's controls
            parentForm.Controls.Add(overlayPanel);
            overlayPanel.BringToFront();

            return overlayPanel;
        }

        // Method to display the modal form with the overlay effect
        public void ShowModalWithOverlay(Form parentForm, Form modalForm)
        {
            // Create and show the overlay panel
            Panel overlay = CreateOverlay(parentForm);

            // Show the modal form
            modalForm.ShowDialog();

            // After closing the modal, remove the overlay panel
            parentForm.Controls.Remove(overlay);
        }
    }
}
