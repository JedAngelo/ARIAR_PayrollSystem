using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class EmploymentDetailDto
    {
        public int? EmploymentId { get; set; }

        public Guid PersonalId { get; set; }

        public int PositionId { get; set; }

        public string HireDate { get; set; }

        public decimal DailySalary { get; set; }

        public decimal BasicSalary { get; set; }


        //public virtual PersonalInformationDto PersonalDtos { get; set; } = null!;

        //public virtual PostionDto PositionDtos { get; set; } = new PostionDto();
    }
}
