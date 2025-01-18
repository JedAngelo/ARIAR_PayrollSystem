using PayrollSystem.Forms.Modals;
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
    public partial class EmployeeBiometricsView : UserControl
    {
        private bool _selected;
        private EmployeeBiometricsModal _parent;
        private EmployeeBiometricsDto _biometric;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                if (_selected)
                {
                    IdLabel.ForeColor = Color.White;
                    DateLabel.ForeColor = Color.White;
                    MainView.FillColor = Color.FromArgb(27, 75, 95);
                    _parent.SelectedBiometrics.Add(_biometric);
                }
                else
                {
                    IdLabel.ForeColor = Color.FromArgb(50, 50, 50);
                    DateLabel.ForeColor = Color.FromArgb(50, 50, 50);
                    MainView.FillColor = Color.White;
                    _parent.SelectedBiometrics.Remove(_biometric);
                }
                TopView.Refresh();
            }
        }
        
        public EmployeeBiometricsView(EmployeeBiometricsDto biometrics, EmployeeBiometricsModal parent)
        {
            InitializeComponent();
            _parent = parent;
            _biometric = biometrics;
            LoadData(_biometric);
        }

        private void LoadData(EmployeeBiometricsDto data)
        {
            try
            {
                IdLabel.Text = data.RecordId.ToString();
                DateLabel.Text = data.RecordDate.ToString("ddd, MMMM d, yyyy hh:mm:ss tt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async static Task DataViewAsync(List<EmployeeBiometricsDto> biometrics, EmployeeBiometricsModal parent, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var viewList = new List<EmployeeBiometricsView>();

                await Task.Run(() =>
                {
                    foreach(var biometric in biometrics)
                    {
                        var biometricView = new EmployeeBiometricsView(biometric, parent)
                        {
                            Width = view.ClientSize.Width - 13
                        };

                        viewList.Add(biometricView);
                    }
                    view.BeginInvoke((Action)(() => view.Controls.AddRange(viewList.ToArray())));
                });


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TopView_Click(object sender, EventArgs e)
        {
            Selected = !Selected;
        }
    }
}
