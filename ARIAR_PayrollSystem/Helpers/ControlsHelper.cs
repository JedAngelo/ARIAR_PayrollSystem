using ARIAR_PayrollSystem.Forms;
using ARIAR_PayrollSystem.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
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
                  

        public static Point GetFormLocationInScreen(Form form)
        {
            // Get the screen where the form is located
            Screen screen = Screen.FromControl(form);

            // Get the form's location relative to the entire screen
            Point formLocation = form.Location;

            // Get the screen's bounds (size and location of the screen)
            Rectangle screenBounds = screen.Bounds;

            // Calculate the form's position relative to the screen it's on
            int relativeX = formLocation.X - screenBounds.X;
            int relativeY = formLocation.Y - screenBounds.Y;

            // Return the form's location relative to the screen
            return new Point(relativeX, relativeY);
        }

        public static void SetOverlayFormLocation(Form parentForm, Form overlayForm)
        {
            // Get the relative location of the parent form on the current screen
            Point relativeLocation = GetFormLocationInScreen(parentForm);

            // Get the screen bounds of the screen where the parent form is located
            Screen parentScreen = Screen.FromControl(parentForm);
            Rectangle screenBounds = parentScreen.Bounds;

            // Calculate the absolute position on the screen based on the relative position
            int absoluteX = screenBounds.X + relativeLocation.X;
            int absoluteY = screenBounds.Y + relativeLocation.Y;

            // Set the overlay form's location to match the parent's absolute location on the screen
            overlayForm.Location = new Point(absoluteX, absoluteY);

            // Optionally, set the size of the overlay form to match the parent form if needed
            overlayForm.Size = parentForm.Size;
        }

        public static async Task<byte[]> ConvertImageToByteAsync(PictureBox pictureBox)
        {
            if (pictureBox.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Create a clone of the image to avoid issues with the original image being read-only
                using (Image clonedImage = new Bitmap(pictureBox.Image))
                {
                    await Task.Run(() => clonedImage.Save(ms, ImageFormat.Jpeg));
                    return ms.ToArray();
                }
            }
        }

        public static async Task<byte[]> ConvertButtonImageToByteAsync(Guna2Button button)
        {
            if (button.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Create a clone of the image to avoid issues with the original image being read-only
                using (Image clonedImage = new Bitmap(button.Image))
                {
                    await Task.Run(() => clonedImage.Save(ms, ImageFormat.Jpeg));
                    return ms.ToArray();
                }
            }
        }

        public static async Task ConvertByteToImageAsync(byte[] imageBytes, PictureBox pictureBox)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Use Task.Run to run the synchronous operation asynchronously
                await Task.Run(() => pictureBox.Image = Image.FromStream(ms));
            }
        }

        public static async Task ConvertByteToImageCircleBoxAsync(byte[] imageBytes, Guna2CirclePictureBox pictureBox)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Use Task.Run to run the synchronous operation asynchronously
                await Task.Run(() => pictureBox.Image = Image.FromStream(ms));
            }
        }

        public static void ShowModal(MainForm mainForm, Form modalForm)
        {
            // Create and show the overlay form
            OverlayForm overlayForm = new OverlayForm(mainForm);
            overlayForm.Show(mainForm);

            // Display the modal form as a dialog
            using (modalForm)
            {
                modalForm.ShowDialog(mainForm);
            }

            // Close the overlay form after the modal closes
            overlayForm.Close();
        }

        public static void AnchorToAllSides(this Control control)
        {
            // Set the Anchor property to anchor to all sides
            control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        public static TimeOnly ParseTimeOnly(string timeString)
        {
            if (string.IsNullOrWhiteSpace(timeString))
            {
                throw new ArgumentNullException(nameof(timeString), "Time string cannot be null or empty.");
            }

            if (TimeOnly.TryParseExact(timeString, "H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out TimeOnly result))
            {
                return result;
            }
            else if (TimeOnly.TryParseExact(timeString, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out TimeOnly result2))
            {
                return result2;
            }
            else if (TimeOnly.TryParseExact(timeString, "H:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out TimeOnly result3))
            {
                return result3;
            }
            else if (TimeOnly.TryParseExact(timeString, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out TimeOnly result4))
            {
                return result4;
            }
            else
            {
                throw new FormatException($"Invalid time format: {timeString}. Expected format is 'H:mm:ss', 'HH:mm:ss', 'H:mm' or 'HH:mm' (e.g., 8:00:30, 08:00:30, 8:00 or 08:00).");
            }
        }


        public static string FormatTimeOnly(TimeOnly timeOnly)
        {
            return timeOnly.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
        }

        public static int GetNumberOfSundays(DateOnly startDate, DateOnly endDate)
        {
            int sundayCount = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundayCount++;
                }
            }

            return sundayCount;
        }

    }
}
