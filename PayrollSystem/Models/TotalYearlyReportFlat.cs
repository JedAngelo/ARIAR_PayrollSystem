using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class TotalYearlyReportFlat
    {
        public string Year { get; set; } = null!;
        public string Month { get; set; } = null!;
        public string YTDGrossSalary { get; set; }
        public string YTDNetSalaryPaid { get; set; }
        public string YTDTotalEmployerSssCost { get; set; }
        public string YTDTotalEmployerPhilhealthCost { get; set; }
        public string YTDTotalEmployerPagibigCost { get; set; }
        public string YTDTotalEmployeesSss { get; set; }
        public string YTDTotalEmployeesPhilhealth { get; set; }
        public string YTDTotalEmployeesPagibig { get; set; }
        public string YTDIncomeTaxCost { get; set; }
        public string YTDTotalCompanyPayrollCost { get; set; }

        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;

        // employee reports
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? Position { get; set; }

        public string TotalWorkDay { get; set; }
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
        public string PremiumPayTotalDays { get; set; }
        public string HolidayPayTotalDays { get; set; }

        public string TotalEmployeePayrollCost { get; set; }
        public string TotalEmployerContributionCost { get; set; }
        public string TotalCompanyTotalCost { get; set; }

    }
}
