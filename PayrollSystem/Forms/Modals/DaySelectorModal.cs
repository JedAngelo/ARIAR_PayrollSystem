using PayrollSystem.Helpers;
using PayrollSystem.Models;
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
    public partial class DaySelectorModal : Form
    {
        private string _date;
        public DaySelectorModal(string date)
        {
            InitializeComponent();
            _date = date;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var dto = new AttendanceDto
            {
                PayMultiplier = Decimal.Parse(MultiplierTextBox.Text),
                DayType = DayType.Text,
                AttendanceDate = _date
            };
            await UpdateDayType(dto);
        }

        private async Task UpdateDayType(AttendanceDto dto)
        {
            try
            {
                var apiPut = await HttpHelper.PutAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Attendance.UpdatePayrollMultiplier, dto);

                if (apiPut == null) throw new HttpRequestException("Error updating day type");

                if (apiPut.isSuccess)
                {
                    ToastNotify.Success(apiPut.Data);
                }
                else
                {
                    ToastNotify.Warning(apiPut.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
