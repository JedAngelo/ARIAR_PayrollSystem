using PayrollSystem.Forms;
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
    public partial class PositionView : UserControl
    {
        private PositionDisplayDto _position;
        private SystemMaintenance _parent;
        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                TopView.Refresh();
                if (_selected)
                {
                    MainView.FillColor = Color.FromArgb(27, 75, 95);
                    PositionName.ForeColor = Color.White;
                    EmployeeCount.ForeColor = Color.White;
                    ModifiedBy.ForeColor = Color.White;
                    ModifiedDate.ForeColor = Color.White;
                    CreatedBy.ForeColor = Color.White;
                    DateCreated.ForeColor = Color.White;
                    _parent.SelectedPosition = _position;
                    TopView.Refresh();
                }
                else
                {
                    MainView.FillColor = Color.White;
                    PositionName.ForeColor = Color.FromArgb(50, 50, 50);
                    EmployeeCount.ForeColor = Color.FromArgb(50, 50, 50);
                    ModifiedBy.ForeColor = Color.FromArgb(50, 50, 50);
                    ModifiedDate.ForeColor = Color.FromArgb(50, 50, 50);
                    CreatedBy.ForeColor = Color.FromArgb(50, 50, 50);
                    DateCreated.ForeColor = Color.FromArgb(50, 50, 50);
                    _parent.SelectedPosition = null;
                    TopView.Refresh();
                }
            }
        }
        public PositionView(PositionDisplayDto position, SystemMaintenance parent)
        {
            InitializeComponent();
            _position = position;
            _parent = parent;
            LoadData(_position);
        }


        public static async Task DataViewAsync(List<PositionDisplayDto> positionList, SystemMaintenance parent, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var positionViewList = new List<PositionView>();

                await Task.Run(() =>
                {
                    foreach (var position in positionList)
                    {
                        var positionView = new PositionView(position, parent)
                        {
                            Width = view.ClientSize.Width - 13
                        };

                        positionViewList.Add(positionView);
                    }
                    view.Invoke((Action)(() => view.Controls.AddRange(positionViewList.ToArray())));
                });
                Console.WriteLine("Position view loaded");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void LoadData(PositionDisplayDto data)
        {
            await Task.Run(() =>
            {
                PositionName.Text = data.PositionName;
                EmployeeCount.Text = $"{data.EmployeeCount}";
                CreatedBy.Text = data.CreatedBy;
                DateCreated.Text = data.CreatedDate.ToString("MMM. d, yyyy");
                ModifiedBy.Text = data.ModifiedBy ?? "---";
                ModifiedDate.Text = data.ModifiedDate != null ? ((DateTime)data.ModifiedDate).ToString("MMM. d, yyyy") : "---";
                TopView.Refresh();
            });
        }

        private void TopView_Click(object sender, EventArgs e)
        {
            if (!Selected) _parent.RemoveSelectedPosition();
            Selected = !Selected;
        }
    }
}
