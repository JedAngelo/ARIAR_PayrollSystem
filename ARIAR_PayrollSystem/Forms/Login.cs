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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DPFP.Verification.Verification;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class Login : Form
    {
        public readonly HttpClient client = new HttpClient();
        //private Dictionary<Guna2TextBox, Tuple<Label, int>> textBoxLabelMap;
        MainForm mainForm;

        public Login()
        {
            InitializeComponent();
            mainForm = new MainForm();
            //textBoxLabelMap = new Dictionary<Guna2TextBox, Tuple<Label, int>>
            //{
            //    { UsernameTextBox, new Tuple<Label, int>(UsernameLabel, UsernameLabel.Location.Y) },
            //    { PasswordTextBox, new Tuple<Label, int>(PasswordLabel, PasswordLabel.Location.Y) },
            //};

        }

        //private void TextBox_Enter(object sender, EventArgs e)
        //{
        //    Guna2TextBox guna2TextBox = sender as Guna2TextBox;
        //    ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, true);
        //}

        //private void TextBox_Leave(object sender, EventArgs e)
        //{
        //    Guna2TextBox guna2TextBox = sender as Guna2TextBox;
        //    ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, false);
        //}

        //private void Label_Click(object sender, EventArgs e)
        //{
        //    Label clickedLabel = sender as Label;
        //    ControlsHelper.FocusTextBox(clickedLabel, textBoxLabelMap);
        //}

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _loginInfo = new LoginModel()
                {
                    UserName = UsernameTextBox.Text,
                    Password = PasswordTextBox.Text
                };

                var _loginResult = await HttpHelper.PostAsync<ApiResponse<LoginModel>, dynamic>(ApiHelper.ApiLogin, _loginInfo);
                if (_loginResult.isSuccess)
                {                   
                    HttpHelper.SetAccessToken(_loginResult.Data.Token);
                    CustomMessageBox.Show("Successfully login!");
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    CustomMessageBox.Show(_loginResult.ErrorMessage);
                }


            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
