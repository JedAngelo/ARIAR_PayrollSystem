using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
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

namespace ARIAR_PayrollSystem.Forms
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
                        var month = (int)Date2Box.SelectedValue;
                        var year = (int)Date1Box.SelectedItem;
                        var date = new DateOnly(2024, 12, 1);
                        //var date = new DateOnly(year, month, 1);

                        switch (reportType)
                        {
                            case "MONTHLY PAYROLL REPORT":
                                Console.WriteLine($"{date:yyyy-MM-dd}");
                                ReportViewer.LocalReport.ReportEmbeddedResource = "ARIAR_PayrollSystem.Reports.MonthlyPayrollReport.rdlc";
                                var reportData = await GetMonthlyReport($"{date:yyyy-MM-dd}");
                                LoadMonthlyPayrollDataSet(reportData);
                                break;
                            case "ANNUAL PAYROLL REPORT":
                                break;
                            case "MONTHLY EMPLOYEE ATTENDANCE REPORT":
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
            Date2Box.Enabled = false;

            var reportType = ReportType.Text.ToUpper();


            switch (reportType)
            {
                case "MONTHLY PAYROLL REPORT":
                    ChangeDateType("month");
                    break;
                case "ANNUAL PAYROLL REPORT":
                    ChangeDateType("year");
                    break;
                case "MONTHLY EMPLOYEE ATTENDANCE REPORT":
                    ChangeDateType("month");
                    break;
                default:
                    Console.WriteLine("Selected index doesn't match");
                    break;
            }
            ReportType.Enabled = true;
            Date1Box.Enabled = true;
            Date2Box.Enabled = true;
        }


        private void ChangeDateType(string type)
        {
            if (type == "month")
            {
                Date1Box.ValueMember = null;
                Date1Box.DisplayMember = null;
                Date1Box.DataSource = Years;
                Date1Box.SelectedIndex = DateOnly.FromDateTime(DateTime.Now).Year - 1970;
                Date2Box.DataSource = Months;
                Date2Box.DisplayMember = "MonthName";
                Date2Box.ValueMember = "MonthNumber";
                Date2Box.SelectedValue = DateOnly.FromDateTime(DateTime.Now).Month;
                Date2Box.Visible = true;
                return;
            }
            if (type == "year")
            {
                Date1Box.ValueMember = null;
                Date1Box.DisplayMember = null;
                Date1Box.DataSource = Years;
                Date1Box.SelectedIndex = DateOnly.FromDateTime(DateTime.Now).Year - 1970;
                Date2Box.Visible = false;                
            }            
        }

        private void LoadMonthlyPayrollDataSet(TotalMonthlyReportDto dto)
        {
            try
            {
                var data = dto.EmployeeMonthlyReports.Select(x => new TotalMonthlyReportFlat
                {
                    Year = dto.Year,
                    Month = dto.Month,
                    MonthlyCompanyTotalCost = $"₱{dto.MonthlyCompanyTotalCost:#,#0.00}",
                    MonthlyEmployeePayrollCost = $"₱{dto.MonthlyEmployeePayrollCost:#,#0.00}",
                    MonthlyEmployerContributionCost = $"₱{dto.MonthlyEmpoyerContributionCost:#,#0.00}",
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
                    EmployeeSssShare = $"₱{x.EmployeeSssShare:#,#0.00}"    ,
                    EmployerPagibigShare = $"₱{x.EmployerPagibigShare:#,#0.00}",
                    EmployerPhilhealthShare = $"₱{x.EmployerPhilhealthShare:#,#0.00}",
                    EmployerSssShare = $"₱{x.EmployerSssShare:#,#0.00}",
                    IncomeTax = $"₱{x.IncomeTax:#,#0.00}",
                    OtherDeductions = $"₱{x.OtherDeductions:#,#0.00}",
                    TotalDeductions = $"₱{x.TotalDeductions:#,#0.00}",
                    Commissions = $"₱{x.Commissions:#,#0.00}",
                    NetSalary = $"₱{x.NetSalary:#,#0.00}",
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

        private async Task<TotalMonthlyReportDto> GetMonthlyReport(string date)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<TotalMonthlyReportDto>>($"{ApiEndpoint.Payroll.GetMonthlyReport}?date={date}");

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
