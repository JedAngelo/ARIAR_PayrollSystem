using PayrollSystem.Forms;
using PayrollSystem.Forms.Modals;
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
using System.Web;
using System.Windows.Forms;

namespace PayrollSystem.UserControls
{
    public partial class UserView : UserControl
    {
        private SystemMaintenance _parent;
        private UsersDto _user;
        private MainForm _mainForm;
        public UserView(MainForm mainForm, SystemMaintenance parent, UsersDto user)
        {
            InitializeComponent();
            _parent = parent;
            _user = user;
            _mainForm = mainForm;
            LoadData(_user);
        }

        private void LoadData(UsersDto data)
        {
            UserId.Text = data.UserId;
            Username.Text = data.UserName;
            Permissions.Text = string.Join(", ", data.Permissions);
        }

        public static async Task DataViewAsync(MainForm mainForm, List<UsersDto> users, SystemMaintenance parent, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var userViewList = new List<UserView>();

                await Task.Run(() =>
                {
                    foreach(var user in users)
                    {
                        var userView = new UserView(mainForm, parent, user)
                        {
                            Width = view.ClientSize.Width - 13
                        };
                        userViewList.Add(userView);
                    }
                    view.BeginInvoke((Action)(() =>
                    {
                        view.Controls.AddRange(userViewList.ToArray());
                    }));
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var updateModal = new UserUpdateModal(_user);
            using (updateModal)
            {
                ControlsHelper.ShowModal(_mainForm, updateModal);
            }
            _parent.RefreshUsers();
        }

        private async void DeleteButton_Click_1(object sender, EventArgs e)
        {
            var result = GunaMessage.Question(_mainForm, "Are you sure you want to delete this user?", "Confirm");
            if (result != DialogResult.Yes) return;
            await DeleteUser(_user.UserId);
        }
        private async Task DeleteUser(string id)
        {
            try
            {
                var apiData = await HttpHelper.DeleteAsync<ApiResponse<string>>($"{ApiEndpoint.Auth.DeleteUser}/{id}");

                if (apiData == null) throw new HttpRequestException("Failed deleting user, api returned null");

                if (apiData.isSuccess)
                {
                    ToastNotify.Success(apiData.Data);
                    _parent.RefreshUsers();
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

    }
}
