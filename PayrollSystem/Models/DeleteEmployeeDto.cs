using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class DeleteEmployeeDto
    {
        public Guid PersonalId { get; set; }
        public bool? IsDeleted { get; set; }
        public string? DeletedBy { get; set; }
    }
}
