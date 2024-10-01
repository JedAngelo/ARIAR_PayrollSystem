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

        public static void SendtoFront(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label)
                {

                    //((Label)control).SendToBack();
                    ((Label)control).BringToFront();
                }
                else if (control.HasChildren)
                {
                    SendtoFront(control); // Recursively call the method for nested controls
                }
            }
        }



        public static void LabelTransitionAll(
        Dictionary<Guna2TextBox, Tuple<Label, int>> textBoxLabelMap,
        Guna2Transition labelTransition)
        {
            foreach (var textBox in textBoxLabelMap.Keys)
            {
                // Check if the textbox is empty
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    var labelTuple = textBoxLabelMap[textBox];  // Retrieve the associated label and original Y-coordinate
                    Label label = labelTuple.Item1;
                    int originalY = labelTuple.Item2;

                    // Hide the label using the transition
                    labelTransition.HideSync(label);

                    // Move the label back to its original Y position
                    label.Location = new Point(label.Location.X, originalY);

                    // Show the label using the transition
                    labelTransition.ShowSync(label);
                }
            }
        }

        public static void LabelTransition(
        Guna2TextBox textBox,
        Dictionary<Guna2TextBox, Tuple<Label, int>> textBoxLabelMap,
        Guna2Transition labelTransition,
        bool moveUp)
        {
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text) && textBoxLabelMap.ContainsKey(textBox))
            {
                var labelTuple = textBoxLabelMap[textBox];  // Retrieve the label and original Y-coordinate
                Label label = labelTuple.Item1;
                int targetY = moveUp ? labelTuple.Item2 - 20 : labelTuple.Item2;  // Move up or reset position

                // Apply transition
                labelTransition.HideSync(label);
                label.Location = new Point(label.Location.X, targetY);
                labelTransition.ShowSync(label);
            }
        }

        public static void FocusTextBox(Label clickedLabel,
        Dictionary<Guna2TextBox, Tuple<Label, int>> textBoxLabelMap)
        {
            // Iterate through the dictionary to find the corresponding TextBox
            foreach (var entry in textBoxLabelMap)
            {
                var textBox = entry.Key;
                var labelTuple = entry.Value;
                var label = labelTuple.Item1;

                // Check if the clicked label matches the current label in the dictionary
                if (label == clickedLabel)
                {
                    // Focus on the corresponding TextBox
                    textBox.Focus();
                    break; // Exit the loop once found
                }
            }
        }
    }
}
