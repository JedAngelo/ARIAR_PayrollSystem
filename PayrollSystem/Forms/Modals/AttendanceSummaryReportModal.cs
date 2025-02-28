using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
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
using System.Web;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class AttendanceSummaryReportModal : Form
    {
        private MainForm _mainForm;
        private DateTime _startDate;
        private DateTime _endDate;
        public AttendanceSummaryReportModal(MainForm mainForm, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _startDate = startDate;
            _endDate = endDate;
        }

        private async void AttendanceSummaryReportModal_Load(object sender, EventArgs e)
        {
            await GetAttendanceSummary(_startDate.ToString("yyyy-MM-dd"), _endDate.ToString("yyyy-MM-dd"));
            DateLabel.Text = $"ATTENDANCE RECORD FOR:    {_startDate.ToString("MMMM d, yyyy").ToUpper()} - {_endDate.ToString("MMMM d, yyyy").ToUpper()}";
        }

        private async Task GetAttendanceSummary(string start, string end)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<AttendanceSummaryDto>>>($"{ApiEndpoint.Attendance.GetAttendanceSummary}?start={start}&end={end}");

                if (apiData == null) throw new HttpRequestException("Can't retrieve attendance summary");

                if (apiData.isSuccess)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(apiData.Data, Formatting.Indented));

                    var attendanceSummary = apiData.Data.SelectMany(x => x.DailyAttendance, (attendanceSummary, dailyAttendance) => new AttendanceSummaryFlat
                    {
                        EmployeeCount = attendanceSummary.EmployeeCount.ToString(),
                        EmployeeName = attendanceSummary.EmployeeName,
                        AttendanceDate = DateOnly.ParseExact(dailyAttendance.AttendanceDate, "yyyy-MM-dd").ToString("MM/dd/yyyy"),
                        AttendanceDay = dailyAttendance.AttendanceDay,
                        AmStatus = dailyAttendance.AmStatus,
                        PmStatus = dailyAttendance.PmStatus,
                        TotalDays = attendanceSummary.TotalDays.ToString("F1")
                    }).ToList();

                    await Task.Run(() =>
                    {
                        BeginInvoke((Action)(() =>
                        {
                            ReportViewer.LocalReport.DataSources.Clear();
                            ReportDataSource rds = new ReportDataSource("AttendanceData", attendanceSummary); // Match dataset name
                            ReportViewer.LocalReport.DataSources.Add(rds);
                            //ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                            ReportViewer.ZoomMode = ZoomMode.PageWidth;
                            this.ReportViewer.RefreshReport();
                        }));
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
