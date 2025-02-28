using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms
{
    public partial class Login : Form
    {
        public readonly HttpClient client = new HttpClient();
        private MainForm _mainForm;
        private bool _attendanceOnly;

        public Login()
        {
            InitializeComponent();
            LoginPanel.Visible = false;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UsernameTextBox.Text))
            {
                ShowLoginMessage(MessageDialogIcon.Warning, "ERROR", "Username is empty, fill it and try again");
                return;
            }
            else if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                ShowLoginMessage(MessageDialogIcon.Warning, "ERROR", "Password is empty, fill it and try again");
                return;
            }
            ProgressCircle.Visible = true;
            await Task.Delay(250);
            var user = new LoginModelDto()
            {
                UserName = UsernameTextBox.Text,
                Password = PasswordTextBox.Text
            };
            await PerformLoginAsync(user);
            ProgressCircle.Visible = false;
        }

        private async Task PerformLoginAsync(LoginModelDto user)
        {
            try
            {
                if (_mainForm != null && !_mainForm.IsDisposed)
                {
                    _mainForm.Dispose();
                    _mainForm = null;
                }

                var _loginInfo = user;

                var _loginResult = await HttpHelper.PostAsync<ApiResponse<UserLoginDto>, dynamic>(ApiEndpoint.Auth.Login, _loginInfo);

                if (_loginResult == null) throw new HttpRequestException("Failed logging in, try again later");

                if (_loginResult.isSuccess)
                {
                    HttpHelper.SetAccessToken(_loginResult.Data.Token);

                    if (_attendanceOnly)
                    {
                        _mainForm = new MainForm(true);
                        _mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        await Task.Run(() => {
                            BeginInvoke((Action)(() => 
                            {
                                _mainForm = new MainForm(false);
                                _mainForm.UserData = _loginResult.Data;
                            }));                        
                        });
                        this.Invoke(new Action(() =>
                        {
                            _mainForm.Show();
                            this.Hide();
                        }));
                    }

                }
                else
                {

                    ShowLoginMessage(MessageDialogIcon.Warning, "ERROR", _loginResult.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                ShowLoginMessage(MessageDialogIcon.Warning, "ERROR", ex.Message);
            }
        }


        private void ShowLoginMessage(MessageDialogIcon icon, string caption, string text)
        {
            LoginMessage.Icon = icon;
            LoginMessage.Caption = caption;
            LoginMessage.Text = text;
            LoginMessage.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //await Task.Delay(300);
            Transition.Show(LoginPanel);
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                LoginButton.PerformClick();
            }

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                var switcher = new ApiSwitcher();
                switcher.ShowDialog();
            }
        }

        private async void AttendanceButton_Click(object sender, EventArgs e)
        {
            _attendanceOnly = true;
            var user = new LoginModelDto()
            {
                UserName = "attendance",
                Password = "attendance"
            };
            await PerformLoginAsync(user);
        }
    }
}