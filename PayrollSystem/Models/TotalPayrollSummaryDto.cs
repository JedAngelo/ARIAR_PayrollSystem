using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class TotalPayrollSummaryDto
    {
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public decimal TotalEmployeePayrollCost { get; set; }
        public decimal TotalEmpoyerContributionCost { get; set; }//TODO RENAME
        public decimal TotalCompanyTotalCost { get; set; }
        public List<PayrollSummaryReportDto> EmployeeSummaryReports { get; set; } = new List<PayrollSummaryReportDto>();


    }

}
