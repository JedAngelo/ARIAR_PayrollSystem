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

namespace PayrollSystem.Forms.Modals.ChildrenModal
{
    public partial class ContactInformationForm : Form
    {
        private readonly EmployeeCanvasModal _canvasModel;
        private ContactInformationDto _contactInformationDto;

        public ContactInformationForm(EmployeeCanvasModal canvasModal, ContactInformationDto contactInformationDto)
        {
            InitializeComponent();
            _canvasModel = canvasModal;
            _contactInformationDto = contactInformationDto;
                       
            if (_contactInformationDto?.ContactId != null)
            {
                PhoneTextBox.Text = _contactInformationDto.PhoneNumber;
                EmailTextBox.Text = _contactInformationDto.Email;
                AddressTextBox.Text = _contactInformationDto.Address;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _canvasModel.Close();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            _canvasModel.retreatToFirst();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = _contactInformationDto;
                // Validate Phone Number (Philippine format)
                dto.PhoneNumber = string.IsNullOrWhiteSpace(PhoneTextBox.Text)
                    ? throw new ArgumentException("Phone number is required.")
                    : PhoneTextBox.Text;

                if (!IsValidPhoneNumber(dto.PhoneNumber)) // Validate phone number format
                {
                    throw new ArgumentException("Please enter a valid Philippine phone number");
                }
                // Validate Email
                dto.Email = string.IsNullOrWhiteSpace(EmailTextBox.Text)
                    ? throw new ArgumentException("Email is required.")
                    : EmailTextBox.Text;

                if (!IsValidEmail(dto.Email)) // Check if the email is valid
                {
                    throw new ArgumentException("Please enter a valid email address.");
                }



                // Validate Address
                dto.Address = string.IsNullOrWhiteSpace(AddressTextBox.Text)
                    ? throw new ArgumentException("Address is required.")
                    : AddressTextBox.Text;

                // Proceed to the next step if all validations pass
                _canvasModel.advanceToThird();
            }
            catch (ArgumentException ex)
            {
                // Show validation error message
                GunaMessage.Warning(ex.Message, "Validation Error");
            }
            catch (Exception ex)
            {
                // Show unexpected error message
                GunaMessage.Warning("An unexpected error occurred: " + ex.Message, "Error");
            }
        }

        // Helper method to validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email; // Check for a valid email format
            }
            catch
            {
                return false;
            }
        }

        // Helper method to validate Philippine phone number
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // This regex validates Philippine phone numbers:
            // - With or without country code (+63 or (63))
            // - With or without spaces or hyphens
            // - Can start with 09 or just 9
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^(\+63|63)?[\s\-]?[9][0-9]{2}[\s\-]?[0-9]{3}[\s\-]?[0-9]{4}$") ||
                   System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^(09|\+639|\(639\))\d{9}$");
        }


    }
}
