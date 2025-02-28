using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.UserControls
{
    public partial class AttendanceLogView : UserControl
    {
        public AttendanceLogView(string fullName, string log, string type, byte[] employeePic)
        {
            InitializeComponent();
            Fullname.Text = fullName;
            Log.Text = log;
            Type.Text = type;
            LoadImage(employeePic);
        }

        public async void LoadImage(byte[] picByte)
        {
            await ControlsHelper.ConvertByteToImageAsync(picByte, EmployeePic);
        }

        public static async Task DataViewAsync(List<AttendanceDisplayDto> data, FlowLayoutPanel view)
        {
            view.Controls.Clear();

            var logViewList = new List<AttendanceLogView>();

            await Task.Run(() =>
            {
                foreach(AttendanceDisplayDto attendance in data)
                {
                    var logView = new AttendanceLogView(attendance.Name, attendance.Log, attendance.Type, attendance.EmployeeImage)
                    {
                        Width = view.ClientSize.Width - 13
                    };
                    logViewList.Add(logView);
                }
                view.BeginInvoke((Action)(() => view.Controls.AddRange(logViewList.ToArray())));
            });
        }
        public static async Task DataViewAddAsync(AttendanceDisplayDto data, FlowLayoutPanel view)
        {
            await Task.Run(() =>
            {
                
                var logView = new AttendanceLogView(data.Name, data.Log, data.Type, data.EmployeeImage)
                {
                    Width = view.ClientSize.Width - 13
                };

                view.Invoke((Action)(() => view.Controls.Add(logView)));
            });
        }

        private void EmployeePic_Click(object sender, EventArgs e)
        {

        }
    }
}
