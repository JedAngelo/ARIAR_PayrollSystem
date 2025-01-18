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
    public partial class PositionDropdownView : UserControl
    {
        private bool _selected = false;
        public PositionDropdownView(PostionDto postion)
        {
            InitializeComponent();
            CheckBox.Text = postion.PositionName.ToUpper();
            
        }

        private void ViewParent_MouseEnter(object sender, EventArgs e)
        {
            ViewParent.FillColor = Color.Gainsboro;
        }

        private void ViewParent_MouseLeave(object sender, EventArgs e)
        {
            ViewParent.FillColor = Color.White;
        }

        public static async Task PositionViewAsync(List<PostionDto> data, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var positionsViewList = new List<PositionDropdownView>();

                await Task.Run(() =>
                {
                    foreach(PostionDto position in data)
                    {
                        var positionView = new PositionDropdownView(position)
                        {
                            Width = view.Width,
                        };
                        view.Invoke((Action)(() =>
                        {
                            positionView.CheckBox.Checked = EmployeeManagement.PositionFilter.Contains(position.PositionName.ToLower());
                        }));
                        positionsViewList.Add(positionView);
                    }
                    view.Invoke((Action)(() => view.Controls.AddRange(positionsViewList.ToArray())));
                    
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
            if (CheckBox.Checked && !EmployeeManagement.PositionFilter.Contains(filter)) EmployeeManagement.PositionFilter.Add(filter);
            else if (!CheckBox.Checked) EmployeeManagement.PositionFilter.Remove(filter);
        }
    }
}
