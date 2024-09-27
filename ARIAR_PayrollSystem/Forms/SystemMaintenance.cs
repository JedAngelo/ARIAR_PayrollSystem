using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
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
using System.Xml.Linq;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class SystemMaintenance : Form
    {
        MainForm _mainForm;
        public string _apiInsert = "/api/Employee/AddOrUpdateEmployeeInfo";
        public readonly HttpClient client = new HttpClient();

        public SystemMaintenance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            DoBDatePicker.CustomFormat = "MMMM d, yyyy";
            HiredDatePicker.CustomFormat = "MMMM d, yyyy";

        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                var _employeeInfo = new PersonalInformation()
                {
                    PersonalId = null,
                    FirstName = FirstnameTextBox.Text,
                    MiddleName = MiddlenameTextBox.Text,
                    LastName = LastnameTextBox.Text,
                    DateOfBirth = DoBDatePicker.Value.Date,
                    Gender = "Male",
                    Age = byte.Parse(AgeTextBox.Text),
                    ContactInformationDtos = new List<ContactInformation>
                    {
                        new ContactInformation
                        {
                        Address = AddressTextBox.Text,
                        Email = EmailTextBox.Text,
                        PhoneNumber = ContactNoTextBox.Text,
                        }
                    },
                    EmploymentDetailDtos = new List<EmploymentDetail>
                    {
                        new EmploymentDetail
                        {
                            HireDate = HiredDatePicker.Value.Date,
                            IncomeTaxRate = decimal.Parse(IncomeTextBox.Text),
                            PayRate = decimal.Parse(PayrateTextBox.Text),
                            SssEmployeeRate = decimal.Parse(SSSTextBox.Text),
                            PhilhealthEmployeeRate = decimal.Parse(PhilhealthTextBox.Text),
                            PagibigEmployeeRate = decimal.Parse(PagIbigTextBox.Text),
                            PositionId = 1
                        }
                    },
                    CreatedBy = "ASSHOLE",
                    CreatedDate = DateTime.Now
                    
                };
                var _result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(_apiInsert, _employeeInfo);
                if (_result.isSuccess)
                {
                    MessageBox.Show(_result.Data);
                }
                else
                {
                    MessageBox.Show(_result.ErrorMessage);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
                
            }
            finally
            {
                ControlsHelper.ClearAllTextBoxes(this);
            }
        }
    }
}
