using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ARIAR_PayrollSystem.Forms.Modals
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }


        public static DialogResult Show(string message)
        {
            // Create an instance of the form and pass the message
            var customMessageBox = new CustomMessageBox();
            customMessageBox.Message.Text = message;

            // Display it as a modal dialog
            return customMessageBox.ShowDialog();
        }
    }

    
}
