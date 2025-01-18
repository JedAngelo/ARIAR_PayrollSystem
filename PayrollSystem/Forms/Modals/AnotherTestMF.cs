using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class AnotherTestMF : Form
    {
        public AnotherTestMF()
        {
            InitializeComponent();
            ShowChildForm();
        }
        private void ShowChildForm()
        {
            // Create the child form
            TestModal childForm = new TestModal();
            childForm.FormBorderStyle = FormBorderStyle.None; // Optional: Remove borders
            childForm.TopLevel = false; // Make it act as a control
            childForm.Size = new Size(300, 200); // Set size for the child form

            // Add the child form to the parent form's controls
            this.Controls.Add(childForm);

            // Center the child form inside the parent form
            childForm.Left = (this.ClientSize.Width - childForm.Width) / 2;
            childForm.Top = (this.ClientSize.Height - childForm.Height) / 2;

            // Show the child form (as it's not TopLevel, it's treated like a control)
            childForm.Show();
        }

    }
}
