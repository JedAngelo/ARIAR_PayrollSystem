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
        private List<PayslipDto> _payslips = new List<PayslipDto>();
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
            ReportViewer.LocalReport.ReportEmbeddedResource = "PayrollSystem.Reports.PayslipTemplate.rdlc";
        }

        private void PayslipReportModal_Load(object sender, EventArgs e)
        {
            _ = GetPayslipData();            
        }

        private async Task GetPayslipData()
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<PayslipDto>>>($"{ApiEndpoint.Payroll.GeneratePayslips}?payrollDate={_date}");

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
        private async Task LoadReport(List<PayslipDto> data)
        {
            try
            {
                await Task.Run(() =>
                {
                    BeginInvoke((Action)(() =>
                    {
                        ReportViewer.LocalReport.DataSources.Clear();
                        int total = data.Count;
                        var data1 = new List<PayslipDto>();
                        var data2 = new List<PayslipDto>();
                        if (total > 1)
                        {
                            int first = total % 2 == 0 ? total / 2 : (total / 2) + 1;
                            data1 = data.Take(first).ToList();
                            data2 = data.Skip(first).ToList();

                        }
                        else
                        {
                            data1 = data;
                        }

                        ReportDataSource rds = new ReportDataSource("Payslip1", data1); // Match dataset name
                        ReportDataSource rds2 = new ReportDataSource("Payslip2", data2); // Match dataset name
                        ReportViewer.LocalReport.DataSources.Add(rds);
                        ReportViewer.LocalReport.DataSources.Add(rds2);
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
