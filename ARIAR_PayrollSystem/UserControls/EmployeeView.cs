using ARIAR_PayrollSystem.Forms;
using ARIAR_PayrollSystem.Helpers;
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
        public EmployeeView(String fullName, string contactNo, string address, byte[] employeePic)
        {
            InitializeComponent();
            Fullname.Text = fullName;
            ContactNo.Text = contactNo;
            Address.Text = address;
            LoadEmployeePic(employeePic);
        }
        private async void LoadEmployeePic(byte[] pic)
        {
            await ControlsHelper.ConvertByteToImageCircleBoxAsync(pic, EmployeePic);
        }
    }
}
