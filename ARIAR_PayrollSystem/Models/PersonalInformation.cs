using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class PersonalInformation
    {
        public Guid? PersonalId { get; set; }

        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; } = null!;

        public byte Age { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;



        public bool IsActive { get; set; }


        public DateTime? ModifiedDate { get; set; }

        public string? ModifiedBy { get; set; }


        public virtual List<ContactInformation> ContactInformationDtos { get; set; } = new List<ContactInformation>();

        //public virtual List<EmployeeBiometric> EmployeeBiometrics { get; set; } = new List<EmployeeBiometric>();

        public virtual List<EmploymentDetail> EmploymentDetailDtos { get; set; } = new List<EmploymentDetail>();
    }
}
