using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms
{
    public partial class PayrollCalculationDetails : Form
    {
        private PayrollDto _payroll;
        private PersonalInformationDisplayDto _employeeData;

        public PayrollCalculationDetails(PayrollDto payroll, PersonalInformationDisplayDto employeeData)
        {
            InitializeComponent();
            _payroll = payroll;
            _employeeData = employeeData;
        }

        private async void PayrollCalculationDetails_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                await Task.Run(() =>
                {
                    BeginInvoke((Action)(() =>
                    {
                        (MonthlySalary.Text, PagibigSalary.Text, PhilhealthSalary.Text) = (_employeeData.BasicSalary.ToString("F"), _employeeData.BasicSalary.ToString("F"), _employeeData.BasicSalary.ToString("F"));
                        PhilhealthTotal.Text = $"{_payroll.EmployeePhilhealthShare * 8:F}";
                        (EmpPhilhealthRaw1.Text, EmpPhilhealthRaw2.Text) = ($"{(_payroll.EmployeePhilhealthShare * 8) / 2:F}", $"{(_payroll.EmployeePhilhealthShare * 8) / 2:F}");
                        EmpWeeklyPhilhealth.Text = $"{_payroll.EmployeePhilhealthShare:F}";
                        (PagIbigContribution.Text, WeeklyPagIbigContribution.Text) = ($"{_payroll.EmployeePagibigShare * 4:F}", $"{_payroll.EmployeePagibigShare:F}");
                        (SssLowerLimit.Text, SssUpperLimit.Text, SssMsc.Text, SssEmpShare.Text, SssEmprShare.Text) = ($"{CalculateSSSEmployeeContribution(_employeeData.BasicSalary).LowerLimit:F}", $"{CalculateSSSEmployeeContribution(_employeeData.BasicSalary).UpperLimit:F}", $"{CalculateSSSEmployeeContribution(_employeeData.BasicSalary).MonthlySalaryCredit:F}", $"{CalculateSSSEmployeeContribution(_employeeData.BasicSalary).EmployeeShare:F}", $"{CalculateSSSEmployeeContribution(_employeeData.BasicSalary).EmployerShare:F}");
                        (WeeklySssEmpShare.Text, WeeklySssEmprShare.Text) = ($"{_payroll.EmployeeSssShare:F}", $"{_payroll.EmployerSssShare:F}");
                    }));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static SssMonthlyCredit CalculateSSSEmployeeContribution(decimal monthlySalary)
        {
            var result = new SssMonthlyCredit();
            foreach (var sssBracket in SssTable)
            {
                if (monthlySalary >= sssBracket.LowerLimit && monthlySalary <= sssBracket.UpperLimit)
                {
                    result = sssBracket;
                    break;
                }
            }

            return result;
        }

        public static List<SssMonthlyCredit> SssTable { get; } = new List<SssMonthlyCredit>()
        {
            new SssMonthlyCredit { Id = 1, LowerLimit = 0, UpperLimit = 4249.99m, MonthlySalaryCredit = 4000, EmployeeShare = 180.00m, EmployerShare = 380.00m + 10.00m },
            new SssMonthlyCredit { Id = 2, LowerLimit = 4250, UpperLimit = 4749.99m, MonthlySalaryCredit = 4500, EmployeeShare = 202.50m, EmployerShare = 427.50m + 10.00m },
            new SssMonthlyCredit { Id = 3, LowerLimit = 4750, UpperLimit = 5249.99m, MonthlySalaryCredit = 5000, EmployeeShare = 225.00m, EmployerShare = 475.00m + 10.00m },
            new SssMonthlyCredit { Id = 4, LowerLimit = 5250, UpperLimit = 5749.99m, MonthlySalaryCredit = 5500, EmployeeShare = 247.50m, EmployerShare = 522.50m + 10.00m },
            new SssMonthlyCredit { Id = 5, LowerLimit = 5750, UpperLimit = 6249.99m, MonthlySalaryCredit = 6000, EmployeeShare = 270.00m, EmployerShare = 570.00m + 10.00m },
            new SssMonthlyCredit { Id = 6, LowerLimit = 6250, UpperLimit = 6749.99m, MonthlySalaryCredit = 6500, EmployeeShare = 292.50m, EmployerShare = 617.50m + 10.00m },
            new SssMonthlyCredit { Id = 7, LowerLimit = 6750, UpperLimit = 7249.99m, MonthlySalaryCredit = 7000, EmployeeShare = 315.00m, EmployerShare = 665.00m + 10.00m },
            new SssMonthlyCredit { Id = 8, LowerLimit = 7250, UpperLimit = 7749.99m, MonthlySalaryCredit = 7500, EmployeeShare = 337.50m, EmployerShare = 712.50m + 10.00m },
            new SssMonthlyCredit { Id = 9, LowerLimit = 7750, UpperLimit = 8249.99m, MonthlySalaryCredit = 8000, EmployeeShare = 360.00m, EmployerShare = 760.00m + 10.00m },
            new SssMonthlyCredit { Id = 10, LowerLimit = 8250, UpperLimit = 8749.99m, MonthlySalaryCredit = 8500, EmployeeShare = 382.50m, EmployerShare = 807.50m + 10.00m },
            new SssMonthlyCredit { Id = 11, LowerLimit = 8750, UpperLimit = 9249.99m, MonthlySalaryCredit = 9000, EmployeeShare = 405.00m, EmployerShare = 855.00m + 10.00m },
            new SssMonthlyCredit { Id = 12, LowerLimit = 9250, UpperLimit = 9749.99m, MonthlySalaryCredit = 9500, EmployeeShare = 427.50m, EmployerShare = 902.50m + 10.00m },
            new SssMonthlyCredit { Id = 13, LowerLimit = 9750, UpperLimit = 10249.99m, MonthlySalaryCredit = 10000, EmployeeShare = 450.00m, EmployerShare = 950.00m + 10.00m },
            new SssMonthlyCredit { Id = 14, LowerLimit = 10250, UpperLimit = 10749.99m, MonthlySalaryCredit = 10500, EmployeeShare = 472.50m, EmployerShare = 997.50m + 10.00m },
            new SssMonthlyCredit { Id = 15, LowerLimit = 10750, UpperLimit = 11249.99m, MonthlySalaryCredit = 11000, EmployeeShare = 495.00m, EmployerShare = 1045.00m + 10.00m },
            new SssMonthlyCredit { Id = 16, LowerLimit = 11250, UpperLimit = 11749.99m, MonthlySalaryCredit = 11500, EmployeeShare = 517.50m, EmployerShare = 1092.50m + 10.00m },
            new SssMonthlyCredit { Id = 17, LowerLimit = 11750, UpperLimit = 12249.99m, MonthlySalaryCredit = 12000, EmployeeShare = 540.00m, EmployerShare = 1140.00m + 10.00m },
            new SssMonthlyCredit { Id = 18, LowerLimit = 12250, UpperLimit = 12749.99m, MonthlySalaryCredit = 12500, EmployeeShare = 562.50m, EmployerShare = 1187.50m + 10.00m },
            new SssMonthlyCredit { Id = 19, LowerLimit = 12750, UpperLimit = 13249.99m, MonthlySalaryCredit = 13000, EmployeeShare = 585.00m, EmployerShare = 1235.00m + 10.00m },
            new SssMonthlyCredit { Id = 20, LowerLimit = 13250, UpperLimit = 13749.99m, MonthlySalaryCredit = 13500, EmployeeShare = 607.50m, EmployerShare = 1282.50m + 10.00m },
            new SssMonthlyCredit { Id = 21, LowerLimit = 13750, UpperLimit = 14249.99m, MonthlySalaryCredit = 14000, EmployeeShare = 630.00m, EmployerShare = 1330.00m + 10.00m },
            new SssMonthlyCredit { Id = 22, LowerLimit = 14250, UpperLimit = 14749.99m, MonthlySalaryCredit = 14500, EmployeeShare = 652.50m, EmployerShare = 1377.50m + 10.00m },
            new SssMonthlyCredit { Id = 23, LowerLimit = 14750, UpperLimit = 15249.99m, MonthlySalaryCredit = 15000, EmployeeShare = 675.00m, EmployerShare = 1425.00m + 30.00m },
            new SssMonthlyCredit { Id = 24, LowerLimit = 15250, UpperLimit = 15749.99m, MonthlySalaryCredit = 15500, EmployeeShare = 697.50m, EmployerShare = 1472.50m + 30.00m },
            new SssMonthlyCredit { Id = 25, LowerLimit = 15750, UpperLimit = 16249.99m, MonthlySalaryCredit = 16000, EmployeeShare = 720.00m, EmployerShare = 1520.00m + 30.00m },
            new SssMonthlyCredit { Id = 26, LowerLimit = 16250, UpperLimit = 16749.99m, MonthlySalaryCredit = 16500, EmployeeShare = 742.50m, EmployerShare = 1567.50m + 30.00m },
            new SssMonthlyCredit { Id = 27, LowerLimit = 16750, UpperLimit = 17249.99m, MonthlySalaryCredit = 17000, EmployeeShare = 765.00m, EmployerShare = 1615.00m + 30.00m },
            new SssMonthlyCredit { Id = 28, LowerLimit = 17250, UpperLimit = 17749.99m, MonthlySalaryCredit = 17500, EmployeeShare = 787.50m, EmployerShare = 1662.50m + 30.00m },
            new SssMonthlyCredit { Id = 29, LowerLimit = 17750, UpperLimit = 18249.99m, MonthlySalaryCredit = 18000, EmployeeShare = 810.00m, EmployerShare = 1710.00m + 30.00m },
            new SssMonthlyCredit { Id = 30, LowerLimit = 18250, UpperLimit = 18749.99m, MonthlySalaryCredit = 18500, EmployeeShare = 832.50m, EmployerShare = 1757.50m + 30.00m },
            new SssMonthlyCredit { Id = 31, LowerLimit = 18750, UpperLimit = 19249.99m, MonthlySalaryCredit = 19000, EmployeeShare = 855.00m, EmployerShare = 1805.00m + 30.00m },
            new SssMonthlyCredit { Id = 32, LowerLimit = 19250, UpperLimit = 19749.99m, MonthlySalaryCredit = 19500, EmployeeShare = 877.50m, EmployerShare = 1852.50m + 30.00m },
            new SssMonthlyCredit { Id = 33, LowerLimit = 19750, UpperLimit = 20249.99m, MonthlySalaryCredit = 20000, EmployeeShare = 900.00m, EmployerShare = 1930.00m + 30.00m },
            new SssMonthlyCredit { Id = 34, LowerLimit = 20250, UpperLimit = 20749.99m, MonthlySalaryCredit = 20500, EmployeeShare = 922.50m, EmployerShare = 1930.00m + 70.00m},
            new SssMonthlyCredit { Id = 35, LowerLimit = 20750, UpperLimit = 21249.99m, MonthlySalaryCredit = 21000, EmployeeShare = 945.00m, EmployerShare = 1930.00m + 140.00m },
            new SssMonthlyCredit { Id = 36, LowerLimit = 21250, UpperLimit = 21749.99m, MonthlySalaryCredit = 21500, EmployeeShare = 967.50m, EmployerShare = 1930.00m + 210.00m },
            new SssMonthlyCredit { Id = 37, LowerLimit = 21750, UpperLimit = 22249.99m, MonthlySalaryCredit = 22000, EmployeeShare = 990.00m, EmployerShare = 1930.00m + 280.00m },
            new SssMonthlyCredit { Id = 38, LowerLimit = 22250, UpperLimit = 22749.99m, MonthlySalaryCredit = 22500, EmployeeShare = 1012.50m, EmployerShare = 1930.00m + 350.00m },
            new SssMonthlyCredit { Id = 39, LowerLimit = 22750, UpperLimit = 23249.99m, MonthlySalaryCredit = 23000, EmployeeShare = 1035.00m, EmployerShare = 1930.00m + 420.00m },
            new SssMonthlyCredit { Id = 40, LowerLimit = 23250, UpperLimit = 23749.99m, MonthlySalaryCredit = 23500, EmployeeShare = 1057.50m, EmployerShare = 1930.00m + 490.00m },
            new SssMonthlyCredit { Id = 41, LowerLimit = 23750, UpperLimit = 24249.99m, MonthlySalaryCredit = 24000, EmployeeShare = 1080.00m, EmployerShare = 1930.00m + 560.00m },
            new SssMonthlyCredit { Id = 42, LowerLimit = 24250, UpperLimit = 24749.99m, MonthlySalaryCredit = 24500, EmployeeShare = 1102.50m, EmployerShare = 1930.00m + 630.00m },
            new SssMonthlyCredit { Id = 43, LowerLimit = 24750, UpperLimit = 25249.99m, MonthlySalaryCredit = 25000, EmployeeShare = 1125.00m, EmployerShare = 1930.00m + 700.00m },
            new SssMonthlyCredit { Id = 44, LowerLimit = 25250, UpperLimit = 25749.99m, MonthlySalaryCredit = 25500, EmployeeShare = 1147.50m, EmployerShare = 1930.00m + 770.00m },
            new SssMonthlyCredit { Id = 45, LowerLimit = 25750, UpperLimit = 26249.99m, MonthlySalaryCredit = 26000, EmployeeShare = 1170.00m, EmployerShare = 1930.00m + 840.00m },
            new SssMonthlyCredit { Id = 46, LowerLimit = 26250, UpperLimit = 26749.99m, MonthlySalaryCredit = 26500, EmployeeShare = 1192.50m, EmployerShare = 1930.00m + 910.00m },
            new SssMonthlyCredit { Id = 47, LowerLimit = 26750, UpperLimit = 27249.99m, MonthlySalaryCredit = 27000, EmployeeShare = 1215.00m, EmployerShare = 1930.00m + 980.00m },
            new SssMonthlyCredit { Id = 48, LowerLimit = 27250, UpperLimit = 27749.99m, MonthlySalaryCredit = 27500, EmployeeShare = 1237.50m, EmployerShare = 1930.00m + 1050.00m },
            new SssMonthlyCredit { Id = 49, LowerLimit = 27750, UpperLimit = 28249.99m, MonthlySalaryCredit = 28000, EmployeeShare = 1260.00m, EmployerShare = 1930.00m + 1120.00m },
            new SssMonthlyCredit { Id = 50, LowerLimit = 28250, UpperLimit = 28749.99m, MonthlySalaryCredit = 28500, EmployeeShare = 1282.50m, EmployerShare = 1930.00m + 1190.00m },
            new SssMonthlyCredit { Id = 51, LowerLimit = 28750, UpperLimit = 29249.99m, MonthlySalaryCredit = 29000, EmployeeShare = 1305.00m, EmployerShare = 1930.00m + 1260.00m },
            new SssMonthlyCredit { Id = 52, LowerLimit = 29250, UpperLimit = decimal.MaxValue, MonthlySalaryCredit = 30000, EmployeeShare = 1350.00m, EmployerShare = 1930.00m + 1400.00m }
        };

    }
}
