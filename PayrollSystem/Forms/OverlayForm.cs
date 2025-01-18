using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms
{
    public partial class OverlayForm : Form
    {
        MainForm _mainForm;
        public OverlayForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            if (_mainForm.FormBorderStyle == FormBorderStyle.Sizable)
            {
                Size = new Size(_mainForm.Width - 15, _mainForm.Height - 7);
                Location = new Point(_mainForm.Location.X + 7, _mainForm.Location.Y + 1);
            }
            else
            {
                Size = _mainForm.Size;
                Location = _mainForm.Location;
            }

            WindowState = _mainForm.WindowState;
            //this.Owner = _mainForm;
            //this.TopLevel = false;
            //this.Parent = _mainForm;
            //this.StartPosition = FormStartPosition.CenterParent;
        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
