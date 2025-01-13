using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class TotalMonthlyReportFlat
    {
        public string Year { get; set; } = null!;
        public string Month { get; set; } = null!;

        // employee reports
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? Position { get; set; }

        public string TotalWorkDay { get; set; }
        public string Commissions { get; set; }
        public string GrossSalary { get; set; }

        public string EmployeeSssShare { get; set; }
        public string EmployeePhilhealthShare { get; set; }
        public string EmployeePagibigShare { get; set; }
        public string IncomeTax { get; set; }
        public string AbsentDeduction { get; set; }
        public string LateDeduction { get; set; }
        public string UndertimeDeduction { get; set; }
        public string OtherDeductions { get; set; }
        public string TotalDeductions { get; set; }

        public string EmployerSssShare { get; set; }
        public string EmployerPhilhealthShare { get; set; }
        public string EmployerPagibigShare { get; set; }

        public string NetSalary { get; set; }

        public string MonthlyEmployeePayrollCost { get; set; }
        public string MonthlyEmployerContributionCost { get; set; }
        public string MonthlyCompanyTotalCost { get; set; }

    }
}
