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
    public partial class EmployeeInformation : Form
    {
        MainForm _mainForm;
        public EmployeeInformation(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void EmployeeInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateNewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
