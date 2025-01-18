using PayrollSystem.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class ReportModal : Form
    {
        private List<AttendanceDto> _data;
        public ReportModal(List<AttendanceDto> data)
        {
            InitializeComponent();
            _data = data;
        }

        private async void ReportModal_Load(object sender, EventArgs e)
        {
            await Task.Run(() => BeginInvoke((Action)(() => LoadReport(_data))));            
        }

        private void LoadReport(List<AttendanceDto> data)
        {
            try
            {
                var reportData = new ReportDataSource("AttendanceLog", data);
                ReportViewer.LocalReport.DataSources.Clear();
                ReportViewer.LocalReport.DataSources.Add(reportData);
                //ReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                ReportViewer.ZoomMode = ZoomMode.PageWidth;
                this.ReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
