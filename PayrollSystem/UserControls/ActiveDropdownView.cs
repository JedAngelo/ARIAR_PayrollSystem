using PayrollSystem.Forms;
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

namespace PayrollSystem.UserControls
{
    public partial class ActiveStatusDropdownView : UserControl
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

        public ActiveStatusDropdownView(SetFilterModal parent, string activeStatus)
        {
            InitializeComponent();
            CheckBox.Text = activeStatus;
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

        public static async Task ActiveViewAsync(SetFilterModal parent, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();
                
                List<string> ActiveStatus = new List<string> { "ACTIVE", "INACTIVE" };

                var activeStatusesViewList = new List<ActiveStatusDropdownView>();

                await Task.Run(() =>
                {
                    foreach(var active in ActiveStatus)
                    {
                        var activeStatusView = new ActiveStatusDropdownView(parent, active)
                        {
                            Width = view.Width,
                        };
                        view.Invoke((Action)(() =>
                        {
                            activeStatusView.CheckBox.Checked = EmployeeManagement.ActiveStatusFilter.Contains(active.ToLower());
                        }));
                        activeStatusesViewList.Add(activeStatusView);
                    }
                    view.Invoke((Action)(() => view.Controls.AddRange(activeStatusesViewList.ToArray())));
                    
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
            if (CheckBox.Checked && !EmployeeManagement.ActiveStatusFilter.Contains(filter)) EmployeeManagement.ActiveStatusFilter.Add(filter);
            else if (!CheckBox.Checked) EmployeeManagement.ActiveStatusFilter.Remove(filter);
        }
    }
}
