using PayrollSystem.Helpers;
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
    public partial class DateRangeModal : Form
    {
        private MainForm _mainForm;
        private Guid? _id;
        private bool _isAll;
        public DateRangeModal(MainForm mainForm, bool isAll, Guid? id = null)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _id = id;
            _isAll = isAll;
        }

        private void DateRangeModal_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            StartDatePicker.Value = now;
            EndDatePicker.Value = now;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_isAll)
                {
                    var attendanceModal = new AttendanceLogModal(_mainForm, StartDatePicker.Value, EndDatePicker.Value, (Guid)_id);
                    ControlsHelper.ShowModal(_mainForm, attendanceModal);
                }
                else
                {
                    var summaryReportModal = new AttendanceSummaryReportModal(_mainForm, StartDatePicker.Value, EndDatePicker.Value);
                    ControlsHelper.ShowModal(_mainForm, summaryReportModal);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
