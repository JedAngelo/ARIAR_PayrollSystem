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

namespace PayrollSystem.Forms.Modals
{
    public partial class UserUpdateModal : Form
    {
        private UsersDto _user;
        public UserUpdateModal(UsersDto user)
        {
            InitializeComponent();
            _user = user;
        }

        private void LoadInfo(UsersDto data)
        {
            UsernameTextBox.Text = data.UserName;
            foreach(var permission in data.Permissions)
            {
                if (permission == "*")
                {
                    AllCheck.Checked = true;
                }
                else
                {
                    switch (permission)
                    {
                        case "EMPLOYEE":
                            EmployeeCheck.Checked = true;
                            break;
                        case "WORKLOG":
                            WorklogCheck.Checked = true;
                            break;
                        case "ATTENDANCE":
                            AttendanceCheck.Checked = true;
                            break;
                        case "PAYROLL":
                            PayrollCheck.Checked = true;
                            break;
                        case "REPORT":
                            ReportCheck.Checked = true;
                            break;
                        case "SYSTEM":
                            SystemCheck.Checked = true;
                            break;
                    }
                }
            }
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var permissions = new List<PermissionDto>();
                var userInfo = new RegisterModelDto
                {
                    UserId = _user.UserId,
                    UserName = UsernameTextBox.Text,
                    CurrentPassword = String.IsNullOrEmpty(PasswordTextBox.Text) ? null : PasswordTextBox.Text,
                    Password = String.IsNullOrEmpty(NewPasswordTextBox.Text) ? null : NewPasswordTextBox.Text,
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

                await UpdateUser(userInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task UpdateUser(RegisterModelDto data)
        {
            try
            {
                var apiData = await HttpHelper.PutAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Auth.UpdateUserInfo, data);

                if (apiData == null) throw new HttpRequestException("Failed registering user");

                if (apiData.isSuccess)
                {
                    GunaMessage.Info("User updated!", "Success");
                    this.Close();
                }
                else
                {
                    Console.WriteLine(apiData.Data);
                    ToastNotify.Warning(apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UserUpdateModal_Load(object sender, EventArgs e)
        {
            LoadInfo(_user);
            TopPanel.Refresh();
        }
    }
}
