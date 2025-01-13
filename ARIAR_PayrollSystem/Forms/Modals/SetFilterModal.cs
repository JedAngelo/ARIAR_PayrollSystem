using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using ARIAR_PayrollSystem.UserControls;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using Newtonsoft.Json.Linq;
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

namespace ARIAR_PayrollSystem.Forms.Modals
{
    public partial class SetFilterModal : Form
    {
        private List<PostionDto> _positions;
        private readonly EmployeeInformation _parent;

        public SetFilterModal(EmployeeInformation parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        


        private void PositionsDropButton_Click(object sender, EventArgs e)
        {
            if (PositionDropDown.Visible) transition.Hide(PositionDropDown); else transition.Show(PositionDropDown);
        }

        private void ActiveDropButton_Click(object sender, EventArgs e)
        {
            if (ActiveDropDown.Visible) transition.Hide(ActiveDropDown); else transition.Show(ActiveDropDown);
        }

        private async Task GetPositionsAsync()
        {
            try
            {
                var rawPositions = await HttpHelper.GetAsync<ApiResponse<List<PostionDto>>>(ApiEndpoint.Employee.GetPositions);

                if (rawPositions == null) throw new ArgumentNullException(nameof(rawPositions), "Error: Positions is null");

                if (rawPositions.isSuccess)
                {
                    _positions = rawPositions.Data;
                    await PositionDropdownView.PositionViewAsync(_positions, PositionsFlowView);
                }
                else
                {
                    throw new HttpRequestException(rawPositions.ErrorMessage);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private async void SetFilterModal_Load(object sender, EventArgs e)
        {
           
            try
            {
                await GetPositionsAsync();
                await GenderDropdownView.GenderViewAsync(this, GendersFlowView);
                await ActiveStatusDropdownView.ActiveViewAsync(this, ActiveFlowView);
                await MaritalStatusDropdownView.MaritalStatusViewAsync(this, MaritalFlowView);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            _parent.ApplyFilter();
            this.Close();
        }

        private async void ClearAllButton_Click(object sender, EventArgs e)
        {
            var posiitonList = PositionsFlowView.Controls.OfType<PositionDropdownView>().ToList();
            var genderList = GendersFlowView.Controls.OfType<GenderDropdownView>().ToList();
            var activeList = ActiveFlowView.Controls.OfType<ActiveStatusDropdownView>().ToList();
            var maritalList = MaritalFlowView.Controls.OfType<MaritalStatusDropdownView>().ToList();

            await Task.Run(() =>
            {
                foreach (var position in posiitonList)
                {
                    position.Invoke((Action)(() => position.CheckBox.Checked = false));
                }

                foreach (var gender in genderList)
                {
                    gender.Invoke((Action)((() => gender.CheckBox.Checked = false)));
                }

                foreach (var active in activeList)
                {
                    active.Invoke((Action)(() => active.CheckBox.Checked = false));
                }

                foreach (var marital in maritalList)
                {
                    marital.Invoke((Action)(() => marital.CheckBox.Checked = false));
                }

            });
        }
    }
}
