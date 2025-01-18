using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class AddLeaveModal : Form
    {
        private List<PersonalInformationDisplayDto> _employees;
        private PersonalInformationDisplayDto _selectedEmployee = new PersonalInformationDisplayDto();
        private string _date;

        public PersonalInformationDisplayDto SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
            }
        }


        public AddLeaveModal(List<PersonalInformationDisplayDto> employees, string date)
        {
            InitializeComponent();
            _employees = employees;
            _date = date;
        }

        private async Task LoadView(List<PersonalInformationDisplayDto> data)
        {
            try
            {
                await EmployeeShortView4.DataViewAsync(this, data, EmployeeView);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {

        }
        public async void RemoveSelected()
        {
            var controls = EmployeeView.Controls.OfType<EmployeeShortView4>().Where(x => x.Selected).ToList();
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
            var controls = EmployeeView.Controls.OfType<EmployeeShortView4>().Where(x => !x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.Selected = true;
                }
            });
        }

        private async void AddLeaveModal_Load(object sender, EventArgs e)
        {
            await LoadView(_employees);
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null) ToastNotify.Warning("Please select an employee first");
            var dto = new LeaveDto
            {
                StartDate = StartDatePicker.Value.ToString("yyyy-MM-dd"),
                EndDate = EndDatePicker.Value.ToString("yyyy-MM-dd"),
                PersonalId = _selectedEmployee.PersonalId
            };
            await AddLeave(dto);
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null) ToastNotify.Warning("Please select an employee first");
            await DeleteLeave(StartDatePicker.Value.ToString("yyyy-MM-dd"), EndDatePicker.Value.ToString("yyyy-MM-dd"), _selectedEmployee.PersonalId.ToString());
        }

        private async Task AddLeave(LeaveDto dto)
        {
            try
            {
                var apiData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Attendance.AddOrUpdateLeave, dto);

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    ToastNotify.Success(apiData.Data);
                }
                else
                {
                    ToastNotify.Warning(apiData.ErrorMessage);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task DeleteLeave(string start, string end, string id)
        {
            try
            {
                var apiData = await HttpHelper.DeleteAsync<ApiResponse<string>>($"{ApiEndpoint.Attendance.DeleteLeave}?start={start}&end={end}&id={id}");

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    ToastNotify.Success(apiData.Data);
                }
                else
                {
                    ToastNotify.Warning(apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
