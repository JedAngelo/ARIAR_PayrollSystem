using ARIAR_PayrollSystem.Forms.Modals;
using System;
using System.Drawing;
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
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = screenWidth - this.Width - 10;
            toastY = screenHeight - this.Height + 120;

            this.Location = new Point(toastX, toastY);
        }

        private void ToastNotify_Load(object sender, EventArgs e)
        {
            //this.Activate();
            Position();
            
        }
        //private int elapsedTime = 0;
        private void timerShow_Tick(object sender, EventArgs e)
        {
            this.Activate();
            //this.Focus();
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 670)
            {
                timerShow.Stop();
                timerHide.Start();
            }
            //elapsedTime += 10;
            //if (this.Opacity != 1)
            //{
            //    this.Opacity += 0.03;
            //}

            //if (elapsedTime == 2000)
            //{
            //    timerShow.Stop();
            //    timerHide.Start();
            //}

        }

        private int y = 100;
        private void timerHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y < 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 800)
                {
                    timerHide.Stop();
                    y = 100;
                    this.Close();
                    activeToast = null; // Clear the reference to the closed toast
                }
            }
            //elapsedTime -= 10;
            //if (this.Opacity != 0)
            //{
            //    this.Opacity -= 0.03;
            //}
            //if (elapsedTime == 0)
            //{
            //    this.Close();
            //}

        }
    }
}
