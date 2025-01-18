using PayrollSystem.Helpers;
using PayrollSystem.Models;
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
using System.Xml;

namespace PayrollSystem.Forms.Modals
{
    public partial class PayrollDetailsModal : Form
    {
        private PayrollDto _payrollData;
        private PersonalInformationDisplayDto _employee;
        private MainForm _mainForm;
        public PayrollDetailsModal(PayrollDto payrollData, PersonalInformationDisplayDto employee, MainForm mainForm)
        {
            InitializeComponent();
            _payrollData = payrollData;
            _employee = employee;
            _mainForm = mainForm;
        }

        private async Task LoadData(PayrollDto data)
        {
            try
            {
                await Task.Run(() =>
                {
                    Invoke((Action)(() =>
                    {
                        FullnameLabel.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}{(string.IsNullOrEmpty(_employee.Suffix) ? "" : $" {_employee.Suffix}")}";
                        var startDate = DateOnly.ParseExact(data.StartDate, "yyyy-MM-dd");
                        var endDate = DateOnly.ParseExact(data.EndDate, "yyyy-MM-dd");
                        var workingDays = ((endDate.DayNumber + 1) - startDate.DayNumber) - ControlsHelper.GetNumberOfSundays(startDate, endDate);
                        var dailySalary = data.GrossSalary / workingDays;
                        AbsentBox.Text = $"{data.AbsentDeduction:F}";
                        LateBox.Text = $"{data.LateDeduction:F}";
                        UndertimeBox.Text = $"{data.UndertimeDeduction:F}";
                        SssBox.Text = $"{data.EmployeeSssShare:F}";
                        PagibigBox.Text = $"{data.EmployeePagibigShare:F}";
                        PhilhealthBox.Text = $"{data.EmployeePhilhealthShare:F}";
                        IncomeTaxBox.Text = $"{data.IncomeTax:F}";
                        OtherDeductionBox.Text = $"{data.OtherDeductions:F}";
                        CommissionBox.Text = $"{data.Commissions:F}";
                        DailySalaryBox.Text = $"{data.DailySalary:F}";
                        //WorkDayBox.Text = $"{FormatNumber((decimal)data.TotalWorkDay)}";
                        DateLabel.Text = DateOnly.ParseExact(data.PayrollDate, "yyyy-MM-dd").ToString("MMMM d, yyyy");
                        GrossSalaryBox.Text = $"{data.GrossSalary:F}";
                        TotalDeductionBox.Text = $"{data.TotalDeductions:F}";
                        NetSalaryBox.Text = $"{data.NetSalary:F}";
                        AbsentDays.Text = $"{data.TotalAbsentDays:F1}";
                        MinutesLate.Text = $"{data.TotalLateMinutes:F1}";
                        UndertimeHours.Text = $"{data.TotalUndertimeHours:F1}";
                        HolidayPay.Text = $"{data.HolidayPayAddtitions:F}";
                        HolidayDays.Text = $"{data.HolidayPayTotalDays:F1}";
                        PremiumPay.Text = $"{data.PremiumPayAdditions:F}";
                        PremiumDays.Text = $"{data.PremiumPayTotalDays:F1}";
                        OvertimePay.Text = $"{data.OvertimePay:F}";
                        OvertimeHours.Text = $"{data.TotalOvertimeHours:F1}";

                        AbsentCalc.Text = $"× ₱{data.DailySalary:F} =";
                        LateCalc.Text = $"× ₱{_mainForm.Settings.LateDeductionPerMinute:F} =";
                        UndertimeCalc.Text = $"× ₱{_mainForm.Settings.UndertimeDeductionPerHour:F} =";
                        TotalAdditions.Text = $"{data.PremiumPayAdditions+data.HolidayPayAddtitions+data.OvertimePay}";

                        if ((bool)data.IsFinallized)
                        {
                            PayrollStatus.Text = "Fixed";
                            OtherDeductionBox.Enabled = false;
                            CommissionBox.Enabled = false;
                        }
                    }));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void PayrollDetailsModal_Load(object sender, EventArgs e)
        {
            await LoadData(_payrollData);
        }

        public static string FormatNumber(decimal number)
        {
            return (number % 1 == 0) ? $"{number:F0}" : $"{number:F1}";
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            _payrollData.OtherDeductions = decimal.Parse(OtherDeductionBox.Text);
            _payrollData.Commissions = decimal.Parse(CommissionBox.Text);
            await UpdatePayroll(_payrollData);
        }

        private async Task UpdatePayroll(PayrollDto data)
        {
            try
            {
                var apiData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Payroll.AddOthers, data);

                if (apiData == null) throw new HttpRequestException("Update payroll endpoint returned null");

                if (apiData.isSuccess)
                {
                    GunaMessage.Info(apiData.Data, "Update");
                }
                else
                {
                    GunaMessage.Warning(apiData.ErrorMessage, "Error");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ContributionButton_Click(object sender, EventArgs e)
        {
            var benefitsModal = new BenefitsModal(_payrollData, _employee);
            ControlsHelper.ShowModal(_mainForm, benefitsModal);
        }

        private void CalculationDetailButton_Click(object sender, EventArgs e)
        {
            var detailsModal = new PayrollCalculationDetails(_payrollData, _employee);
            ControlsHelper.ShowModal(_mainForm, detailsModal);
        }
    }
}
