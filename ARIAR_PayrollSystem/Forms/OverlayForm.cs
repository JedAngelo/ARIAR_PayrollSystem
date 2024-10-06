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
    public partial class OverlayForm : Form
    {
        MainForm _mainForm;
        public OverlayForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            //this.Owner = _mainForm;
            //this.TopLevel = false;
            //this.Parent = _mainForm;
            //this.StartPosition = FormStartPosition.CenterParent;
        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {
            this.WindowState = _mainForm.WindowState;
            this.Location = _mainForm.Location;
            this.Size = _mainForm.Size;
        }
    }
}
