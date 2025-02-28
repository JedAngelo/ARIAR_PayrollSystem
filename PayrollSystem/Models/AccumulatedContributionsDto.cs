using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class AccumulatedContributionsDto
    {
        public decimal? EmployerSssShare { get; set; }

        public decimal? EmployerPagibigShare { get; set; }

        public decimal? EmployerPhilhealthShare { get; set; }

        public decimal? EmployeeSssShare { get; set; }

        public decimal? EmployeePagibigShare { get; set; }

        public decimal? EmployeePhilhealthShare { get; set; }
    }
}
