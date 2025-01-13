using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class EmployeeMonthlyReportDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? Position { get; set; }

        public decimal TotalWorkDay { get; set; }
        public decimal Commissions { get; set; }
        public decimal GrossSalary { get; set; }

        public decimal EmployeeSssShare { get; set; }
        public decimal EmployeePhilhealthShare { get; set; }
        public decimal EmployeePagibigShare { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal AbsentDeduction { get; set; }
        public decimal LateDeduction { get; set; }
        public decimal UndertimeDeduction { get; set; }
        public decimal OtherDeductions { get; set; }
        public decimal TotalDeductions { get; set; }

        public decimal EmployerSssShare { get; set; }
        public decimal EmployerPhilhealthShare { get; set; }
        public decimal EmployerPagibigShare { get; set; }

        public decimal NetSalary { get; set; }

    }

}
