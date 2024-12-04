using ARIAR_PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms.Modals.ChildrenModal
{
    public partial class EmploymentDetails : Form
    {
        private readonly EmployeeCanvasModal _canvasModal;
        private EmploymentDetailDto _employmentDetailDto;

        public EmploymentDetails(EmployeeCanvasModal canvasModal, EmploymentDetailDto employmentDetailDto)
        {
            InitializeComponent();
            _canvasModal = canvasModal;
            _employmentDetailDto = employmentDetailDto;
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            _canvasModal.retreatToSecond();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _canvasModal.Close();
        }

        private void EmploymentDetails_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = _employmentDetailDto;

                // Validate HireDate
                dto.HireDate = HiredDatePicker.Value.Date.ToString("yyyy-MM-dd");

                // Validate PayRate (must be a valid decimal number)
                if (string.IsNullOrWhiteSpace(PayrateTextBox.Text) || !decimal.TryParse(PayrateTextBox.Text, out decimal payRate))
                {
                    throw new ArgumentException("Please enter a valid Pay Rate.");
                }
                dto.PayRate = payRate;

                // Validate IncomeTaxRate (must be a valid decimal number)
                if (string.IsNullOrWhiteSpace(IncomeTextBox.Text) || !decimal.TryParse(IncomeTextBox.Text, out decimal incomeTaxRate))
                {
                    throw new ArgumentException("Please enter a valid Income Tax Rate.");
                }
                dto.IncomeTaxRate = incomeTaxRate;

                // Validate SSS Employee Rate (must be a percentage between 0 and 1)
                if (string.IsNullOrWhiteSpace(SSSTextBox.Text) || !decimal.TryParse(SSSTextBox.Text, out decimal sssRate) || sssRate < 0 || sssRate > 1)
                {
                    throw new ArgumentException("SSS Employee Rate must be a valid percentage (0 - 1).");
                }
                dto.SssEmployeeRate = sssRate;

                // Validate Philhealth Employee Rate (must be a percentage between 0 and 1)
                if (string.IsNullOrWhiteSpace(PhilhealthTextbox.Text) || !decimal.TryParse(PhilhealthTextbox.Text, out decimal philhealthRate) || philhealthRate < 0 || philhealthRate > 1)
                {
                    throw new ArgumentException("Philhealth Employee Rate must be a valid percentage (0 - 1).");
                }
                dto.PhilhealthEmployeeRate = philhealthRate;

                // Validate Pagibig Employee Rate (must be a percentage between 0 and 1)
                if (string.IsNullOrWhiteSpace(PagibigTextBox.Text) || !decimal.TryParse(PagibigTextBox.Text, out decimal pagibigRate) || pagibigRate < 0 || pagibigRate > 1)
                {
                    throw new ArgumentException("Pagibig Employee Rate must be a valid percentage (0 - 1).");
                }
                dto.PagibigEmployeeRate = pagibigRate;

                dto.PositionId = 1;

                _canvasModal.AddEmployeeAsync();

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

    }
}
