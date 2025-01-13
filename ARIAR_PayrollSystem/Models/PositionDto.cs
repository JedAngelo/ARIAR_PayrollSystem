using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class PostionDto
    {
        #nullable enable
        public int? PositionId { get; set; }

        public string? PositionName { get; set; }

        public string? CreatedBy { get; set; }

        public string? CreatedDate { get; set; }

        public string? ModifiedBy { get; set; }

        public string? ModifiedDate { get; set; }

        //public virtual List<EmploymentDetail> EmploymentDetails { get; set; } = new List<EmploymentDetail>();
    }
}
