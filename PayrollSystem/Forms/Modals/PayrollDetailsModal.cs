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
using System.Xml;

namespace PayrollSystem.Forms.Modals
{
    public partial class PayrollDetailsModal : Form
    {
        private PayrollDto _payrollData;
        public PayrollDetailsModal(PayrollDto payrollData)
        {
            InitializeComponent();
            _payrollData = payrollData;
        }

        private async Task LoadData(PayrollDto data)
        {
            try
            {
                await Task.Run(() =>
                {
                    Invoke((Action)(() =>
                    {
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
                        DailySalaryBox.Text = $"{dailySalary:F}";
                        WorkDayBox.Text = $"{FormatNumber((decimal)data.TotalWorkDay)}";
                        GrossSalaryBox.Text = $"{data.GrossSalary:F}";
                        TotalDeductionBox.Text = $"{data.TotalDeductions:F}";
                        NetSalaryBox.Text = $"{data.NetSalary:F}";
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

    }
}
