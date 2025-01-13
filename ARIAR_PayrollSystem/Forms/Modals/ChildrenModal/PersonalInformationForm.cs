using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms.Modals.ChildrenModal
{
    public partial class PersonalInformationForm : Form
    {
        private readonly EmployeeCanvasModal _canvasModal;
        private PersonalInformationDto _personalInformationDto;

        public PersonalInformationForm(EmployeeCanvasModal canvasModal, PersonalInformationDto personalInformationDto)
        {
            InitializeComponent();
            _canvasModal = canvasModal;
            _personalInformationDto = personalInformationDto;

            if (_personalInformationDto?.PersonalId != null)
            {
                FirstnameTextBox.Text = _personalInformationDto.FirstName;
                MiddlenameTextBox.Text = _personalInformationDto.MiddleName;
                LastnameTextBox.Text = _personalInformationDto.LastName;
                SuffixTextBox.Text = _personalInformationDto.Suffix;
                MaritalStatComboBox.Text = _personalInformationDto.MaritalStatus;
                MaleOption.Checked = _personalInformationDto.Gender.Equals("male", StringComparison.OrdinalIgnoreCase);
                FemaleOption.Checked = _personalInformationDto.Gender.Equals("female", StringComparison.OrdinalIgnoreCase);
                if (_personalInformationDto.EmployeeImage != null) LoadImage(_personalInformationDto.EmployeeImage);
                DoBDatePicker.Value = DateTime.ParseExact(_personalInformationDto.DateOfBirth, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                AgeTextBox.Text = _personalInformationDto.Age.ToString();

            }

        }

        private async void LoadImage(byte[] data)
        {
            await ControlsHelper.ConvertByteToImageAsync(data, EmployeePictureBox);
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
            AgeTextBox.Text = calculatedAge.ToString();
        }

        private void PersonalInformation_Load(object sender, EventArgs e)
        {

        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            _canvasModal.Close();
        }

        private async void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = _personalInformationDto;

                // Validate FirstName
                dto.FirstName = string.IsNullOrWhiteSpace(FirstnameTextBox.Text)
                    ? throw new ArgumentException("First name is required")
                    : FirstnameTextBox.Text;

                // Validate MiddleName (allow null or empty values)
                dto.MiddleName = string.IsNullOrWhiteSpace(MiddlenameTextBox.Text) ? null : MiddlenameTextBox.Text;
                dto.Suffix = string.IsNullOrWhiteSpace(SuffixTextBox.Text) ? null : SuffixTextBox.Text;


                // Validate LastName
                dto.LastName = string.IsNullOrWhiteSpace(LastnameTextBox.Text)
                    ? throw new ArgumentException("Last name is required")
                    : LastnameTextBox.Text;

                // Validate Gender (ensure one of the options is selected)
                dto.Gender = MaleOption.Checked ? MaleOption.Text :
                                FemaleOption.Checked ? FemaleOption.Text :
                                throw new ArgumentException("Gender is required");

                // Validate DateOfBirth
                dto.DateOfBirth = DoBDatePicker.Value == default ?
                    throw new ArgumentException("Date of birth is required") :
                    DoBDatePicker.Value.Date.ToString("yyyy-MM-dd");

                // Validate Age (ensure it's a valid number and within a reasonable range)
                if (string.IsNullOrWhiteSpace(AgeTextBox.Text) || !byte.TryParse(AgeTextBox.Text, out byte age) || age < 18 || age > 120)
                {
                    throw new ArgumentException("Please enter a valid age between 18 and 80.");
                }
                dto.Age = age;

                var image = await ControlsHelper.ConvertImageToByteAsync(EmployeePictureBox);

                // Validate EmployeeImage (ensure an image is selected)
                dto.EmployeeImage = image
                    ?? throw new ArgumentException("Employee image is required");

                if (MaritalStatComboBox.SelectedIndex < 0)
                {
                    throw new ArgumentException("Please select a valid marital status.");
                }
                dto.MaritalStatus = MaritalStatComboBox.SelectedItem.ToString();
              

                // Proceed to the next step
                _canvasModal.advanceToSecond();
            }
            catch (ArgumentException ex)
            {
                // Show validation error message
                GunaMessage.Warning(ex.Message, "Require fields missing");
            }
            catch (Exception ex)
            {
                // Show unexpected error message
                GunaMessage.Warning("An unexpected error occurred: " + ex.Message, "Error");
            }
        }


        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private async void UploadButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            OpenFile.Title = "Select Employee Picture";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = OpenFile.FileName;

                // Load image asynchronously
                _ = LoadPic(filePath);
                
            }
        }

        private async Task LoadPic(string filePath)
        {
            Image image = await Task.Run(() => Image.FromFile(filePath));
            EmployeePictureBox.Image = image;
        }

        private void LastnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
