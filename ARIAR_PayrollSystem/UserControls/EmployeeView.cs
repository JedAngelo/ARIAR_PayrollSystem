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

        public EmployeeView(String fullName, string contactNo, string address, byte[] employeePic, Guid personalId)
        {
            InitializeComponent();
            Fullname.Text = fullName;
            ContactNo.Text = contactNo;
            Address.Text = address;
            LoadEmployeePic(employeePic);
            _personalId = personalId;
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
                        Width = view.Width - 25
                    };

                    view.Invoke((MethodInvoker)(() => view.Controls.Add(employeeView)));
                }
            });
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            ToastNotify.Info(_personalId.ToString());
        }
    }
}
