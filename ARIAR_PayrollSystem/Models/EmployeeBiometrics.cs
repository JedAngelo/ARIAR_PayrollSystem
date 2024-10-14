using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Models
{
    public class EmployeeBiometrics
    {
        public int? RecordId { get; set; } = 0;

        public Guid? PersonalId { get; set; }

        public byte[]? BiometricData { get; set; } = null!;

        public DateTime? RecordDate { get; set; }
    }
}
