using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class ToastNotify : Form
    {

        private int toastX;
        private int toastY;


        public ToastNotify()
        {
            InitializeComponent();
        }



        private void Position()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeigth = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = screenWidth - this.Width - 10;
            toastY = screenHeigth - this.Height + 10;

            this.Location = new Point(toastX, toastY);

        }
    }
}
