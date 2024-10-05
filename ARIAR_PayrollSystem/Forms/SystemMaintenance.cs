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
using System.Xml.Linq;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class SystemMaintenance : Form
    {
       
        MainForm _mainForm;
        //TestModal _testModal;
        public readonly HttpClient client = new HttpClient();
        private Dictionary<Guna2TextBox, Tuple<Label, int>> textBoxLabelMap;




        public SystemMaintenance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            DoBDatePicker.CustomFormat = "MMMM d, yyyy";
            HiredDatePicker.CustomFormat = "MMMM d, yyyy";

            textBoxLabelMap = new Dictionary<Guna2TextBox, Tuple<Label, int>>
            {
                { FirstnameTextBox, new Tuple<Label, int>(FirstnameLabel, FirstnameLabel.Location.Y) },
                { LastnameTextBox, new Tuple<Label, int>(LastNameLabel, LastNameLabel.Location.Y) },
                { MiddlenameTextBox, new Tuple<Label, int>(MiddlenameLabel, MiddlenameLabel.Location.Y) },
                { AgeTextBox, new Tuple<Label, int>(AgeLabel, AgeLabel.Location.Y) },
                { ContactNoTextBox, new Tuple<Label, int>(ContactLabel, ContactLabel.Location.Y) },
                { EmailTextBox, new Tuple<Label, int>(EmailLabel, EmailLabel.Location.Y) },
                { AddressTextBox, new Tuple<Label, int>(AddressLabel, AddressLabel.Location.Y) },
                { SSSTextBox, new Tuple<Label, int>(SSSLabel, SSSLabel.Location.Y) },
                { PhilhealthTextBox, new Tuple<Label, int>(PhilhealthLabel, PhilhealthLabel.Location.Y) },
                { PagIbigTextBox, new Tuple<Label, int>(PagibigLabel, PagibigLabel.Location.Y) },
                { IncomeTextBox, new Tuple<Label, int>(IncomeLabel, IncomeLabel.Location.Y) },
                { PayrateTextBox, new Tuple<Label, int>(PayrateLabel, PayrateLabel.Location.Y) }
            };

            //targetY = originalY - 20;


        }

        

        private async void AddEmployee_Click(object sender, EventArgs e)
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
                var _result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiHelper.ApiAddEmployeeInfo, _employeeInfo);
                if (_result.isSuccess)
                {
                    CustomMessageBox.Show(_result.Data);
                }
                else
                {
                    CustomMessageBox.Show(_result.ErrorMessage);
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

        private void SystemMaintenance_Load(object sender, EventArgs e)
        {
         
        }




        //Textbox and label animation FUCKKKKKKK
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Guna2TextBox guna2TextBox = sender as Guna2TextBox;
            ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, true);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            Guna2TextBox guna2TextBox = sender as Guna2TextBox;
            ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, false);
        }

        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ControlsHelper.ClearAllTextBoxes(this);
            ControlsHelper.LabelTransitionAll(textBoxLabelMap, LabelTransition);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            ControlsHelper.FocusTextBox(clickedLabel, textBoxLabelMap);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OverlayForm overlayForm = new OverlayForm();
            overlayForm.Show();

            using (TestModal _testModal = new TestModal())
            {
                _testModal.ShowDialog();
            }
            overlayForm.Close();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Show(HttpHelper.GetAccessToken());
        }
    }
}
