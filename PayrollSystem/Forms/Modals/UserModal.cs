using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.Forms.Modals
{
    public partial class UserModal : Form
    {
        public UserModal()
        {
            InitializeComponent();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                var permissions = new List<PermissionDto>();
                var userInfo = new RegisterModelDto
                {
                    UserName = UsernameTextBox.Text,
                    Password = PasswordTextBox.Text,
                    PermissionDtos = new List<PermissionDto>()
                };

                if (AllCheck.Checked || 
                   (AttendanceCheck.Checked && EmployeeCheck.Checked && WorklogCheck.Checked && PayrollCheck.Checked && ReportCheck.Checked && SystemCheck.Checked))
                {
                    var permission = new PermissionDto { AccessView = "*" };
                    permissions.Add(permission);
                }
                else
                {
                    if (AttendanceCheck.Checked)
                    {
                        var permission = new PermissionDto { AccessView = "ATTENDANCE" };
                        permissions.Add(permission);
                    }
                    if (EmployeeCheck.Checked)
                    {
                        var permission = new PermissionDto { AccessView = "EMPLOYEE" };
                        permissions.Add(permission);
                    }
                    if (WorklogCheck.Checked)
                    {
                        var permission = new PermissionDto { AccessView = "WORKLOG" };
                        permissions.Add(permission);
                    }
                    if (PayrollCheck.Checked)
                    {
                        var permission = new PermissionDto { AccessView = "PAYROLL" };
                        permissions.Add(permission);
                    }
                    if (ReportCheck.Checked)
                    {
                        var permission = new PermissionDto { AccessView = "REPORT" };
                        permissions.Add(permission);
                    }
                    if (SystemCheck.Checked)
                    {
                        var permission = new PermissionDto { AccessView = "SYSTEM" };
                        permissions.Add(permission);
                    }
                }
                userInfo.PermissionDtos = permissions;

                await RegisterUser(userInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task RegisterUser(RegisterModelDto data)
        {
            try
            {
                var apiData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Auth.RegisterUser, data);

                if (apiData == null) throw new HttpRequestException("Failed registering user");

                if (apiData.isSuccess)
                {
                    GunaMessage.Info("User registered!", "Success");
                    this.Close();
                }
                else
                {
                    ToastNotify.Warning(apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UserModal_Load(object sender, EventArgs e)
        {
            TopPanel.Refresh();
        }
    }
}
