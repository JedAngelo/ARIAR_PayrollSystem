using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class AttendanceDisplayDto
    {
        public Guid PersonalId { get; set; }
        public string? Name { get; set; }
        public string? Log { get; set; }
        public string? Type { get; set; }
        public byte[] EmployeeImage { get; set; }


    }
}
