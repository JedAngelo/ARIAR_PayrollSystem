using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using ARIAR_PayrollSystem.UserControls;
using Newtonsoft.Json;
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
using static ARIAR_PayrollSystem.Helpers.ApiEndpoint;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class PayrollCalclulation : Form
    {
        private MainForm _mainForm;
        private DateOnly _payrollDate;
        private DateRangeDto _payrollDateRange;
        private DateOnly _startDate;
        private PersonalInformationDisplayDto _selectedEmployee;
        private List<PersonalInformationDisplayDto> _employees;
        private List<PayrollDto> _payrollList;
        private bool _sortAscending = true;
        private int _viewCount;
        private int _skipCount;
        private int _currentPage;
        private int _maxPage;

        private int ViewCount
        {
            get { return _viewCount; }
            set
            {
                if (_viewCount == value) return;
                _viewCount = value;
                LoadView(_employees);
            }
        }
        private int SkipCount
        {
            get { return _skipCount; }
            set
            {
                if (_skipCount == value) return;
                _skipCount = value;
                LoadView(_employees);
                
            }
        }
        private int CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (_currentPage == value) return;
                Console.WriteLine($"Current page change to {value}");
                _currentPage = value;
                SkipCount = (_currentPage - 1) * ViewCount;
                CurrentPageLabel.Text = _currentPage.ToString();
            }
        }


        private List<PayrollDto> PayrollList
        {
            get { return _payrollList; }
            set
            {
                _payrollList = value;
                if (_payrollList != null) PrintPayslipButton.Enabled = true;
            }
        }
        public PersonalInformationDisplayDto SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                if (_selectedEmployee != null) ViewDetailsButton.Enabled = true;
                else ViewDetailsButton.Enabled = false;

            }
        }

        public PayrollDto SelectedPayrollData { get; set; }

        public DateRangeDto PayrollDateRange
        {
            get { return _payrollDateRange; }
            set
            {
                Console.WriteLine(JsonConvert.SerializeObject(value, Formatting.Indented));
                _payrollDate = DateOnly.ParseExact(value.EndDate, "yyyy-MM-dd");
                _payrollDateRange = value;
                _startDate = DateOnly.ParseExact(value.StartDate, "yyyy-MM-dd");
                PayrollPeriodLabel.Text = $"{_payrollDate:MMM. d, yyyy}";
                PayrollPeriodLabel.ForeColor = Color.DodgerBlue;
                CalcPayrollButton.Enabled = true;
                CheckPayrollData($"{_payrollDate:yyyy-MM-dd}");                               
            }
        }


        public PayrollCalclulation(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            ViewCount = 10;
            SkipCount = 0;
            CurrentPage = 1;
        }

       

        private async void EmployeeTableView_SizeChanged(object sender, EventArgs e)
        {
            var controls = EmployeeTableView.Controls.OfType<Control>().ToList();

            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    // Calculate the new width
                    int newWidth = EmployeeTableView.Width - 2;

                    // Update the control on the UI thread
                    EmployeeTableView.Invoke((Action)(() =>
                    {
                        control.Width = newWidth;
                    }));
                }
            });
            EmployeeViewScrollBar.Visible = true;
        }

        private void PayrollRangeButton_Click(object sender, EventArgs e)
        {
            PayrollPeriodSelector selector = new PayrollPeriodSelector(this);
            ControlsHelper.ShowModal(_mainForm, selector);
        }

        private void PayrollCalclulation_Load(object sender, EventArgs e)
        {
            _employees = _mainForm.EmployeeInfo;
            LoadView(_employees);
        }

        private async void LoadView(List<PersonalInformationDisplayDto> data)
        {
            try
            {
                CalculateMaxPage();
                var paginatedData = data.Skip(SkipCount).Take(ViewCount).ToList();
                PageCountLabel.Text = data.Count == 0 ? "0 of 0" :
                                      _currentPage == _maxPage ? $"{SkipCount + 1} - {data.Count} of {data.Count}" :
                                      $"{SkipCount + 1} - {ViewCount + SkipCount} of {data.Count}";
                CurrentPageLabel.Text = _currentPage.ToString();
                await PayrollView.DataViewAsync(this, paginatedData, EmployeeTableView);
                await Task.Delay(250);
                if (PayrollList != null)
                {
                    await UpdatePayrollView(PayrollList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CalculateMaxPage()
        {
            if (_mainForm.EmployeeInfo == null)
            {
                _maxPage = 0;
                return;
            }
            _maxPage = (int)Math.Ceiling((double)_mainForm.EmployeeInfo.Count / ViewCount);
        }

        private async void CalcPayrollButton_Click(object sender, EventArgs e)
        {
            await CalculatePayroll(_startDate, _payrollDate);
        }

        private async Task CalculatePayroll(DateOnly start, DateOnly end)
        {
            try
            {
                var dateRange = new DateRangeDto { StartDate = $"{start:yyyy-MM-dd}", EndDate = $"{end:yyyy-MM-dd}" };

                var _apiData = await HttpHelper.PostAsync<ApiResponse<string>, DateRangeDto>(ApiEndpoint.Payroll.CalculatePayroll, dateRange);

                if (_apiData == null) throw new ArgumentNullException(nameof(_apiData) + " is null");

                if (_apiData.isSuccess)
                {
                    GunaMessage.Info(_apiData.Data, "Success");
                    var apiData = await GetPayrollData($"{_payrollDate:yyyy-MM-dd}");
                    LoadPayrollData(apiData);
                }
                else
                {
                    GunaMessage.Warning("Problem occured when calculating payroll, try again later", "Unexpected Problem");
                    Console.WriteLine(_apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void RemoveSelected()
        {
            var control = EmployeeTableView.Controls.OfType<PayrollView>().FirstOrDefault(x => x.Selected);
            if (control != null) control.Selected = false;
        }

        public async Task UpdatePayrollView(List<PayrollDto> dataList)
        {
            try
            {
                var controls = EmployeeTableView.Controls.OfType<PayrollView>().ToList();
                await Task.Run(() =>
                {
                    foreach (var control in controls)
                    {
                        control.SetPayrollData(dataList.FirstOrDefault(x => x.PersonalId == control.PersonalId));
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void CheckPayrollData(string date)
        {
            var apiData = await GetPayrollData(date);
            if (apiData == null) return;
            LoadPayrollData(apiData);
        }

        private async Task<ApiResponse<List<PayrollDto>>> GetPayrollData(string date)
        {
            try
            {
                return await HttpHelper.GetAsync<ApiResponse<List<PayrollDto>>>($"{ApiEndpoint.Payroll.GetPayrolls}?payrollDate={date}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private async void LoadPayrollData(ApiResponse<List<PayrollDto>> apiData)
        {
            try
            {
                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " is null");

                if (apiData.isSuccess)
                {
                    ToastNotify.Info("Payroll information loaded successfully");
                    PayrollList = apiData.Data;
                    await UpdatePayrollView(PayrollList);
                }
                else
                {
                    ToastNotify.Warning("Problem loading payroll information");
                    Console.WriteLine(apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (SelectedPayrollData != null)
            {
                var payrollDetailModal = new PayrollDetailsModal(SelectedPayrollData);
                ControlsHelper.ShowModal(_mainForm, payrollDetailModal);
            }
            else
            {
                ToastNotify.Info("Payroll information does not exist");
            }
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                _sortAscending = true;
                SearchBox.Text = "";
                _mainForm.ReloadEmployeeData();
                _employees = _mainForm.EmployeeInfo;
                await Task.Delay(500);
                LoadView(_employees);
                await Task.Delay(250);
                if (PayrollList != null)
                {
                    await UpdatePayrollView(PayrollList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PrintPayslipButton_Click(object sender, EventArgs e)
        {
            var payslipModal = new PayslipReportModal(_mainForm.EmployeeInfo, $"{_payrollDate:yyyy-MM-dd}");
            ControlsHelper.ShowModal(_mainForm, payslipModal);
        }

        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
        }

        private void BackPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 1) return;
            CurrentPage -= 1;
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage == _maxPage) return;
            CurrentPage += 1;
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage = _maxPage;
        }

        private void ViewCountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewCount = int.Parse(ViewCountComboBox.SelectedItem.ToString());
            CurrentPage = 1;
        }

        private void CurrentPageLabel_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CurrentPageLabel.Text)) return;
            var page = int.Parse(CurrentPageLabel.Text);
            if (page > _maxPage)
            {
                GunaMessage.Warning($"Page doesn't exist", "Warning");
                CurrentPage = 1;
                return;
            }
            CurrentPage = page;
        }

        private void CurrentPageLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                // 1. Get the current text box text
                string currentText = CurrentPageLabel.Text;

                // 2. Get the current caret (cursor) position
                int caretPosition = CurrentPageLabel.SelectionStart;

                // 3. Construct the potential new text by inserting the key press
                string potentialNewText = currentText.Insert(caretPosition, e.KeyChar.ToString());

                // 4. Check if the combined text would result in a valid value
                if (int.TryParse(potentialNewText, out int newPageNumber))
                {
                    //5. Check leading zeroes and reject zero
                    if (potentialNewText.Length > 1 && potentialNewText[0] == '0')
                    {
                        e.Handled = true; // Prevent leading zeros if more than one character
                    }
                    else if (newPageNumber > _maxPage || newPageNumber < 1)
                    {
                        e.Handled = true; // Ignore if out of max page range
                    }
                }
                else
                {
                    e.Handled = true; // Ignore if it cannot be parsed into an integer
                }
            }
            else if (e.KeyChar != '\b') // Allow backspace
            {
                e.Handled = true; // Ignore all non-digits, except for backspace
            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (String.IsNullOrEmpty(SearchBox.Text))
                {
                    _employees = _mainForm.EmployeeInfo;
                    LoadView(_employees);
                    return;
                }

                var filter = SearchBox.Text.ToLower();
                //FilterPersonnel(guna2TextBox1.Text);
                _employees = _mainForm.EmployeeInfo.Where
                (
                    x => $"{x.FirstName} {(String.IsNullOrEmpty(x.MiddleName) ? "" : $"{x.MiddleName[0]}. ")}{x.LastName}".ToLower().Contains(filter)
                ).ToList();
                LoadView(_employees);


            }
        }

        private async void EmployeeSort_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            if (_sortAscending) _employees = _employees.OrderBy(x => x.FirstName).ToList();
            else _employees = _employees.OrderByDescending(x => x.FirstName).ToList();
            _sortAscending = !_sortAscending;
            LoadView(_employees);
        }
    }
}
