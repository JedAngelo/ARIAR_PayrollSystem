using PayrollSystem.Helpers;
using PayrollSystem.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PayrollSystem.Forms
{
    public partial class Report : Form
    {
        private readonly MainForm _mainForm;

        private List<int> Years = new List<int>();

        private class Month
        {
            public int MonthNumber { get; set; }
            public string MonthName { get; set; }
        }

        private readonly List<Month> Months = new List<Month>
        {
            new Month { MonthNumber = 1, MonthName = "January" },
            new Month { MonthNumber = 2, MonthName = "February" },
            new Month { MonthNumber = 3, MonthName = "March" },
            new Month { MonthNumber = 4, MonthName = "April" },
            new Month { MonthNumber = 5, MonthName = "May" },
            new Month { MonthNumber = 6, MonthName = "June" },
            new Month { MonthNumber = 7, MonthName = "July" },
            new Month { MonthNumber = 8, MonthName = "August" },
            new Month { MonthNumber = 9, MonthName = "September" },
            new Month { MonthNumber = 10, MonthName = "October" },
            new Month { MonthNumber = 11, MonthName = "November" },
            new Month { MonthNumber = 12, MonthName = "December" }
        };



        public void PopulateYears()
        {
            for (int year = 1970; year <= 2099; year++)
            {
                Years.Add(year);
            }
        }


        public Report(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            PopulateYears();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.ReportViewer.RefreshReport();
            ChangeDateType("month");
        }

        private async void ReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Delay(250);
                ReportButton.Text = "Loading Report...";
                await Task.Run(() =>
                {
                    BeginInvoke((Action)(async () =>
                    {
                        
                        var reportType = ReportType.Text.ToUpper();
                        //var year = (int)Date1Box.SelectedItem;
                        //var date = new DateOnly(2024, 12, 1);
                        //var date = new DateOnly(year, month, 1);

                        switch (reportType)
                        {
                            case "SUMMARY PAYROLL REPORT":
                                //Console.WriteLine($"{date:yyyy-MM-dd}");
                                ReportViewer.LocalReport.ReportEmbeddedResource = "PayrollSystem.Reports.MonthlyPayrollReport.rdlc";
                                var reportData = await GetSummaryReport($"{StartDatePicker.Value:yyyy-MM-dd}", $"{EndDatePicker.Value:yyyy-MM-dd}");
                                LoadPayrollSummaryDataSet(reportData);
                                break;
                            case "ANNUAL PAYROLL REPORT":
                                //
                                ReportViewer.LocalReport.ReportEmbeddedResource = "PayrollSystem.Reports.AnnualPayrollReport.rdlc";
                                int year = int.Parse(Date1Box.Text);
                                var annuallreportData = await GetSummaryReport($"{new DateOnly(year, 01, 01):yyyy-MM-dd}", $"{new DateOnly(year, 12, 31):yyyy-MM-dd}");
                                LoadPayrollSummaryDataSet(annuallreportData);
                                break;
                            default:
                                Console.WriteLine("Selected index doesn't match");
                                break;
                        }
                    }));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportType.Enabled = false;
            Date1Box.Enabled = false;

            var reportType = ReportType.Text.ToUpper();


            switch (reportType)
            {
                case "SUMMARY PAYROLL REPORT":
                    ChangeDateType("month");
                    break;
                case "ANNUAL PAYROLL REPORT":
                    ChangeDateType("year");
                    break;
                default:
                    Console.WriteLine("Selected index doesn't match");
                    break;
            }
            ReportType.Enabled = true;
            Date1Box.Enabled = true;
        }


        private void ChangeDateType(string type)
        {
            if (type == "month")
            {
                DateRangePanel.Visible = true;
                return;
            }
            if (type == "year")
            {
                DateRangePanel.Visible = false;
                Date1Box.ValueMember = null;
                Date1Box.DisplayMember = null;
                Date1Box.DataSource = Years;
                Date1Box.SelectedIndex = DateOnly.FromDateTime(DateTime.Now).Year - 1970;
            }            
        }


        private void LoadPayrollSummaryDataSet(TotalPayrollSummaryDto dto)
        {
            try
            {
                var data = dto.EmployeeSummaryReports.Select(x => new TotalMonthlyReportFlat
                {
                    StartDate = $"{DateOnly.ParseExact(dto.StartDate, "MM/dd/yyyy", CultureInfo.InvariantCulture):MMMM d, yyyy}",
                    EndDate = $"{DateOnly.ParseExact(dto.EndDate, "MM/dd/yyyy", CultureInfo.InvariantCulture):MMMM d, yyyy}",
                    TotalCompanyTotalCost = $"₱{dto.TotalCompanyTotalCost:#,#0.00}",
                    TotalEmployeePayrollCost = $"₱{dto.TotalEmployeePayrollCost:#,#0.00}",
                    TotalEmployerContributionCost = $"₱{dto.TotalEmpoyerContributionCost:#,#0.00}",
                    EmployeeId = x.EmployeeId.ToString(),
                    EmployeeName = x.EmployeeName,
                    Position = x.Position,
                    GrossSalary = $"₱{x.GrossSalary:#,#0.00}",
                    TotalWorkDay = $"{x.TotalWorkDay:F1}",
                    AbsentDeduction = $"₱{x.AbsentDeduction:#,#0.00}",
                    LateDeduction = $"₱{x.LateDeduction:#,#0.00}",
                    UndertimeDeduction = $"₱{x.UndertimeDeduction:#,#0.00}",
                    EmployeePagibigShare = $"₱{x.EmployeePagibigShare:#,#0.00}",
                    EmployeePhilhealthShare = $"₱{x.EmployeePhilhealthShare:#,#0.00}",
                    EmployeeSssShare = $"₱{x.EmployeeSssShare:#,#0.00}",
                    EmployerPagibigShare = $"₱{x.EmployerPagibigShare:#,#0.00}",
                    EmployerPhilhealthShare = $"₱{x.EmployerPhilhealthShare:#,#0.00}",
                    EmployerSssShare = $"₱{x.EmployerSssShare:#,#0.00}",
                    IncomeTax = $"₱{x.IncomeTax:#,#0.00}",
                    OtherDeductions = $"₱{x.OtherDeductions:#,#0.00}",
                    TotalDeductions = $"₱{x.TotalDeductions:#,#0.00}",
                    NetSalary = $"₱{x.NetSalary:#,#0.00}",
                    HolidayPayTotalDays = $"{x.HolidayPayTotalDays:F1}",
                    PremiumPayTotalDays = $"{x.PremiumPayTotalDays:F1}",
                    TotalEmployeeIncomeTax = "0",
                    TotalEmployeeContributionCost = $"{x.EmployeeSssShare + x.EmployeePhilhealthShare + x.EmployeePagibigShare}" ,
                    DateIssued = $"{DateTime.Now:MM/dd/yyyy}"
                }).ToList();
                //₱

                var reportData = new ReportDataSource("ReportData", data);
                ReportViewer.LocalReport.DataSources.Clear();
                ReportViewer.LocalReport.DataSources.Add(reportData);
                ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                ReportViewer.ZoomMode = ZoomMode.PageWidth;
                ReportViewer.RefreshReport();
                ReportButton.Text = "Generate Report";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadAnnualReportDataSet(TotalYearlyReportDto dto)
        {
            try
            {
                var data = dto.TotalMonthlyReports.SelectMany(monthlyReport =>
                    monthlyReport.EmployeeSummaryReports.Select(employee => new TotalYearlyReportFlat
                    {
                        // Yearly Summary Data (from TotalYearlyReportDto)
                        Year = dto.Year,  //or year.ToString()
                        Month = $"{DateOnly.ParseExact(monthlyReport.StartDate, "MM/dd/yyyy", CultureInfo.InvariantCulture):MMMM}",
                        YTDGrossSalary = $"₱{dto.YTDGrossSalary:#,#0.00}",
                        YTDNetSalaryPaid = $"₱{dto.YTDNetSalaryPaid:#,#0.00}",
                        YTDTotalEmployerSssCost = $"₱{dto.YTDTotalEmployerSssCost:#,#0.00}",
                        YTDTotalEmployerPhilhealthCost = $"₱{dto.YTDTotalEmployerPhilhealthCost:#,#0.00}",
                        YTDTotalEmployerPagibigCost = $"₱{dto.YTDTotalEmployerPagibigCost:#,#0.00}",
                        YTDTotalEmployeesSss = $"₱{dto.YTDTotalEmployeesSss:#,#0.00}",
                        YTDTotalEmployeesPhilhealth = $"₱{dto.YTDTotalEmployeesPhilhealth:#,#0.00}",
                        YTDTotalEmployeesPagibig = $"₱{dto.YTDTotalEmployeesPagibig:#,#0.00}",
                        YTDIncomeTaxCost = $"₱{dto.YTDIncomeTaxCost:#,#0.00}",
                        YTDTotalCompanyPayrollCost = $"₱{dto.YTDTotalCompanyPayrollCost:#,#0.00}",

                        // Monthly Data (from TotalPayrollSummaryDto/PayrollSummaryReportDto)
                        StartDate = $"{DateOnly.ParseExact(monthlyReport.StartDate, "MM/dd/yyyy", CultureInfo.InvariantCulture):MMMM d, yyyy}",
                        EndDate = $"{DateOnly.ParseExact(monthlyReport.EndDate, "MM/dd/yyyy", CultureInfo.InvariantCulture):MMMM d, yyyy}",

                        EmployeeId = employee.EmployeeId.ToString(),
                        EmployeeName = employee.EmployeeName,
                        Position = employee.Position,

                        TotalWorkDay = $"{employee.TotalWorkDay:F1}",
                        GrossSalary = $"₱{employee.GrossSalary:#,#0.00}",

                        EmployeeSssShare = $"₱{employee.EmployeeSssShare:#,#0.00}",
                        EmployeePhilhealthShare = $"₱{employee.EmployeePhilhealthShare:#,#0.00}",
                        EmployeePagibigShare = $"₱{employee.EmployeePagibigShare:#,#0.00}",
                        IncomeTax = $"₱{employee.IncomeTax:#,#0.00}",
                        AbsentDeduction = $"₱{employee.AbsentDeduction:#,#0.00}",
                        LateDeduction = $"₱{employee.LateDeduction:#,#0.00}",
                        UndertimeDeduction = $"₱{employee.UndertimeDeduction:#,#0.00}",
                        OtherDeductions = $"₱{employee.OtherDeductions:#,#0.00}",
                        TotalDeductions = $"₱{employee.TotalDeductions:#,#0.00}",

                        EmployerSssShare = $"₱{employee.EmployerSssShare:#,#0.00}",
                        EmployerPhilhealthShare = $"₱{employee.EmployerPhilhealthShare:#,#0.00}",
                        EmployerPagibigShare = $"₱{employee.EmployerPagibigShare:#,#0.00}",

                        NetSalary = $"₱{employee.NetSalary:#,#0.00}",
                        PremiumPayTotalDays = $"{employee.PremiumPayTotalDays:F1}",
                        HolidayPayTotalDays = $"{employee.HolidayPayTotalDays:F1}",

                        TotalEmployeePayrollCost = $"₱{monthlyReport.TotalEmployeePayrollCost:#,#0.00}",
                        TotalEmployerContributionCost = $"₱{monthlyReport.TotalEmpoyerContributionCost:#,#0.00}", //Corrected typo
                        TotalCompanyTotalCost = $"₱{monthlyReport.TotalCompanyTotalCost:#,#0.00}"

                    })).ToList();

                var reportData = new ReportDataSource("ReportData", data);
                ReportViewer.LocalReport.DataSources.Clear();
                ReportViewer.LocalReport.DataSources.Add(reportData);
                ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                ReportViewer.ZoomMode = ZoomMode.PageWidth;
                ReportViewer.RefreshReport();
                ReportButton.Text = "Generate Report";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task<TotalPayrollSummaryDto> GetSummaryReport(string start, string end)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<TotalPayrollSummaryDto>>($"{ApiEndpoint.Payroll.GetMonthlyReport}?start={start}&end={end}");

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    Console.WriteLine("Monthly report loaded");
                    return apiData.Data;
                }
                else
                {
                    Console.WriteLine("Failed loading monthly report");
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        private async Task<TotalYearlyReportDto> GetAnnualReport(int year)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<TotalYearlyReportDto>>($"{ApiEndpoint.Payroll.GetAnnualReport}?date={new DateOnly(year, 01, 01)}");

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    Console.WriteLine("Monthly report loaded");
                    return apiData.Data;
                }
                else
                {
                    Console.WriteLine("Failed loading monthly report");
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }


    }
}
