using ARIAR_PayrollSystem.Forms;
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

namespace ARIAR_PayrollSystem.UserControls
{
    public partial class EmployeeView : UserControl
    {
        private Guid _personalId;
        private const int anchorX = 100;
        private int actionShowX;
        private int actionHideIncrementX = 200;
        private int actionHideX;
        private bool isHidden = false;

        public EmployeeView(String fullName, string contactNo, string address, byte[] employeePic, Guid personalId)
        {
            InitializeComponent();
            Fullname.Text = fullName;
            ContactNo.Text = contactNo;
            Address.Text = address;
            LoadEmployeePic(employeePic);
            _personalId = personalId;
            actionShowX = showActionButton.Location.X - anchorX;
            actionHideX = actionShowX + actionHideIncrementX;


        }
        private async void LoadEmployeePic(byte[] pic)
        {
            await ControlsHelper.ConvertByteToImageCircleBoxAsync(pic, EmployeePic);
        }

        public static async Task DataViewAsync(List<PersonalInformationDisplayDto> data, FlowLayoutPanel view)
        {
            view.Controls.Clear();

            await Task.Run(() =>
            {
                foreach (PersonalInformationDisplayDto employee in data)
                {
                    var fullname = $"{employee.FirstName} {(string.IsNullOrEmpty(employee.MiddleName) ? "" : $"{employee.MiddleName[0]}. ")}{employee.LastName}";
                    var employeeView = new EmployeeView(fullname, employee.PhoneNumber, employee.Address, employee.EmployeeImage, (Guid)employee.PersonalId)
                    {
                        Width = view.ClientSize.Width - 15
                    };

                    view.Invoke((MethodInvoker)(() => view.Controls.Add(employeeView)));
                }
            });
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            ToastNotify.Info(_personalId.ToString());
        }

        private void showActions_Tick(object sender, EventArgs e)
        {
            var x = ActionsOptions.Location.X;
            if (x == actionShowX)
            {
                Console.WriteLine("else check");
                hideActionButton.Visible = true;
                showActions.Stop();
            }
            
            x = Math.Max(x - 15, actionShowX);
            ActionsOptions.Location = new Point(x, ActionsOptions.Location.Y);
           
        }

        private void showActionButton_Click(object sender, EventArgs e)
        {
            ActionsOptions.Visible = true;
            showActions.Start();
        }

        private void EmployeeView_SizeChanged(object sender, EventArgs e)
        {
            actionShowX = showActionButton.Location.X - anchorX;
            actionHideX = actionShowX + actionHideIncrementX;
        }

        private void hideActions_Tick(object sender, EventArgs e)
        {
            var x = ActionsOptions.Location.X;
            if (x == actionHideX)
            {
                Console.WriteLine("else check");
                ActionsOptions.Visible = false;
                hideActions.Stop();
            }
            
            x = Math.Min(x + 15, actionHideX);
            ActionsOptions.Location = new Point(x, ActionsOptions.Location.Y);
        
        }

        private void hideActionButton_Click(object sender, EventArgs e)
        {
            hideActions.Start();
            hideActionButton.Visible = false;
        }
    }
}
