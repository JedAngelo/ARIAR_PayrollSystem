using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Helpers
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
            public const string AddPositions = "/api/Employee/AddOrUpdatePosition";
            public const string DeletePosition = "/api/Employee/DeletePosition";
            public const string DeleteEmployee = "/api/Employee/DeleteEmployee";
        }

        public static class Biometric
        {
            public const string AddBiometric = "/api/Biometric/AddBiometricData";
            public const string GetBiometric = "/api/Biometric/DisplayEmployeeBiometric";
            public const string GetBiometricsById = "/api/Biometric/GetBiometricsById";
            public const string DeleteBiometricById = "/api/Biometric/DeleteBiometricById";

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
            public const string AddOrUpdateLeave = "/api/Attendance/AddOrUpdateLeave";
            public const string DeleteLeave = "/api/Attendance/DeleteLeave";
            public const string GetAttendanceByDateAndId = "/api/Attendance/GetAttendanceByDateAndId";
            public const string GetAttendanceByDateRangeAndId = "/api/Attendance/GetAttendanceByDateRangeAndId";
            public const string GetAttendanceSummary = "/api/Attendance/GetAttendanceSummary";
            public const string UpdatePayrollMultiplier = "/api/Attendance/UpdatePayrollMultiplier";
            public const string GetAttendanceDayType = "/api/Attendance/GetAttendanceDayType";
            ///api/Attendance/GetAttendanceDayType?date=2025-01-16
        }

        public static class Auth
        {
            public const string Login = "/api/UserAuthentication/Login";
            public const string GetUsers = "/api/UserAuthentication/DisplayUsers";
            public const string RegisterUser = "/api/UserAuthentication/RegisterUser";
            public const string UpdateUserInfo = "/api/UserAuthentication/UpdateUserInfo";
            public const string DeleteUser = "/api/UserAuthentication/DeleteUser";
        }

        public static class Payroll
        {
            // Define Payroll-related API endpoints here when needed
            public const string CalculatePayroll = "/api/Payroll/CalculatePayroll";
            public const string AddOthers = "/api/Payroll/AddOthers";
            public const string GetPayrolls = "/api/Payroll/GetPayrolls";
            public const string GetPayrollById = "/api/Payroll/GetPayrollById/";
            public const string GeneratePayslips = "/api/Payroll/GeneratePayslips";
            public const string GetMonthlyReport = "/api/Payroll/GetSummaryReport";
            public const string GetAnnualReport = "/api/Payroll/GetAnnualReport";
            public const string GetAccumulatedContributions = "/api/Payroll/GetAccumulatedContributions";
        }

        public static class Settings
        {
            public const string GetSettings = "/api/Settings/GetSettings";
            public const string UpdateSettings = "/api/Settings/UpdateSettings";
        }
    }



}
