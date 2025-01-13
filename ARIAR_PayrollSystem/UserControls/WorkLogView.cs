using ARIAR_PayrollSystem.Forms;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.UserControls
{
    public partial class WorkLogView : UserControl
    {
        private readonly AttendanceManagement _parent;
        private readonly PersonalInformationDisplayDto _employee;
        private DateTime _date;
        private bool _selected = false;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                if (_selected)
                {
                    MainView.FillColor = Color.FromArgb(27, 75, 95);
                    Fullname.ForeColor = Color.White;
                    //_ = GetLogCount();
                }
                else
                {
                    MainView.FillColor = Color.White;
                    Fullname.ForeColor = Color.FromArgb(45, 45, 45);

                }
            }
        }

        public WorkLogView(AttendanceManagement parent, PersonalInformationDisplayDto employee, DateTime date)
        {
            InitializeComponent();
            _parent = parent;
            _employee = employee;
            _date = date;
            _ = LoadPic();
            Fullname.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}";
            //_ = GetLogCount();
        }


        public static async Task DataViewAsync(AttendanceManagement parent, List<PersonalInformationDisplayDto> employees, DateTime date, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var viewList = new List<WorkLogView>();

                await Task.Run(() =>
                {
                    foreach (var employee in employees)
                    {
                        var log = new WorkLogView(parent, employee, date)
                        {
                            Width = view.ClientSize.Width - 13
                        };
                        viewList.Add(log);
                        
                    }
                    view.Invoke((Action)(() => view.Controls.AddRange(viewList.ToArray())));

                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task LoadPic()
        {
            await ControlsHelper.ConvertByteToImageCircleBoxAsync(_employee.EmployeeImage, EmployeePic);
        }

        private void MainView_Click(object sender, EventArgs e)
        {
            if (!Selected) _parent.RemoveSelected();
            Selected = !Selected;
        }

        public async void LoadData(DateTime date)
        {
            await GetLogCount(date);
        }

        private async Task GetLogCount(DateTime date)
        {
            try
            {
                var endPoint = $"{ApiEndpoint.Attendance.GetLogCountById}?id={_employee.PersonalId}&date={date.ToString("yyyy-MM-dd")}";
                //Console.WriteLine(endPoint);
                //https://localhost:44376/api/Attendance/GetLogCountById?id=74a7fe53-2031-4a96-b253-08b984ace0a0&date=2024-12-31
                var _data = await HttpHelper.GetAsync<ApiResponse<LogCountDto>>(endPoint);

                if (_data == null) throw new ArgumentNullException("No attendance count log found");

                if (_data.isSuccess)
                {
                    await SetLogCount(_data.Data.PresentCount.ToString(), _data.Data.AbsentCount.ToString());
                    Console.WriteLine($"Log count retrieved for: {_employee.PersonalId}");
                }
                else
                {
                    Console.WriteLine(_data.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task SetLogCount(string present, string absent)
        {
            await Task.Run(() =>
            {
                Invoke((Action)(() => PresentCount.Text = $"     {present}"));
                Invoke((Action)(() => AbsentCount.Text = $"     {absent}"));
            });
        }
    }
}
