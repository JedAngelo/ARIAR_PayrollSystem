using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class AttendanceDataLog
    {
        public string? Name { get; set; }
        public string? Log { get; set; }
        public string? Type { get; set; }
        public byte[] EmployeeImage { get; set; }

    }
}
