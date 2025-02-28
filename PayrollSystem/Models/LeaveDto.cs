using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class LeaveDto
    {
        public int? LeaveId { get; set; }

        public Guid? PersonalId { get; set; }

        public string? StartDate { get; set; }

        public string? EndDate { get; set; }

        public bool IsSet { get; set; }
    }
}
