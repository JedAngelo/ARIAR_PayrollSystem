using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class BenefitsModal : Form
    {
        private PayrollDto _payrollData;
        private AccumulatedContributionsDto _contributionsData;
        private PersonalInformationDisplayDto _employee;
        public BenefitsModal(PayrollDto payrollData, PersonalInformationDisplayDto employee)
        {
            InitializeComponent();
            _payrollData = payrollData;
            _employee = employee;
        }

        private async Task GetAccumulatedContributions()
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<AccumulatedContributionsDto>>($"{ApiEndpoint.Payroll.GetAccumulatedContributions}?id={_payrollData.PersonalId}&date={_payrollData.PayrollDate}");

                if (apiData == null) throw new HttpRequestException("Can't retrieve contributions");

                if (apiData.isSuccess)
                {
                    _contributionsData = apiData.Data;
                    await LoadData();
                }
                else
                {
                    Console.WriteLine(apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task LoadData()
        {
            try
            {
                await Task.Run(() =>
                {
                    BeginInvoke((Action)(() =>
                    {
                        var date = DateOnly.ParseExact(_payrollData.PayrollDate, "yyyy-MM-dd", null);
                        var remittanceDate = new DateOnly(date.Year, date.Month, (date.Month == 2) ? 28 : 30);
                        FullnameLabel.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}{(string.IsNullOrEmpty(_employee.Suffix) ? "" : $" {_employee.Suffix}")}";
                        EmprPagibig.Text = $"{_payrollData.EmployerPagibigShare:F}";
                        EmprPhilhealth.Text = $"{_payrollData.EmployerPhilhealthShare:F}";
                        EmprSss.Text = $"{_payrollData.EmployerSssShare:F}";
                        EmprAccuPagibig.Text = $"{_contributionsData.EmployerPagibigShare:F}";
                        EmprAccuPhilhealth.Text = $"{_contributionsData.EmployerPhilhealthShare:F}";
                        EmprAccuSss.Text = $"{_contributionsData.EmployerSssShare:F}";

                        EmpPagibig.Text = $"{_payrollData.EmployeePagibigShare:F}";
                        EmpPhilhealth.Text = $"{_payrollData.EmployeePhilhealthShare:F}";
                        EmpSss.Text = $"{_payrollData.EmployeeSssShare:F}";
                        EmpAccuPagibig.Text = $"{_contributionsData.EmployeePagibigShare:F}";
                        EmpAccuPhilhealth.Text = $"{_contributionsData.EmployeePhilhealthShare:F}";
                        EmpAccuSss.Text = $"{_contributionsData.EmployeeSssShare:F}";

                        EmprAccu.Text = $"Accumulated Employer Contributions ({date.ToString("MMMM").ToUpper()})";
                        EmpAccu.Text = $"Accumulated Employee Contributions ({date.ToString("MMMM").ToUpper()})";
                        RemittanceDeadline.Text = $"{remittanceDate:MMMM d, yyyy}";

                    }));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void BenefitsModal_Load(object sender, EventArgs e)
        {
            await GetAccumulatedContributions();
        }
    }
}
