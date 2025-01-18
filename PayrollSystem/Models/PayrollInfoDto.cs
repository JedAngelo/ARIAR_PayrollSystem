using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class PayrollInfoDto
    {
        public string DateIssued { get; set; } = null!;
        public Guid PersonalId { get; set; }
        public string PayrollDate { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string DailySalary { get; set; } = null!;
        public string TotalWorkedDays { get; set; } = null!;
        public string Overtime { get; set; } = null!;
        public string BasicSalary { get; set; } = null!;
        public string Absence { get; set; } = null!;
        public string GrossSalary { get; set; } = null!;
        public string SSS { get; set; } = null!;
        public string PhilHealth { get; set; } = null!;
        public string PagIbig { get; set; } = null!;
        public string LateDeduction { get; set; } = null!;
        public string UndertimeDeduction { get; set; } = null!;
        public string TotalDeduction { get; set; } = null!;
        public string Commissions { get; set; } = null!;
        public string Other { get; set; } = null!;
        public string HolidayPayAdditions { get; set; } = null!;
        public string HolidayPayTotalDays { get; set; } = null!;
        public string PremiumPayAddtions { get; set; } = null!;
        public string PremiumTotalDays { get; set; } = null!;
        public string NetSalary { get; set; } = null!;
    }

}
