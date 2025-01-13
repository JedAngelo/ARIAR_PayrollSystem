using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class PayslipDto
    {
        public Guid PersonalId { get; set; }
        public string PayrollDate { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string RegularWage { get; set; } = null!;
        public string Overtime { get; set; } = null!;
        public string Wage { get; set; } = null!;
        public string Absence { get; set; } = null!;
        public string TotalWage { get; set; } = null!;
        public string SSS { get; set; } = null!;
        public string PhilHealth { get; set; } = null!;
        public string PagIbig { get; set; } = null!;
        public string LateDeduction { get; set; } = null!;
        public string UndertimeDeduction { get; set; } = null!;
        public string TotalDeduction { get; set; } = null!;
        public string Commissions { get; set; } = null!;
        public string Other { get; set; } = null!;
        public string NetAmount { get; set; } = null!;
        public string RemainingBalance { get; set; } = null!;
    }

}
