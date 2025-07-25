﻿using PayrollSystem.Forms;
using PayrollSystem.Forms.Modals;
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
    public partial class EmployeeShortView : UserControl
    {
        private readonly PersonalInformationDisplayDto _employee;
        private readonly AttendanceModal _parent;
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
                    _parent.SelectedEmployees.Add(_employee);
                    _ = _parent.SetView(_employee);
                }
                else
                {
                    MainView.FillColor = Color.White;
                    Fullname.ForeColor = Color.FromArgb(45, 45, 45);
                    _parent.SelectedEmployees.Remove(_employee);
                    _ = _parent.SetView(null);
                }
            }
        }



        public EmployeeShortView(PersonalInformationDisplayDto employee, AttendanceModal parent)
        {
            InitializeComponent();
            _employee = employee;
            _parent = parent;
            _ = LoadPicture();
            Fullname.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}";
        
        }


        public static async Task DataViewAsync(AttendanceModal parent, List<PersonalInformationDisplayDto> data, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var employeeViewList = new List<EmployeeShortView>();

                await Task.Run(() =>
                {
                    foreach (var employee in data)
                    {
                        var employeeView = new EmployeeShortView(employee, parent)
                        {
                            Width = view.ClientSize.Width - 10
                        };
                        employeeViewList.Add(employeeView);
                    }

                    
                });

                view.Invoke((Action)(() => view.Controls.AddRange(employeeViewList.ToArray())));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private async Task LoadPicture()
        {
            await ControlsHelper.ConvertByteToImageCircleBoxAsync(_employee.EmployeeImage, EmployeePic);
        }

        private void MainView_Click(object sender, EventArgs e)
        {
            //if (!Selected) _parent.RemoveSelected();
            Selected = !Selected;
        }
    }
}
