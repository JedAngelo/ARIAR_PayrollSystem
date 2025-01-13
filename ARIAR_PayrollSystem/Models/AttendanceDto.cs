using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class AttendanceDto
    {
        #nullable enable
        public int? AttendanceId { get; set; }

        public Guid PersonalId { get; set; }

        public string? MorningIn { get; set; }

        public string? MorningOut { get; set; }

        public string? AfternoonIn { get; set; }

        public string? AfternoonOut { get; set; }

        public string? AttendanceDate { get; set; }

        public decimal? PayMultiplier { get; set; }

        public string? DayType { get; set; }

        public string? Status { get; set; }
        //public virtual PersonalInformationDto PersonalDtos { get; set; } = null!;
    }

}
