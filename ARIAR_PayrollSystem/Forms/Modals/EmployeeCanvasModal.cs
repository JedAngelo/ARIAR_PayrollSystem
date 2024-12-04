using ARIAR_PayrollSystem.Forms.Modals.ChildrenModal;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
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

namespace ARIAR_PayrollSystem.Forms.Modals
{
    public partial class EmployeeCanvasModal : Form
    {
        private PersonalInformationForm _personalInformation;
        private ContactInformationForm _contactInformation;
        private EmploymentDetails _employmentDetails;
        private PersonalInformationDto _personalInformationDto = new PersonalInformationDto();
        private ContactInformationDto _contactInformationDto = new ContactInformationDto();
        private EmploymentDetailDto _employmentDetailDto = new EmploymentDetailDto();


        public EmployeeCanvasModal()
        {
            InitializeComponent();
            _personalInformation = new PersonalInformationForm(this, _personalInformationDto);
            _contactInformation = new ContactInformationForm(this, _contactInformationDto);
            _employmentDetails = new EmploymentDetails(this, _employmentDetailDto);


            _personalInformationDto.ContactInformationDtos = _contactInformationDto;
            _personalInformationDto.EmploymentDetailDtos = _employmentDetailDto;
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
            firstToSecond.FillColor = Color.LightSeaGreen;
            secondStep.FillColor = Color.LightSeaGreen;
            secondStepLabel.ForeColor = Color.White;
            await Switcher.SwitchPanelAsync(MainViewPanel, _contactInformation);
            nextTransition.Show(MainViewPanel);
        }

        public async void advanceToThird()
        {
            secondToThird.FillColor = Color.LightSeaGreen;
            thirdStep.FillColor = Color.LightSeaGreen;
            thirdStepLabel.ForeColor = Color.White;
            await Switcher.SwitchPanelAsync(MainViewPanel, _employmentDetails);
            nextTransition.Show(MainViewPanel);

        }

        public async void retreatToSecond()
        {
            thirdStep.FillColor = Color.White;
            secondToThird.FillColor = Color.White;
            thirdStepLabel.ForeColor = Color.FromArgb(45, 45, 45);
            secondStepLabel.ForeColor = Color.White;
            await Switcher.SwitchPanelAsync(MainViewPanel, _contactInformation);
            prevTransition.Show(MainViewPanel);
        }

        public async void retreatToFirst()
        {
            secondStep.FillColor = Color.White;
            firstToSecond.FillColor = Color.White;
            secondStepLabel.ForeColor = Color.FromArgb(45, 45, 45);
            firstStepLabel.ForeColor = Color.White;
            await Switcher.SwitchPanelAsync(MainViewPanel, _personalInformation);
            prevTransition.Show(MainViewPanel);
        }

        public async void AddEmployeeAsync()
        {
            try
            {
                _personalInformationDto.CreatedBy = "ADMIN";
                _personalInformationDto.CreatedDate = DateTime.Now;

                var addEmployee = await HttpHelper.PostAsync<ApiResponse<string>, PersonalInformationDto>(ApiEndpointHelper.Employee.AddOrUpdateEmployeeInfo, _personalInformationDto)
                                  ?? throw new Exception("addEmployee is empty");

                if (addEmployee.isSuccess)
                {
                    GunaMessage.Info(addEmployee.Data, "Success");
                }
                else
                {
                    GunaMessage.Warning(addEmployee.ErrorMessage, "Please try again later");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
    }
}
