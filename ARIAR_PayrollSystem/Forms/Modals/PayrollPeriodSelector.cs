using ARIAR_PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms.Modals
{
    public partial class PayrollPeriodSelector : Form
    {
        private DateTime _currentDate = DateTime.Now;
        private PayrollCalclulation _parent;


        public PayrollPeriodSelector(PayrollCalclulation parent)
        {
            InitializeComponent();
            var daysCount = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            EndDatePicker.Value = DateTime.Now;
            StartDatePicker.Value = DateTime.Now.AddDays(-DateTime.Now.Day + 1);
            _parent = parent;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _parent.PayrollDateRange = new DateRangeDto
            {
                StartDate = StartDatePicker.Value.Date.ToString("yyyy-MM-dd"),
                EndDate = EndDatePicker.Value.Date.ToString("yyyy-MM-dd"),
            };
            this.Close();
        }

    }

}
