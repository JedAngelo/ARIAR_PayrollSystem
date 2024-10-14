using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Helpers
{
    public static class ApiHelper
    {
        public const string ApiGetPersonalInfo = "/api/Employee/DisplayPersonalInfo";
        public const string ApiAddEmployeeInfo = "/api/Employee/AddOrUpdateEmployeeInfo";
        public const string ApiLogin = "/api/UserAuthentication/Login";
        public const string ApiAddBiometric = "/api/Biometric/AddBiometricData";
        public const string ApiGetBiometric = "/api/Biometric/DisplayEmployeeBiometric";


    }
}
