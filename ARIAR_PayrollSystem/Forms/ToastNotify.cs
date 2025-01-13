using ARIAR_PayrollSystem.Forms.Modals;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class ToastNotify : Form
    {
        private static ToastNotify activeToast; // Track the currently active toast
        private int toastX;
        private int toastY;

        public ToastNotify()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TOOLWINDOW = 0x00000080;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TOOLWINDOW; // Prevent it from appearing in Alt+Tab
                return cp;
            }
        }


        public static void ShowToastr(string message, string type)
        {

            // Close the previous toast if it exists
            if (activeToast != null && !activeToast.IsDisposed)
            {
                activeToast.Close(); // Close the existing toast
            }

            // Create a new toast instance
            activeToast = new ToastNotify();
            activeToast.MessageText.Text = message;
            activeToast.CaptionText.Text = type;

            // Set the indicator light and icon based on the type
            switch (type)
            {
                case "ERROR":
                    activeToast.IndicatorLight.BackColor = Color.Red;
                    activeToast.ToastIcon.Image = Properties.Resources.close_circle_fill;
                    break;
                case "INFO":
                    activeToast.IndicatorLight.BackColor = Color.RoyalBlue;
                    activeToast.ToastIcon.Image = Properties.Resources.information_fill;
                    break;
                case "WARNING":
                    activeToast.IndicatorLight.BackColor = Color.Gold;
                    activeToast.ToastIcon.Image = Properties.Resources.alert_fill;
                    break;
                case "SUCCESS":
                    activeToast.IndicatorLight.BackColor = Color.LimeGreen;
                    activeToast.ToastIcon.Image = Properties.Resources.checkbox_circle_fill__1_;
                    break;
            }

            activeToast.Show();

            
        }

        private static void ShowToastWithType(string message, string type)
        {
            var mainForm = Application.OpenForms["MainForm"];
            
            if (mainForm == null)
            {
                GunaMessage.Error("MainForm does not exist!", "ERROR");
            }

            if (mainForm.InvokeRequired)
            {
                mainForm.Invoke((Action)(() => ShowToastr(message, type)));
            }
            else
            {
                ShowToastr(message, type);
            }
        }

        public static void Error(string message) => ShowToastWithType(message, "ERROR");
        public static void Info(string message) => ShowToastWithType(message, "INFO");
        public static void Warning(string message) => ShowToastWithType(message, "WARNING");
        public static void Success(string message) => ShowToastWithType(message, "SUCCESS");

        private void Position()
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Initial position for the toast
            toastX = workingArea.Right - this.Width - 10; // 10 pixels from the right edge
            toastY = workingArea.Bottom; // Start from the bottom edge of the working area

            // Set the initial off-screen position for animation
            this.Location = new Point(toastX, toastY);
        }



        private void ToastNotify_Load(object sender, EventArgs e)
        {
            //this.Activate();
            Position();
            
        }
        //private int elapsedTime = 0;
        private async void timerShow_Tick(object sender, EventArgs e)
        {
            this.Activate();
            toastY -= 10; // Move the toast upwards
            this.Location = new Point(toastX, toastY);

            // Stop the timer once the toast reaches the target position
            if (toastY <= Screen.PrimaryScreen.WorkingArea.Bottom - this.Height - 10)
            {
                timerShow.Stop();
                await Task.Delay(1500);
                timerHide.Start();
            }
        }


        private int y = 100;
        private void timerHide_Tick(object sender, EventArgs e)
        {
            toastY += 10; // Move the toast downwards
            this.Location = new Point(toastX, toastY);

            // Stop the timer and close the toast once it moves out of the screen
            if (toastY >= Screen.PrimaryScreen.WorkingArea.Bottom)
            {
                timerHide.Stop();
                this.Close();
                activeToast = null; // Clear the reference
            }
        }

    }
}
