﻿using PayrollSystem.Forms;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.UserControls
{
    public partial class PayrollView : UserControl
    {
        private PayrollDetails _parent;
        private readonly PersonalInformationDisplayDto _employee;
        private PayrollDto _payrollData; 
        private bool _selected = false;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                _ = transition(_selected);
                if (_selected)
                {
                    _parent.SelectedEmployee = _employee;
                    if (_payrollData != null) _parent.SelectedPayrollData = _payrollData;
                }
                else
                {
                    _parent.Invoke((Action)(() =>
                    {
                        _parent.SelectedEmployee = null;
                        _parent.SelectedPayrollData = null;
                    }));
                }
                Invoke((Action)(() => TopView.Refresh()));
            }
        }

        public Guid PersonalId
        {
            get { return (Guid)_employee.PersonalId; }
        }


        private async Task transition(bool selected)
        {
            if (selected)
            {
                ParentView.FillColor = Color.FromArgb(27, 75, 95);
                Fullname.ForeColor = Color.White;
                WorkDaysLabel.ForeColor = Color.White;
                DailyLabel.ForeColor = Color.White;
                GrossLabel.ForeColor = Color.White;
                UndertimeLabel.ForeColor = Color.White;
                LateLabel.ForeColor = Color.White;
                AbsentLabel.ForeColor = Color.White;
                TotalDeductionLabel.ForeColor = Color.White;
                NetLabel.ForeColor = Color.White;

                await Task.Delay(250);
            }
            else
            {
                ParentView.FillColor = Color.White;
                Fullname.ForeColor = Color.FromArgb(45, 45, 45);
                WorkDaysLabel.ForeColor = Color.FromArgb(45, 45, 45);
                DailyLabel.ForeColor = Color.FromArgb(45, 45, 45);
                GrossLabel.ForeColor = Color.FromArgb(45, 45, 45);
                UndertimeLabel.ForeColor = Color.FromArgb(45, 45, 45);
                LateLabel.ForeColor = Color.FromArgb(45, 45, 45);
                AbsentLabel.ForeColor = Color.FromArgb(45, 45, 45);
                TotalDeductionLabel.ForeColor = Color.FromArgb(45, 45, 45);
                NetLabel.ForeColor = Color.FromArgb(45, 45, 45);

                await Task.Delay(250);
            }
            
        }


        public PayrollView(PayrollDetails parent, PersonalInformationDisplayDto employee)
        {
            InitializeComponent();
            _parent = parent;
            _employee = employee;
            Fullname.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}";
            _ = LoadPic();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static async Task DataViewAsync(PayrollDetails parent, List<PersonalInformationDisplayDto> employees, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var viewList = new List<PayrollView>();

                await Task.Run(() =>
                {
                    foreach (var employee in employees)
                    {
                        var payrollView = new PayrollView(parent, employee)
                        {
                            Width = view.ClientSize.Width
                        };
                        viewList.Add(payrollView);
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

        private async Task LoadPic()
        {
            await ControlsHelper.ConvertByteToImageCircleBoxAsync(_employee.EmployeeImage, EmployeePic);
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (!Selected) _parent.RemoveSelected();
            Selected = !Selected;
        }

        public async void SetPayrollData(PayrollDto data)
        {
            try
            {
                if (data == null) return;
                _payrollData = data;
                var startDate = DateOnly.ParseExact(data.StartDate, "yyyy-MM-dd");
                var endDate = DateOnly.ParseExact(data.EndDate, "yyyy-MM-dd");
                var workingDays = ((endDate.DayNumber + 1) - startDate.DayNumber) - ControlsHelper.GetNumberOfSundays(startDate, endDate);

                await Task.Run(() =>
                {
                    Invoke((Action)(() =>
                    {
                        WorkDaysLabel.Text = $"{data.TotalWorkDay:F1}";
                        DailyLabel.Text = $"{data.DailySalary:F}";
                        GrossLabel.Text = $"{data.GrossSalary:F}";
                        UndertimeLabel.Text = $"{data.UndertimeDeduction:F}";
                        LateLabel.Text = $"{data.LateDeduction:F}";
                        AbsentLabel.Text = $"{data.AbsentDeduction:F}";
                        TotalDeductionLabel.Text = $"{data.TotalDeductions:F}";
                        NetLabel.Text = $"{data.NetSalary:F}";
                        TopView.Refresh();
                    }));
                });

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
