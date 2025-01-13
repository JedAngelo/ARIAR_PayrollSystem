using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class SystemSettingsDto
    {
        public int SettingsId { get; set; }

        // General settings
        //Attendance type: "IN/OUT" or "FULL"
        public string AttendanceType { get; set; } = null!;
        public bool PasswordlessManualAttendance { get; set; }
        public string LateStartTimeMorning { get; set; }
        public string LateStartTimeAfternoon { get; set; }
        public string EarlyOutEndsMorning { get; set; }
        public string EarlyOutEndsAfternoon { get; set; }
    }

}
