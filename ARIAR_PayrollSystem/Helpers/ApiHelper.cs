using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Helpers
{
    public static class ApiHelper
    {
        public static class Employee
        {
            public const string GetPersonalInfo = "/api/Employee/DisplayPersonalInfo";
            public const string AddOrUpdateEmployeeInfo = "/api/Employee/AddOrUpdateEmployeeInfo";
            public const string GetPersonalInfoById = "/api/Employee/DisplayPersonalInfoById/";
        }

        public static class Biometric
        {
            public const string AddBiometric = "/api/Biometric/AddBiometricData";
            public const string GetBiometric = "/api/Biometric/DisplayEmployeeBiometric";
        }

        public static class Attendance
        {
            public const string LogAttendance = "/api/Attendance/LogAttendance";
            public const string HasMorningIn = "/api/Attendance/HasMorningIn";
            public const string GetAttendanceLogShort = "/api/Attendance/GetAllAttendanceShort/";
            public const string GetLogCount = "/api/Attendance/GetLogCount/";
        }

        public static class Auth
        {
            public const string Login = "/api/UserAuthentication/Login";
        }

        public static class Payroll
        {
            // Define Payroll-related API endpoints here when needed
        }
    }



}
