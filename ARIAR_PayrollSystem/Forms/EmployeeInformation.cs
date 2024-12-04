using ARIAR_PayrollSystem.Forms.ChildrenForm;
using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using ARIAR_PayrollSystem.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class EmployeeInformation : Form
    {
        MainForm _mainForm;
        EmployeeDetails _employeeDetails;
        CustomMessageBox _MessageBox;
        private ApiResponse<List<PersonalInformationDisplayDto>> _employeeData;
        private List<object> _personalData;
        private EmployeeView _employeeView;


        private const int SB_BOTH = 3; // Both scroll bars

        public EmployeeInformation(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _employeeDetails = new EmployeeDetails();
            //DisplayPersonalInfo();
            TimeLabel.Text = DateTime.Now.ToString("t");
            DateLabel.Text = DateTime.Now.Date.ToString("MMMM d, yyyy");
            TimerProcess.Start();
            PopulateEmployeeTable();
            EmployeeTableView.VerticalScroll.Visible = false;
            EmployeeTableView.VerticalScroll.Maximum = 0;


        }


        //private async void DisplayPersonalInfo()
        //{
        //    try
        //    {
        //        _employeeData = await HttpHelper.GetAsync<ApiResponse<List<PersonalInformationDto>>>(ApiHelper.Employee.GetPersonalInfo);

        //        if (_employeeData == null)
        //        {
        //            //GunaMessage.ErrorMessage(_mainForm, "Cannot retrieve employee information!", "ERROR");
        //            ToastNotify.Error("No employee record found!");
        //            return;
        //        }
        //        _personalData = _employeeData.Data.Select(e => new
        //        {
        //            Fullname = $"{e.FirstName} {(string.IsNullOrEmpty(e.MiddleName) ? "" : $"{e.MiddleName[0]}. ")}{e.LastName}",
        //            PersonalId = (Guid)e.PersonalId
        //        }).ToList<object>();

        //        //EmployeeDataGrid.DataSource = _personalData;
        //        //EmployeeDataGrid.ClearSelection();

        //    }
        //    catch (Exception ex)
        //    {
        //        CustomMessageBox.Show(ex.Message);

        //    }
        //}
        private async void FillEmployeeView(List<PersonalInformationDisplayDto> data)
        {
            try
            {
                ProgressCircle.Visible = true;
                ProgressCircle.Value = 0;
                ProgressCircle.Minimum = 0;
                ProgressCircle.Maximum = data.Count;
                await EmployeeView.DataViewAsync(data, EmployeeTableView);

                for (int i = 0; i < data.Count; i++)
                {
                    ProgressCircle.Value = i + 1;
                    await Task.Delay(50);
                }
                ProgressCircle.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private async void PopulateEmployeeTable()
        {
            try
            {
                _employeeData = await HttpHelper.GetAsync<ApiResponse<List<PersonalInformationDisplayDto>>>(ApiEndpointHelper.Employee.GetPersonalInfo);
                LoadingLabel.Visible = true;
                EmployeeTableView.Visible = false;

                if (_employeeData == null)
                {
                    GunaMessage.Error("No employee data found!", "ERROR");
                    EmployeeTableView.Controls.Clear();
                    LoadingLabel.Visible = false;
                    EmployeeTableView.Visible = true;
                    ProgressCircle.Visible = false;
                    return;
                }

                if (_employeeData.isSuccess)
                {

                    FillEmployeeView(_employeeData.Data);
                }
                else
                {
                    GunaMessage.Error(_employeeData.ErrorMessage, "ERROR");
                }
            }
            catch (Exception ex)
            {
                GunaMessage.Error(ex.Message, "ERROR");
            }
            finally
            {
                LoadingLabel.Visible = false;
                EmployeeTableView.Visible = true;
            }
        }

        private void CreateNewBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimerProcess_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("t");
        }
        //private void FilterPersonnel(string searchItem)
        //{
        //    if (_personalData == null)
        //    {
        //        ToastNotify.Error("No item found with that keyword");
        //        return;
        //    }


        //    var filteredLogs = _personalData
        //                        .Where(x => x.GetType().GetProperty("Fullname")?.GetValue(x)?.ToString()
        //                        .ToLower().Contains(searchItem.ToLower()) ?? false)
        //                        .ToList();
        //    if (filteredLogs != null)
        //    {
        //        EmployeeDataGrid.DataSource = filteredLogs;          
        //    }
        //    else
        //    {
        //        _personalData = _employeeData.Data.Select(e => new
        //        {
        //            Fullname = $"{e.FirstName} {(string.IsNullOrEmpty(e.MiddleName) ? "" : $"{e.MiddleName[0]}. ")}{e.LastName}",
        //            PersonalId = (Guid)e.PersonalId
        //        }).ToList<object>();

        //        EmployeeDataGrid.DataSource = _personalData;

        //    }

        //    EmployeeDataGrid.ClearSelection();

        //}

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            var filter = SearchBox.Text.ToLower();
            //FilterPersonnel(guna2TextBox1.Text);
            if (String.IsNullOrEmpty(filter))
            {
                PopulateEmployeeTable();
                return;
            }
            var filteredEmployeeData = _employeeData.Data.Where
            (
                x => $"{x.FirstName} {(String.IsNullOrEmpty(x.MiddleName) ? "" : $"{x.MiddleName[0]}. ")}{x.LastName}".ToLower().Contains(filter)
            ).ToList();
            FillEmployeeView(filteredEmployeeData);
        }




        private void EmployeeDataGrid_Leave(object sender, EventArgs e)
        {
            //EmployeeDataGrid.ClearSelection();
        }
        

        private void EmployeeInformation_Load(object sender, EventArgs e)
        {
   

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PopulateEmployeeTable();
        }

        private async void EmployeeTableView_SizeChanged(object sender, EventArgs e)
        {
            var controls = EmployeeTableView.Controls.OfType<Control>().ToList();

            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    // Calculate the new width
                    int newWidth = EmployeeTableView.ClientSize.Width - 20;

                    // Update the control on the UI thread
                    EmployeeTableView.Invoke((Action)(() =>
                    {
                        control.Width = newWidth;
                    }));
                }
            });
            EmployeeViewScrollBar.Visible = true;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(200);
            EmployeeCanvasModal _canvasModal = new EmployeeCanvasModal();
            ControlsHelper.ShowModal(_mainForm, _canvasModal);
        }
    }
}
