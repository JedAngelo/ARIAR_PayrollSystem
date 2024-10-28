using ARIAR_PayrollSystem.Forms.ChildrenForm;
using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using ARIAR_PayrollSystem.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private ApiResponse<List<PersonalInformation>> _employeeData;
        private List<object> _personalData;
        private EmployeeView _employeeView;

        public EmployeeInformation(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _employeeDetails = new EmployeeDetails();
            Switcher.SwitchGunaTabGroup(guna2TabControl1, _employeeDetails.guna2TabControl2);
            DisplayPersonalInfo();
            PopulateEmployeeTable();
            TimeLabel.Text = DateTime.Now.ToString("hh:mm tt");
            DateLabel.Text = DateTime.Now.Date.ToString("MMMM d, yyyy");
            TimerProcess.Start();

        }


        private async void DisplayPersonalInfo()
        {
            try
            {
                _employeeData = await HttpHelper.GetAsync<ApiResponse<List<PersonalInformation>>>(ApiHelper.Employee.GetPersonalInfo);

                if (_employeeData == null)
                {
                    //GunaMessage.ErrorMessage(_mainForm, "Cannot retrieve employee information!", "ERROR");
                    ToastNotify.Error("No employee record found!");
                    return;
                }
                _personalData = _employeeData.Data.Select(e => new
                {
                    Fullname = $"{e.FirstName} {(string.IsNullOrEmpty(e.MiddleName) ? "" : $"{e.MiddleName[0]}. ")}{e.LastName}",
                    PersonalId = (Guid)e.PersonalId
                }).ToList<object>();

                //EmployeeDataGrid.DataSource = _personalData;
                //EmployeeDataGrid.ClearSelection();

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
                
            }
        }

        private async void PopulateEmployeeTable()
        {
            try
            {
                _employeeData = await HttpHelper.GetAsync<ApiResponse<List<PersonalInformation>>>(ApiHelper.Employee.GetPersonalInfo);
                foreach (var item in _employeeData.Data)
                {
                    var fullname = $"{item.FirstName} {(string.IsNullOrEmpty(item.MiddleName) ? "" : $"{item.MiddleName[0]}. ")}{item.LastName}";
                    _employeeView = new EmployeeView(fullname, item.Gender, item.DateOfBirth, item.EmployeeImage);
                    _employeeView.Width = EmployeeTableView.Width - 30;
                    EmployeeTableView.Controls.Add(_employeeView);
                }
            }
            catch (Exception ex)
            {
                GunaMessage.Error(_mainForm, ex.Message, "ERRRO");
            }
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
        //private void FilterPersonnel(string searchItem)
        //{
        //    if (_personalData == null)
        //    {
        //        ToastNotify.Error("No item found with that keyword");
        //        return;
        //    }


        //    var filteredLogs = _personalData
        //                        .Where(x => x.GetType().GetProperty("Fullname")?.GetValue(x)?.ToString()
        //                        .ToLower().Contains(searchItem.ToLower()) ?? false)
        //                        .ToList();
        //    if (filteredLogs != null)
        //    {
        //        EmployeeDataGrid.DataSource = filteredLogs;          
        //    }
        //    else
        //    {
        //        _personalData = _employeeData.Data.Select(e => new
        //        {
        //            Fullname = $"{e.FirstName} {(string.IsNullOrEmpty(e.MiddleName) ? "" : $"{e.MiddleName[0]}. ")}{e.LastName}",
        //            PersonalId = (Guid)e.PersonalId
        //        }).ToList<object>();

        //        EmployeeDataGrid.DataSource = _personalData;

        //    }

        //    EmployeeDataGrid.ClearSelection();

        //}

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //FilterPersonnel(guna2TextBox1.Text);
            
        }

        private void EmployeeDataGrid_Leave(object sender, EventArgs e)
        {
            //EmployeeDataGrid.ClearSelection();
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
