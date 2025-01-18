using PayrollSystem.Forms;
using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
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

namespace PayrollSystem.UserControls
{
    public partial class EmployeeView : UserControl
    {
        private Guid _personalId;
        private MainForm _mainForm;
        private PersonalInformationDisplayDto _employeeInfo;
        private bool _isActionsVisible = false;
        private bool _isTransitioning = false;

        public EmployeeView(MainForm mainForm, PersonalInformationDisplayDto employeeInfo)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _employeeInfo = employeeInfo;
            Fullname.Text = $"{_employeeInfo.FirstName} {(string.IsNullOrEmpty(_employeeInfo.MiddleName) ? "" : $"{_employeeInfo.MiddleName[0]}. ")}{_employeeInfo.LastName}";
            PositionLabel.Text = _employeeInfo.PositionName;
            EmailLabel.Text = _employeeInfo.Email;
            ActiveLabel.Text = _employeeInfo.IsActive ? "ACTIVE" : "INACTIVE";
            ActiveChip.FillColor = _employeeInfo.IsActive ? Color.DodgerBlue : Color.SlateGray;
            //ContactNo.Text = contactNo;
            //Address.Text = address;
            if (_employeeInfo.EmployeeImage != null)
            {
                LoadEmployeePic(_employeeInfo.EmployeeImage);
            }
            _personalId = (Guid)_employeeInfo.PersonalId;
            ActionsOptions.Visible = false;




        }
        private async void LoadEmployeePic(byte[] pic)
        {
            await ControlsHelper.ConvertByteToImageCircleBoxAsync(pic, EmployeePic);
        }

        public static async Task DataViewAsync(MainForm mainForm, List<PersonalInformationDisplayDto> data, FlowLayoutPanel view)
        {
            try
            {
                view.Controls.Clear();

                var employeeViewList = new List<Control>();

                await Task.Run(() =>
                {
                    foreach (PersonalInformationDisplayDto employee in data)
                    {
                        var employeeView = new EmployeeView(mainForm, employee)
                        {
                            Width = view.ClientSize.Width - 13
                        };
                        //view.Invoke((Action)(() => view.Controls.Add(employeeView)));
                        //view.Controls.Add(employeeView);

                        employeeViewList.Add(employeeView);

                    }
                });
                view.Invoke((Action)(() => view.Controls.AddRange(employeeViewList.ToArray())));

                //view.Controls.AddRange(employeeViewList.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            ToastNotify.Info(_personalId.ToString());
        }

      

    
        //private void EmployeeView_SizeChanged(object sender, EventArgs e)
        //{
        //    actionShowX = showActionButton.Location.X - anchorX;
        //    actionHideX = actionShowX + actionHideIncrementX;
        //}

       

       


        private void MainView_MouseEnter(object sender, EventArgs e)
        {
            MainView.FillColor = Color.Gainsboro;
        }

        private void MainView_MouseLeave(object sender, EventArgs e)
        {
            MainView.FillColor = Color.White;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            EmployeeInformationView employeeView = new EmployeeInformationView(_employeeInfo);
            ControlsHelper.ShowModal(_mainForm, employeeView);
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var _employeeRaw = await HttpHelper.GetAsync<ApiResponse<PersonalInformationDto>>(ApiEndpoint.Employee.GetPersonalInfoRaw + _personalId);

                if (_employeeRaw == null) throw new Exception($"{this.Name}: Employee Information is Null");
                
                if (_employeeRaw.isSuccess)
                {
                    //Console.WriteLine(JsonConvert.SerializeObject(_employeeRaw.Data, Formatting.Indented));
                    EmployeeCanvasModal employeeCanvas = new EmployeeCanvasModal(_employeeRaw.Data, _mainForm);
                    using (employeeCanvas)
                    {
                        ControlsHelper.ShowModal(_mainForm, employeeCanvas);
                    }
                    _mainForm.RefreshEmployeeInformationView();
                }
                else
                {
                    ToastNotify.Warning(_employeeRaw.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        private void ToggleButtonsVisibility(bool show)
        {
            //ExportButton.Visible = show;
            EditButton.Visible = show;
            ViewButton.Visible = show;
            DeleteButton.Visible = show;
            FingerprintButton.Visible = show;
        }


        private async void ToggleActionsVisibility()
        {
            if (_isTransitioning) return; // Prevent concurrent toggling
            _isTransitioning = true;
            MainView.SuspendLayout(); // Prevent layout updates until we are done


            _isActionsVisible = !_isActionsVisible;
            ActionsOptions.Visible = _isActionsVisible; //toggle action panel
            await Task.Delay(100);
            ToggleButtonsVisibility(_isActionsVisible); // toggle visibility of buttons in the panel.

            MainView.ResumeLayout(true);  // Update the layout
            _isTransitioning = false;
        }

        private void ActionsButton_Click(object sender, EventArgs e)
        {
            ToggleActionsVisibility();
        }

        private void hideActionButton_Click(object sender, EventArgs e)
        {
            ToggleActionsVisibility();
        }

        private void EmployeeView_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Table size docked to fill");
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = GunaMessage.Question(_mainForm, "Are you sure you want to delete this employee?", "Confirm");
            if (result == DialogResult.Cancel || result == DialogResult.No) return;


            var employee = new DeleteEmployeeDto
            {
                PersonalId = (Guid)_employeeInfo.PersonalId,
                DeletedBy = "ADMIN"
            };
            await DeleteEmployee(employee);
        }

        private async Task DeleteEmployee(DeleteEmployeeDto dto)
        {
            try
            {
                var apiData = await HttpHelper.PutAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Employee.DeleteEmployee, dto);
                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    ToastNotify.Success("Employee deleted!");
                    Console.WriteLine(apiData.Data);
                    _mainForm.RefreshEmployeeInformationView();
                }
                else
                {
                    ToastNotify.Warning(apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FingerprintButton_Click(object sender, EventArgs e)
        {
            var biometricsModal = new EmployeeBiometricsModal(_employeeInfo, _mainForm);
            ControlsHelper.ShowModal(_mainForm, biometricsModal);
        }
    }
}
