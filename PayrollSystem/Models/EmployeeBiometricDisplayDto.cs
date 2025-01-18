using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class EmployeeBiometricDisplayDto
    {
        public Guid PersonalId { get; set; }

        public byte[] BiometricData { get; set; } = null!;

        public int? BiometricCount { get; set; }
    }

}
