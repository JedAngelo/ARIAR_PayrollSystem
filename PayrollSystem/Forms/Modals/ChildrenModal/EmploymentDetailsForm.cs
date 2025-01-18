using PayrollSystem.Helpers;
using PayrollSystem.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PayrollSystem.Forms.Modals.ChildrenModal
{
    public partial class EmploymentDetailsForm : Form
    {
        private readonly EmployeeCanvasModal _canvasModal;
        private EmploymentDetailDto _employmentDetailDto;


        public EmploymentDetailsForm(EmployeeCanvasModal canvasModal, EmploymentDetailDto employmentDetailDto)
        {
            InitializeComponent();
            _canvasModal = canvasModal;
            _employmentDetailDto = employmentDetailDto;

            // Call and await load position here
            InitializeFormAsync().ConfigureAwait(true);
        }

        private async Task InitializeFormAsync()
        {
            await LoadPostions();


            if (_employmentDetailDto?.EmploymentId != null)
            {
                HiredDatePicker.Value = DateTime.ParseExact(_employmentDetailDto.HireDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                BasicSalaryBox.Text = _employmentDetailDto.BasicSalary.ToString("#,#0.00");
                DaliySalaryBox.Text = _employmentDetailDto.DailySalary.ToString("#,#0.00");
                RegularSwitch.Checked = _employmentDetailDto.IsRegular;
                LoadSelectedPosition(_employmentDetailDto.PositionId);
                NextButton.Text = "Update";
            }
            else
            {
                PositionComboBox.SelectedIndex = 0;
            }
        }

        private void LoadSelectedPosition(int id)
        {
            if (PositionComboBox.DataSource == null)
            {
                MessageBox.Show("ComboBox data source is not set.");
                return;
            }

            var dataList = PositionComboBox.DataSource as List<PositionDisplayDto>; // Cast to your data list

            if (dataList == null)
            {
                MessageBox.Show("Data source is not of the expected type (List<MyData>).");
                return;
            }

            // 2. Find the object that matches the ID
            PositionDisplayDto targetItem = dataList.FirstOrDefault(item => item.PositionId == id);


            // 3. Check if the item was found.
            if (targetItem == null)
            {
                MessageBox.Show($"Item with ID '{id}' not found in the data source.");
                return;
            }


            // 4. Select the item
            PositionComboBox.SelectedItem = targetItem;
        }

        private async Task LoadPostions()
        {
            try
            {
                var positions = await HttpHelper.GetAsync<ApiResponse<List<PositionDisplayDto>>>(ApiEndpoint.Employee.GetPositions);

                if (positions == null) throw new HttpRequestException($"API data returned null: {nameof(positions)}");

                if (positions.isSuccess)
                {
                    PositionComboBox.DisplayMember = "PositionName";
                    PositionComboBox.ValueMember = "PositionId";
                    PositionComboBox.DataSource = positions.Data;

                }
                else
                {
                    Console.WriteLine(positions.ErrorMessage);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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

                dto.IsRegular = RegularSwitch.Checked;

                // Validate PayRate (must be a valid decimal number)
                if (string.IsNullOrWhiteSpace(BasicSalaryBox.Text) || !decimal.TryParse(BasicSalaryBox.Text, out decimal basicSalary))
                {
                    throw new ArgumentException("Please enter a valid Basic Salary.");
                }
                dto.BasicSalary = basicSalary;

                 // Validate PayRate (must be a valid decimal number)
                if (string.IsNullOrWhiteSpace(DaliySalaryBox.Text) || !decimal.TryParse(DaliySalaryBox.Text, out decimal dailySalary))
                {
                    throw new ArgumentException("Please enter a valid Daily Salary.");
                }
                dto.DailySalary = dailySalary;


                if (PositionComboBox.SelectedItem is PositionDisplayDto selectedPosition) // Safe cast
                {
                    dto.PositionId = (int)selectedPosition.PositionId;
                }
                else
                {
                    throw new ArgumentException("Please select a position.");
                }

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

        private void PositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PositionComboBox.SelectedItem is PostionDto selectedPosition) // Safe cast
            {
                Console.WriteLine(selectedPosition.PositionId);
            }
        }

        private void BasicSalaryBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(BasicSalaryBox.Text) || !decimal.TryParse(BasicSalaryBox.Text, out decimal basicSalary))
                {
                    throw new ArgumentException("Please enter a valid Basic Salary.");
                }
                var dailySalary = basicSalary / 24;
                DaliySalaryBox.Text = $"{dailySalary:#,#0.00}"; 
            }
            catch (Exception ex)
            {
                ToastNotify.Warning(ex.Message);
            }
        }
    }
}