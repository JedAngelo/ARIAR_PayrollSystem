using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class DailyAttendanceSummary
    {
        public string AttendanceDate { get; set; }
        public string AttendanceDay { get; set; } = null!;
        public string AmStatus { get; set; } = null!;
        public string PmStatus { get; set; } = null!;
    }

}
