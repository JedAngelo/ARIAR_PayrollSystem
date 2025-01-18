using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class TotalYearlyReportDto
    {
        public string Year { get; set; } = null!;
        public decimal YTDGrossSalary { get; set; }
        public decimal YTDNetSalaryPaid { get; set; }
        public decimal YTDTotalEmployerSssCost { get; set; }
        public decimal YTDTotalEmployerPhilhealthCost { get; set; }
        public decimal YTDTotalEmployerPagibigCost { get; set; }
        public decimal YTDTotalEmployeesSss { get; set; }
        public decimal YTDTotalEmployeesPhilhealth { get; set; }
        public decimal YTDTotalEmployeesPagibig { get; set; }
        public decimal YTDIncomeTaxCost { get; set; }
        public decimal YTDTotalCompanyPayrollCost { get; set; }
        public List<TotalMonthlyReportDto> TotalMonthlyReports { get; set; } = new List<TotalMonthlyReportDto>();

    }

}
