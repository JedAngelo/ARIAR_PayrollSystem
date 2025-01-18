using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class TotalMonthlyReportDto
    {
        public string Year { get; set; } = null!;
        public string Month { get; set; } = null!;
        public decimal MonthlyEmployeePayrollCost { get; set; }
        public decimal MonthlyEmpoyerContributionCost { get; set; }
        public decimal MonthlyCompanyTotalCost { get; set; }
        public List<EmployeeMonthlyReportDto> EmployeeMonthlyReports { get; set; } = new List<EmployeeMonthlyReportDto>();


    }

}
