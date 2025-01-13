using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARIAR_PayrollSystem.Helpers
{
    public static class ApiEndpoint
    {
        public static class Employee
        {
            public const string GetPersonalInfo = "/api/Employee/DisplayPersonalInfo";
            public const string AddOrUpdateEmployeeInfo = "/api/Employee/AddOrUpdateEmployeeInfo";
            public const string GetPersonalInfoById = "/api/Employee/DisplayPersonalInfoById/";
            public const string GetPersonalInfoRaw = "/api/Employee/DisplayPersonalInfoRaw/";
            public const string GetPositions = "/api/Employee/DisplayPositions";
            public const string AddPositions = "/api/Employee/AddPosition";
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
            public const string GetAttendanceLogs = "/api/Attendance/GetAttendanceLogs/";
            public const string GetLogCount = "/api/Attendance/GetLogCount/";
            public const string GetLogCountById = "/api/Attendance/GetLogCountById/";
            public const string GetAttendanceById = "/api/Attendance/GetAttendanceById";
            public const string GetAttendanceByDate = "/api/Attendance/GetAttendanceByDate";
            public const string UpdateAttendanceLog = "/api/Attendance/UpdateAttendanceLog";
        }

        public static class Auth
        {
            public const string Login = "/api/UserAuthentication/Login";
        }

        public static class Payroll
        {
            // Define Payroll-related API endpoints here when needed
            public const string CalculatePayroll = "/api/Payroll/CalculatePayroll";
            public const string AddOthers = "/api/Payroll/AddOthers";
            public const string GetPayrolls = "/api/Payroll/GetPayrolls";
            public const string GetPayrollById = "/api/Payroll/GetPayrollById/";
            public const string GeneratePayslips = "/api/Payroll/GeneratePayslips";
            public const string GetMonthlyReport = "/api/Payroll/GetMonthlyReport";
            public const string GetAnnualReport = "/api/Payroll/GetAnnualReport";
        }

        public static class Settings
        {
            public const string GetSettings = "/api/Settings/GetSettings";
            public const string UpdateSettings = "/api/Settings/UpdateSettings";
        }
    }



}
