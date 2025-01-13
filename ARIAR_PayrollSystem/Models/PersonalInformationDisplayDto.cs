using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class PersonalInformationDisplayDto
    {
        public Guid? PersonalId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string Suffix { get; set; } = null!;
        public string DateOfBirth { get; set; }
        public string Gender { get; set; } = null!;
        public string MaritalStatus { get; set; } = null!;
        public byte Age { get; set; }
        public byte[]? EmployeeImage { get; set; }

        //Contact
        public string Address { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;

        //Employment
        public string HireDate { get; set; }
        public decimal DailySalary { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal IncomeTaxRate { get; set; }
        public int PositionId { get; set; }
        public string PositionName { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
