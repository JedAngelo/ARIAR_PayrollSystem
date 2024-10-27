using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Forms.Modals.ModalHelpers;
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
        private Guid selectedId;
        public class Employee
        {
            public Guid PersonalId { get; set; }
            public string Fullname { get; set; }
        }
        private Employee _employee;




        public SystemMaintenance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

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
                    DateOfBirth = DoBDatePicker.Value.Date.ToString("yyyy-MM-dd"),
                    Gender = "Male",
                    Age = byte.Parse(AgeTextBox.Text),
                    EmployeeImage = await ControlsHelper.ConvertImageToByteAsync(EmployeePictureBox),
                    ContactInformationDtos = new ContactInformation
                    {
                        Address = AddressTextBox.Text,
                        Email = EmailTextBox.Text,
                        PhoneNumber = ContactNoTextBox.Text,

                    },
                    EmploymentDetailDtos = new EmploymentDetail
                    {
                        HireDate = HiredDatePicker.Value.Date.ToString("yyyy-MM-dd"),
                        IncomeTaxRate = decimal.Parse(IncomeTextBox.Text),
                        PayRate = decimal.Parse(PayrateTextBox.Text),
                        SssEmployeeRate = decimal.Parse(SSSTextBox.Text),
                        PhilhealthEmployeeRate = decimal.Parse(PhilhealthTextBox.Text),
                        PagibigEmployeeRate = decimal.Parse(PagIbigTextBox.Text),
                        PositionId = 1
                    },
                    CreatedBy = "ASSHOLE",
                    CreatedDate = DateTime.Now

                };
                var _result = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiHelper.Employee.AddOrUpdateEmployeeInfo, _employeeInfo);
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
            OverlayForm overlayForm = new OverlayForm(_mainForm);
            overlayForm.Show(_mainForm);

            //using (TestModal _testModal = new TestModal())
            //{
            //    _testModal.ShowDialog(_mainForm);
            //}

            using (FingerPrintEnrollment _enrollmentModal = new FingerPrintEnrollment(_mainForm, _employee)) 
            {
                _enrollmentModal.ShowDialog(_mainForm);
            }

            overlayForm.Close();



        }

        private async void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            OpenFile.Title = "Select Employee Picture";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = OpenFile.FileName;

                // Load image asynchronously
                Image image = await Task.Run(() => Image.FromFile(filePath));

                EmployeePictureBox.Image = image;
            }
        }


        private void DoBDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = DoBDatePicker.Value;

            // Calculate the age based on the selected date and today's date
            int calculatedAge = DateTime.Now.Year - selectedDate.Year;

            // Adjust if the birthday hasn't occurred yet this year
            if (DateTime.Now < selectedDate.AddYears(calculatedAge))
            {
                calculatedAge--;
            }
            //AgeTextBox.Focus();
            TextBox_Enter(AgeTextBox, EventArgs.Empty);
            AgeTextBox.Text = calculatedAge.ToString();


        }

        private async void GetEmployeeInfo()
        {
            try
            {
                var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<List<PersonalInformation>>>(ApiHelper.Employee.GetPersonalInfo);
                
                if (_employeeInfo == null)
                {
                    //GunaMessage.ErrorMessage(_mainForm, "Cannot retrieve employee information!", "ERROR");
                    ToastNotify.Error("No employee record found!");
                    return;
                }
                var employeeData = _employeeInfo.Data.Select(e => new Employee
                {
                    Fullname = $"{e.FirstName} {(string.IsNullOrEmpty(e.MiddleName) ? "" : $"{e.MiddleName[0]}. ")}{e.LastName}",
                    PersonalId = (Guid)e.PersonalId
                }).ToList();

                EmployeeDataGrid.DataSource = employeeData;
            }
            catch (Exception ex)
            {
                GunaMessage.Error(_mainForm, $"Error: {ex.Message}", "ERROR");
            }
        }

        private void Biometrics_Click(object sender, EventArgs e)
        {
            GetEmployeeInfo();
        }

        private void SystemMaintenanceTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SystemMaintenanceTabs.SelectedTab.Text == "Biometrics")
            {
                GetEmployeeInfo();
            }
        }

        private void EmployeeDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fullName = EmployeeDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (Guid.TryParse(EmployeeDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out Guid result))
                {
                    _employee = new Employee
                    {
                        PersonalId = result,
                        Fullname = fullName
                    };

                    guna2Button6.Enabled = true;
                }
                else
                {
                    ToastNotify.Error("Invalid Personal ID");
                }

            }
        }
    }
}
