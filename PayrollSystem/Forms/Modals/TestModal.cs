using PayrollSystem.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PayrollSystem.Helpers.ApiEndpoint;

namespace PayrollSystem.Forms.Modals
{
    public partial class TestModal : Form
    {
        public TestModal()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void TestModal_Load(object sender, EventArgs e)
        {

            GenerateReport();
        }



        private void GenerateReport()
        {
            var payslips = new List<PayslipDto>
            {
                
            };
            var payslips2 = new List<PayslipDto>
            {

            };
            

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("PayslipDataset", payslips); // Match dataset name
            ReportDataSource rds2 = new ReportDataSource("PayslipDataset2", payslips2); // Match dataset name
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.DataSources.Add(rds2);

            reportViewer1.RefreshReport();
            
        }
    }
}
