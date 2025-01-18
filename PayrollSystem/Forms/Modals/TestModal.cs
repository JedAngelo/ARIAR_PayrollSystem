using PayrollSystem.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.Forms.Modals
{
    public partial class TestModal : Form
    {
        public TestModal()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void TestModal_Load(object sender, EventArgs e)
        {

            GenerateReport();
        }



        private void GenerateReport()
        {
            var data = new List<AttendanceSummaryDto>()
            {
                new AttendanceSummaryDto
                {
                    EmployeeCount = 1,
                    EmployeeName = "John Doe",
                    DailyAttendance = new List<DailyAttendanceSummary>
                    {
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-26", AttendanceDay = "Monday", AmStatus = "yes", PmStatus = "no" },
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-27", AttendanceDay = "Tuesday", AmStatus = "yes", PmStatus = "yes" },
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-28", AttendanceDay = "Wednesday", AmStatus = "yes", PmStatus = "no" },
                    },
                     TotalDays = 3
                },
                new AttendanceSummaryDto
                {
                    EmployeeCount = 2,
                    EmployeeName = "Jane Smith",
                    DailyAttendance = new List<DailyAttendanceSummary>
                    {
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-26", AttendanceDay = "Monday", AmStatus = "no", PmStatus = "no" },
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-27", AttendanceDay = "Tuesday", AmStatus = "yes", PmStatus = "yes" },
                    },
                    TotalDays = 2
                },
                 new AttendanceSummaryDto
                {
                    EmployeeCount = 3,
                    EmployeeName = "Peter Jones",
                    DailyAttendance = new List<DailyAttendanceSummary>
                    {
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-26", AttendanceDay = "Monday", AmStatus = "no", PmStatus = "no" },
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-27", AttendanceDay = "Tuesday", AmStatus = "no", PmStatus = "no" },
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-28", AttendanceDay = "Wednesday", AmStatus = "no", PmStatus = "no" },
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-29", AttendanceDay = "Thursday", AmStatus = "no", PmStatus = "no" }
                    },
                   TotalDays = 4
                },
                new AttendanceSummaryDto
                {
                    EmployeeCount = 4,
                    EmployeeName = "Mary Brown",
                    DailyAttendance = new List<DailyAttendanceSummary>
                    {
                        new DailyAttendanceSummary { AttendanceDate = "2024-10-26", AttendanceDay = "Monday", AmStatus = "yes", PmStatus = "yes" },
                    },
                    TotalDays = 1
                }
            };

            var dataFlat = data
            .SelectMany(x => x.DailyAttendance, (attendanceSummary, dailyAttendance) => new AttendanceSummaryFlat
            {
                EmployeeCount = attendanceSummary.EmployeeCount.ToString(),
                EmployeeName = attendanceSummary.EmployeeName,
                AttendanceDate = dailyAttendance.AttendanceDate,
                AttendanceDay = dailyAttendance.AttendanceDay,
                AmStatus = dailyAttendance.AmStatus,
                PmStatus = dailyAttendance.PmStatus,
                TotalDays = attendanceSummary.TotalDays.ToString()
            }).ToList();

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("AttendanceData", dataFlat); // Match dataset name
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
            
        }
    }
}
