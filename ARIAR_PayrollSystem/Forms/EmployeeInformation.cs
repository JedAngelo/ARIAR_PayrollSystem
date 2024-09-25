using ARIAR_PayrollSystem.Forms.ChildrenForm;
using ARIAR_PayrollSystem.Helpers;
using Guna.UI2.WinForms;
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
        EmployeeDetails _employeeDetails;
        public EmployeeInformation(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _employeeDetails = new EmployeeDetails();
            Switcher.SwitchGunaTabGroup(guna2TabControl1, _employeeDetails.guna2TabControl2);
            

        }

        private void EmployeeInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateNewBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
