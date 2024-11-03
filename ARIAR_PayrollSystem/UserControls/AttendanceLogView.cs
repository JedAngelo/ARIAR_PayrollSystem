using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.UserControls
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

        public static async Task DataViewAsync(List<AttendanceDataLog> data, FlowLayoutPanel view)
        {
            view.Controls.Clear();
            await Task.Run(() =>
            {
                foreach(AttendanceDataLog attendance in data)
                {
                    var logView = new AttendanceLogView(attendance.Name, attendance.Log, attendance.Type, attendance.EmployeeImage)
                    {
                        Width = view.ClientSize.Width - 10 
                    };

                    view.Invoke((MethodInvoker)(() => view.Controls.Add(logView)));
                }
            });
        }
        public static async Task DataViewAddAsync(AttendanceDataLog data, FlowLayoutPanel view)
        {
            await Task.Run(() =>
            {
                
                var logView = new AttendanceLogView(data.Name, data.Log, data.Type, data.EmployeeImage)
                {
                    Width = view.ClientSize.Width - 10
                };

                if (view.Controls.Count > 4)
                {
                    logView.Width -= 15;                    
                }


                view.Invoke((MethodInvoker)(() => view.Controls.Add(logView)));
            });
        }
    }
}
