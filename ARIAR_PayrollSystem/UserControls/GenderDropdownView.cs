using ARIAR_PayrollSystem.Forms;
using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
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

namespace ARIAR_PayrollSystem.UserControls
{
    public partial class GenderDropdownView : UserControl
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

        public GenderDropdownView(SetFilterModal parent, string Gender)
        {
            InitializeComponent();
            CheckBox.Text = Gender;
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

        public static async Task GenderViewAsync(SetFilterModal parent, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();
                
                List<string> Genders = new List<string> { "MALE", "FEMALE" };

                var gendersViewList = new List<GenderDropdownView>();

                await Task.Run(() =>
                {
                    foreach(var gender in Genders)
                    {
                        var genderView = new GenderDropdownView(parent, gender)
                        {
                            Width = view.Width,
                        };
                        view.Invoke((Action)(() =>
                        {
                            genderView.CheckBox.Checked = EmployeeInformation.GenderFilter.Contains(gender.ToLower());
                        }));
                        gendersViewList.Add(genderView);
                    }
                    view.Invoke((Action)(() => view.Controls.AddRange(gendersViewList.ToArray())));
                    
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
            if (CheckBox.Checked && !EmployeeInformation.GenderFilter.Contains(filter)) EmployeeInformation.GenderFilter.Add(filter);
            else if (!CheckBox.Checked) EmployeeInformation.GenderFilter.Remove(filter);
        }

    }
}
