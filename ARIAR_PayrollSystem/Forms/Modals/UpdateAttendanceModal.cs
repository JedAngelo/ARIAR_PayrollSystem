using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
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

namespace ARIAR_PayrollSystem.Forms.Modals
{
    public partial class UpdateAttendanceModal : Form
    {
        private AttendanceDto _attendanceLog;
        private AttendanceDisplayDto _displayDto;

        public UpdateAttendanceModal(AttendanceDisplayDto displayDto, string date)
        {
            InitializeComponent();
            _displayDto = displayDto;
            LoadData(_displayDto.PersonalId, date);
            FullnameLabel.Text = _displayDto.Name;
        }

        private async void LoadData(Guid id, string date)
        {
            await GetAttendanceLog(id, date);
            await SetView(_attendanceLog);
        }

        private async Task SetView(AttendanceDto attendanceLog)
        {
            await Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    TimeInAmTextBox.Text = String.IsNullOrEmpty(attendanceLog.MorningIn)
                        ? null
                        : TimeOnly.ParseExact(attendanceLog.MorningIn, "HH:mm:ss").ToString("hh:mm");

                    TimeOutAmTextBox.Text = String.IsNullOrEmpty(attendanceLog.MorningOut)
                        ? null
                        : TimeOnly.ParseExact(attendanceLog.MorningOut, "HH:mm:ss").ToString("hh:mm");

                    TimeInPmTextBox.Text = String.IsNullOrEmpty(attendanceLog.AfternoonIn)
                        ? null
                        : TimeOnly.ParseExact(attendanceLog.AfternoonIn, "HH:mm:ss").ToString("hh:mm");

                    TimeOutPmTextBox.Text = String.IsNullOrEmpty(attendanceLog.AfternoonOut)
                        ? null
                        : TimeOnly.ParseExact(attendanceLog.AfternoonOut, "HH:mm:ss").ToString("hh:mm");

                }));



            });
        }

        private async Task GetAttendanceLog(Guid id, string date)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<AttendanceDto>>($"{ApiEndpoint.Attendance.GetAttendanceById}?id={id}&date={date}");

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " is null");

                if (apiData.isSuccess)
                {
                    Console.WriteLine("Successfully retrieved attendance log");
                    _attendanceLog = apiData.Data;
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

        private async Task UpdateAttendanceLog(AttendanceDto dto)
        {
            try
            {
                var newAttendanceLog = await HttpHelper.PutAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Attendance.UpdateAttendanceLog, dto);

                if (newAttendanceLog == null) throw new HttpRequestException(nameof(newAttendanceLog) + " is null");

                if (newAttendanceLog.isSuccess)
                {
                    Console.WriteLine(newAttendanceLog.Data);
                    GunaMessage.Info("Attendance log updated successfully", "Success");
                }
                else
                {
                    Console.WriteLine(newAttendanceLog.ErrorMessage);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var timeInAm = String.IsNullOrEmpty(TimeInAmTextBox.Text) ? null : TimeOnly.ParseExact(TimeInAmTextBox.Text, "hh:mm").ToString("hh:mm:ss");
                var timeOutAm = String.IsNullOrEmpty(TimeOutAmTextBox.Text) ? null : TimeOnly.ParseExact(TimeOutAmTextBox.Text, "hh:mm").ToString("hh:mm:ss");
                var timeInPm = String.IsNullOrEmpty(TimeInPmTextBox.Text) ? null : TimeOnly.ParseExact(TimeInPmTextBox.Text, "hh:mm") < new TimeOnly(13, 0, 0)
                               ? TimeOnly.ParseExact(TimeInPmTextBox.Text, "hh:mm").ToString() : TimeOnly.ParseExact(TimeInPmTextBox.Text, "hh:mm").AddHours(12).ToString("hh:mm:ss");
                var timeOutPm = String.IsNullOrEmpty(TimeOutPmTextBox.Text) ? null : TimeOnly.ParseExact(TimeOutPmTextBox.Text, "hh:mm").AddHours(12).ToString("hh:mm:ss");


                _attendanceLog.MorningIn = timeInAm;
                _attendanceLog.MorningOut = timeOutAm;
                _attendanceLog.AfternoonIn = timeInPm;
                _attendanceLog.AfternoonOut = timeOutPm;

                await UpdateAttendanceLog(_attendanceLog);
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
