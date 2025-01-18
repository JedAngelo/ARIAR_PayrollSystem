using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class PayslipReportModal : Form
    {
        private List<PersonalInformationDisplayDto> _selectedEmployees = new List<PersonalInformationDisplayDto>();
        private List<PersonalInformationDisplayDto> _employees = new List<PersonalInformationDisplayDto>();
        private List<PayrollInfoDto> _payslips = new List<PayrollInfoDto>();
        private string _date;
        public List<PersonalInformationDisplayDto> SelectedEmployees
        {
            get { return _selectedEmployees; }
            set
            {
                _selectedEmployees = value;
                
            }
        }


        public PayslipReportModal(List<PersonalInformationDisplayDto> employees, string date)
        {
            InitializeComponent();
            _employees = employees;
            _date = date;
            ReportViewer.LocalReport.ReportEmbeddedResource = "PayrollSystem.Reports.WeeklyPayslip.rdlc";
        }

        private void PayslipReportModal_Load(object sender, EventArgs e)
        {
            _ = GetPayslipData();            
        }

        private async Task GetPayslipData()
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<PayrollInfoDto>>>($"{ApiEndpoint.Payroll.GeneratePayslips}?payrollDate={_date}");

                if (apiData == null) throw new HttpRequestException("No paylips returned");

                if (apiData.isSuccess)
                {
                    _payslips = apiData.Data;
                    ToastNotify.Success("Payslips generated successfully");
                    var employeeWithPay = _payslips.Select(x => x.PersonalId).ToHashSet();
                    await EmployeeShortView3.DataViewAsync(this, _employees.Where(x => employeeWithPay.Contains((Guid)x.PersonalId)).ToList(), EmployeeView);
                }
                else
                {
                    Console.WriteLine(apiData.ErrorMessage);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private async Task LoadReport(List<PayrollInfoDto> data)
        {
            try
            {
                await Task.Run(() =>
                {
                    BeginInvoke((Action)(() =>
                    {
                        ReportViewer.LocalReport.DataSources.Clear();
                        ReportDataSource rds = new ReportDataSource("Payslip", data); // Match dataset name
                        ReportViewer.LocalReport.DataSources.Add(rds);
                        ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                        ReportViewer.ZoomMode = ZoomMode.PageWidth;
                        ReportViewer.RefreshReport();
                    }));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void LoadButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(350);
            var selectedId = _selectedEmployees.Select(x => x.PersonalId).ToHashSet();
            await LoadReport(_payslips.Where(x => selectedId.Contains(x.PersonalId)).OrderBy(a => a.EmployeeName).ToList());
        }
        public async void RemoveSelected()
        {
            var controls = EmployeeView.Controls.OfType<EmployeeShortView3>().Where(x => x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.Selected = false;
                }
            });


        }

        public async void SelectAll()
        {
            var controls = EmployeeView.Controls.OfType<EmployeeShortView3>().Where(x => !x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.Selected = true;
                }
            });
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }
    }
}
