﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class SystemSettingsDto
    {
        public int SettingsId { get; set; }

        // General settings
        //Attendance type: "IN/OUT" or "FULL"
        public string AttendanceType { get; set; } = null!;
        public string LateStartTimeMorning { get; set; }
        public string LateStartTimeAfternoon { get; set; }
        public string EarlyOutEndsMorning { get; set; }
        public string EarlyOutEndsAfternoon { get; set; }
        public string OvertimeStart { get; set; }
        public bool DeductLate { get; set; }
        public bool DeductUnderTime { get; set; }
        public string TTSVoice { get; set; } = null!;
        public decimal LateDeductionPerMinute { get; set; }
        public decimal UndertimeDeductionPerHour { get; set; }

    }

}
