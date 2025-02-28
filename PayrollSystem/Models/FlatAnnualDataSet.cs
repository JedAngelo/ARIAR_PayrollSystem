using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public  class FlatAnnualDataSet
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
