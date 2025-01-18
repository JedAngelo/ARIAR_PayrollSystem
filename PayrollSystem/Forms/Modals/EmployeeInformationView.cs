using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class EmployeeInformationView : Form
    {
        private PersonalInformationDisplayDto _employeeInfo;

        public EmployeeInformationView(PersonalInformationDisplayDto employeeInfo)
        {
            InitializeComponent();
            _employeeInfo = employeeInfo;

            //Personal Info
            FirstnameBox.Text = _employeeInfo.FirstName;
            MiddlenameBox.Text = _employeeInfo.MiddleName;
            LastnameBox.Text = _employeeInfo.LastName;
            SuffixBox.Text = _employeeInfo.Suffix == null ? "N/A" : _employeeInfo.Suffix;
            SexBox.Text = _employeeInfo?.Gender;
            DOBBox.Text = _employeeInfo?.DateOfBirth != null ? DateOnly.ParseExact(_employeeInfo.DateOfBirth, "yyyy-MM-dd", null).ToString("MMMM d, yyyy") : string.Empty;
            MaritalBox.Text = _employeeInfo?.MaritalStatus;
            AgeBox.Text = _employeeInfo.Age.ToString();
            if (_employeeInfo.EmployeeImage != null) LoadImage();


            //Contact Info
            PhoneBox.Text = _employeeInfo?.PhoneNumber;
            EmailBox.Text = _employeeInfo?.Email;
            AddressBox.Text = _employeeInfo?.Address;

            //Employment Details
            PositionBox.Text = _employeeInfo?.PositionName;
            HireDateBox.Text = DateOnly.ParseExact(_employeeInfo?.HireDate, "yyyy-MM-dd").ToString("MMMM d, yyyy");
            ActiveLabel.Text = _employeeInfo.IsActive ? "ACTIVE" : "INACTIVE";
            RegularLabel.Text = _employeeInfo.IsRegular ? "YES" : "NO";
            ActiveChip.FillColor = _employeeInfo.IsActive ? Color.DodgerBlue : Color.SlateGray;
            RegularChip.FillColor = _employeeInfo.IsRegular ? Color.DodgerBlue : Color.SlateGray;
            BasicSalary.Text = _employeeInfo.BasicSalary.ToString("#,#0.00");
            //. > Deductions

        }

        public async void LoadImage()
        {
            await ControlsHelper.ConvertByteToImageAsync(_employeeInfo.EmployeeImage, EmployeePictureBox);
        }
    }
}
