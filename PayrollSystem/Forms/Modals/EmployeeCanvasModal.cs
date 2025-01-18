using PayrollSystem.Forms.Modals.ChildrenModal;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class EmployeeCanvasModal : Form
    {
        private PersonalInformationForm _personalInformation;
        private ContactInformationForm _contactInformation;
        private EmploymentDetailsForm _employmentDetails;
        private PersonalInformationDto _employeeInfo;
        private ContactInformationDto _contactInfo;
        private EmploymentDetailDto _employmentDetail;
        private MainForm _mainForm;

        public EmployeeCanvasModal(PersonalInformationDto employeeInfo, MainForm mainForm)
        {
            _employeeInfo = employeeInfo;
            _mainForm = mainForm;
            //if (!String.IsNullOrEmpty(_employeeInfo.PersonalId.ToString()))
            //{
            //    _contactInfo = employeeInfo.ContactInformationDtos;
            //    _employmentDetail = employeeInfo.EmploymentDetailDtos;
            //}
            //else
            //{
            //    _contactInfo = new ContactInformationDto();
            //    _employmentDetail = new EmploymentDetailDto();
            //}
            //_employeeInfo.ContactInformationDtos = _contactInfo;
            //_employeeInfo.EmploymentDetailDtos = _employmentDetail;
            



            InitializeComponent();
            _personalInformation = new PersonalInformationForm(this, _employeeInfo);
            _contactInformation = new ContactInformationForm(this, _employeeInfo.ContactInformationDtos);
            _employmentDetails = new EmploymentDetailsForm(this, _employeeInfo.EmploymentDetailDtos);

        }




        private async void CanvasModal_Load(object sender, EventArgs e)
        {
            await Switcher.SwitchPanelAsync(MainViewPanel, _personalInformation);
            MainViewPanel.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public async void advanceToSecond()
        {
            progressLine.Value++;
            await Switcher.SwitchPanelAsync(MainViewPanel, _contactInformation);
            nextTransition.Show(MainViewPanel);
        }

        public async void advanceToThird()
        {
            progressLine.Value++;
            await Switcher.SwitchPanelAsync(MainViewPanel, _employmentDetails);
            nextTransition.Show(MainViewPanel);

        }

        public async void retreatToSecond()
        {
            progressLine.Value--;
            await Switcher.SwitchPanelAsync(MainViewPanel, _contactInformation);
            prevTransition.Show(MainViewPanel);
        }

        public async void retreatToFirst()
        {
            progressLine.Value--;
            await Switcher.SwitchPanelAsync(MainViewPanel, _personalInformation);
            prevTransition.Show(MainViewPanel);
        }

        public async void AddEmployeeAsync()
        {
            try
            {
                if (_employeeInfo?.PersonalId == null)
                {
                    _employeeInfo.CreatedBy = _mainForm.UserData.UserName;
                    _employeeInfo.CreatedDate = DateTime.Now;
                }
                
                var addOrUpdateEmployee = await HttpHelper.PostAsync<ApiResponse<string>, PersonalInformationDto>(ApiEndpoint.Employee.AddOrUpdateEmployeeInfo, _employeeInfo)
                                      ?? throw new Exception("Employee data is empty");

                if (addOrUpdateEmployee.isSuccess)
                {
                    Console.WriteLine(addOrUpdateEmployee.Data);
                    GunaMessage.Info(_employeeInfo?.PersonalId != null ? "Updated employee information!" : "Added employee information!", "Success");
                    this.Close();
                }
                else
                {
                    GunaMessage.Warning(addOrUpdateEmployee.ErrorMessage, "Please try again later");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void progressLine_ValueChanged(object sender, EventArgs e)
        {
            switch (progressLine.Value)
            {
                case 0:
                    firstStep.FillColor = Color.FromArgb(255, 188, 1);
                    secondStep.FillColor = Color.White;
                    thirdStep.FillColor = Color.White;
                    return;

                case 1:
                    secondStep.FillColor = Color.FromArgb(255, 188, 1);
                    thirdStep.FillColor = Color.White;
                    return;

                case 2:
                    thirdStep.FillColor = Color.FromArgb(255, 188, 1);
                    return;
            }

        }
    }
}
