﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class EmployeeBiometricsDto
    {
        public int? RecordId { get; set; } = 0;

        public Guid? PersonalId { get; set; }

        public byte[]? BiometricData { get; set; } = null!;

        public DateTime RecordDate { get; set; }
    }
}
