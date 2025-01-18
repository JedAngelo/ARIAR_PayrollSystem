using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class AttendanceSummaryDto
    {
        public int EmployeeCount { get; set; }
        public string EmployeeName { get; set; } = null!;
        public List<DailyAttendanceSummary> DailyAttendance { get; set; } = new List<DailyAttendanceSummary>();
        public decimal TotalDays { get; set; }
    }

}
