using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class ContactInformation
    {
        public int ContactId { get; set; }

        public Guid PersonalId { get; set; }

        public string Address { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}
