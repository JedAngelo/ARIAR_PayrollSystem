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
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;

namespace PayrollSystem.UserControls
{
    public partial class MaritalStatusDropdownView : UserControl
    {
        private bool _selected = false;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
            }
        }

        private readonly SetFilterModal _parent;

        public MaritalStatusDropdownView(SetFilterModal parent, string maritalStatus)
        {
            InitializeComponent();
            CheckBox.Text = maritalStatus;
            _parent = parent;
        }

        private void ViewParent_MouseEnter(object sender, EventArgs e)
        {
            ViewParent.FillColor = Color.Gainsboro;
        }

        private void ViewParent_MouseLeave(object sender, EventArgs e)
        {
            ViewParent.FillColor = Color.White;
        }

        public static async Task MaritalStatusViewAsync(SetFilterModal parent, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                List<string> MaritalStatuses = new List<string> { "SINGLE", "MARRIED", "WIDOWED", "SEPARATED"};

                var maritalStatusesViewList = new List<MaritalStatusDropdownView>();

                await Task.Run(() =>
                {
                    foreach(var maritalStatus in MaritalStatuses)
                    {
                        var maritalStatusView = new MaritalStatusDropdownView(parent, maritalStatus)
                        {
                            Width = view.Width,
                        };
                        view.Invoke((Action)(() =>
                        {
                            maritalStatusView.CheckBox.Checked = EmployeeManagement.MaritalStatusFilter.Contains(maritalStatus.ToLower());
                        }));
                        maritalStatusesViewList.Add(maritalStatusView);
                    }
                    view.Invoke((Action)(() => view.Controls.AddRange(maritalStatusesViewList.ToArray())));
                    
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string filter = CheckBox.Text.ToLower();
            if (CheckBox.Checked && !EmployeeManagement.MaritalStatusFilter.Contains(filter)) EmployeeManagement.MaritalStatusFilter.Add(filter);
            else if (!CheckBox.Checked) EmployeeManagement.MaritalStatusFilter.Remove(filter);
        }

    }
}
