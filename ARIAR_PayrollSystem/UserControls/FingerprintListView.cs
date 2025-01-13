using ARIAR_PayrollSystem.Forms;
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
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ARIAR_PayrollSystem.UserControls
{
    public partial class FingerprintListView : UserControl
    {
        private readonly PersonalInformationDisplayDto _employee;
        private readonly SystemMaintenance _parent;
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
                    _parent.SelectedEmployee = _employee;
                }
                else
                {
                    MainView.FillColor = Color.White;
                    Fullname.ForeColor = Color.FromArgb(45, 45, 45);

                }
            }
        }

        public FingerprintListView(SystemMaintenance parent, PersonalInformationDisplayDto employee)
        {
            InitializeComponent();
            _employee = employee;
            _parent = parent;
            _ = LoadPicture();
            Fullname.Text = $"{_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}";

        }



        public static async Task DataViewSync(SystemMaintenance parent, List<PersonalInformationDisplayDto> employees, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();
                
                var viewList = new List<FingerprintListView>();

                await Task.Run(() =>
                {
                    foreach(var employee in employees)
                    {
                        var fingerprintView = new FingerprintListView(parent, employee)
                        {
                            Width = view.ClientSize.Width - 13
                        };

                        viewList.Add(fingerprintView);
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

        private async Task LoadPicture()
        {
            await ControlsHelper.ConvertByteToImageCircleBoxAsync(_employee.EmployeeImage, EmployeePic);
        }

        private void MainView_Click(object sender, EventArgs e)
        {
            if (!Selected) _parent.RemoveSelected();
            Selected = !Selected;
        }
    }
}
