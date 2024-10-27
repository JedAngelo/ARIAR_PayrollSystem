using ARIAR_PayrollSystem.Forms.ChildrenForm;
using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
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
        CustomMessageBox _MessageBox;

        public EmployeeInformation(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _employeeDetails = new EmployeeDetails();
            Switcher.SwitchGunaTabGroup(guna2TabControl1, _employeeDetails.guna2TabControl2);
            DisplayPersonalInfo();
            TimeLabel.Text = DateTime.Now.ToString("hh:mm tt");
            DateLabel.Text = DateTime.Now.Date.ToString("MMMM d, yyyy");
            TimerProcess.Start();

        }


        private async void DisplayPersonalInfo()
        {
            try
            {
                var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<List<PersonalInformation>>>(ApiHelper.Employee.GetPersonalInfo);

                if (_employeeInfo == null)
                {
                    //GunaMessage.ErrorMessage(_mainForm, "Cannot retrieve employee information!", "ERROR");
                    ToastNotify.Error("No employee record found!");
                    return;
                }


                var personaInfo = _employeeInfo.Data.Select(e => new
                {
                    Fullname = $"{e.FirstName} {(string.IsNullOrEmpty(e.MiddleName) ? "" : $"{e.MiddleName[0]}. ")}{e.LastName}"
                }).ToList();

                EmployeeDataGrid.DataSource = personaInfo;
                //EmployeeDataGrid.ClearSelection();

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
                
            }
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

        private void TimerProcess_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm tt");
        }
    }
}
