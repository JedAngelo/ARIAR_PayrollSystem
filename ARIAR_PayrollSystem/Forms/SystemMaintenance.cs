using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Forms.Modals.ModalHelpers;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using ARIAR_PayrollSystem.UserControls;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class SystemMaintenance : Form
    {
       
        MainForm _mainForm;
        //TestModal _testModal;
        public readonly HttpClient client = new HttpClient();
        private Guid selectedId;
        private PersonalInformationDisplayDto _employee;
        private List<PositionDisplayDto> _positionList;
        private SystemSettingsDto _settings;
        public PersonalInformationDisplayDto SelectedEmployee
        {
            get { return _employee; }
            set
            {
                _employee = value;
            }
        }

        private SystemSettingsDto SetSettings
        {
            set
            {
                _settings = value;
                LoadSettings(_settings);
            }
        }



        public SystemMaintenance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;


            //targetY = originalY - 20;


        }

        

        private async void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {


               

            }
            catch (Exception ex)
            {

                GunaMessage.Error($"Error: {ex.Message}","ERROR");
                
            }
            finally
            {
                ControlsHelper.ClearAllTextBoxes(this);
            }
        }

        private async void SystemMaintenance_Load(object sender, EventArgs e)
        {
            await GetSettings();
        }




        //Textbox and label animation FUCKKKKKKK
        //private void TextBox_Enter(object sender, EventArgs e)
        //{
        //    Guna2TextBox guna2TextBox = sender as Guna2TextBox;
        //    ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, true);
        //}

        //private void TextBox_Leave(object sender, EventArgs e)
        //{
        //    Guna2TextBox guna2TextBox = sender as Guna2TextBox;
        //    ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, false);
        //}

        
        //private void ClearButton_Click(object sender, EventArgs e)
        //{
        //    ControlsHelper.ClearAllTextBoxes(this);
        //    ControlsHelper.LabelTransitionAll(textBoxLabelMap, LabelTransition);
        //}

        //private void Label_Click(object sender, EventArgs e)
        //{
        //    Label clickedLabel = sender as Label;
        //    ControlsHelper.FocusTextBox(clickedLabel, textBoxLabelMap);
        //}

    
        public async void RemoveSelected()
        {
            var controls = ListView.Controls.OfType<FingerprintListView>().Where(x => x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    control.Selected = false;
                }
            });
        }






        private void guna2Button2_Click(object sender, EventArgs e)
        {
  
        }

        private async void SystemMaintenanceTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SystemMaintenanceTabs.SelectedTab.Text == "Biometrics")
            {                
                _ = FingerprintListView.DataViewSync(this, _mainForm.EmployeeInfo, ListView);
            }
            if (SystemMaintenanceTabs.SelectedTab.Name == "Positions")
            {
                await GetPositionData();
            }
            if (SystemMaintenanceTabs.SelectedTab.Name == "SystemSettings")
            {
                await GetSettings();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var fingerprintEnrollment = new FingerPrintEnrollment(_mainForm, _employee);
            ControlsHelper.ShowModal(_mainForm, fingerprintEnrollment);
        }

        private void AddPosition_Click(object sender, EventArgs e)
        {
            var addPosition = new PositionModal();
            ControlsHelper.ShowModal(_mainForm, addPosition);
        }

        private async Task GetPositionData()
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<PositionDisplayDto>>>(ApiEndpoint.Employee.GetPositions);

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " from" + nameof(GetPositionData) + " is null");

                if (apiData.isSuccess)
                {
                    _positionList = apiData.Data;
                    ToastNotify.Success("Position info loaded successfully");
                    await PositionView.DataViewAsync(_positionList, this, DataView);
                    Console.WriteLine(JsonConvert.SerializeObject(_positionList, Formatting.Indented));
                }
                else
                {
                    Console.WriteLine(apiData.ErrorMessage);
                    ToastNotify.Warning("Failed loading postion info, try again later");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void DataView_SizeChanged(object sender, EventArgs e)
        {
            var controls = DataView.Controls.OfType<PositionView>().ToList();

            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    // Calculate the new width
                    int newWidth = DataView.ClientSize.Width - 13;

                    // Update the control on the UI thread
                    DataView.Invoke((Action)(() =>
                    {
                        control.Width = newWidth;
                    }));
                }
            });
        }

        private async Task GetSettings()
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<SystemSettingsDto>>(ApiEndpoint.Settings.GetSettings);

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    Console.WriteLine("Successfully retrieved settings data");
                    SetSettings = apiData.Data;
                }
                else
                {
                    Console.WriteLine("Failed retrieving settings data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private async Task UpdateSettings()
        {
            try
            {
                var earlyOutEndsMorning = TimeOnly.ParseExact(EarlyOutMorningCutoff.Text, "h:mm tt");
                var earlyOutEndsAfternoon = TimeOnly.ParseExact(EarlyOutAfternoonCutOff.Text, "h:mm tt");
                var lateMorning = TimeOnly.ParseExact(LateMorningCutOff.Text, "h:mm tt");
                var lateAfternoon = TimeOnly.ParseExact(LateAfternoonCutOff.Text, "h:mm tt");

                var settings = new SystemSettingsDto
                {
                    PasswordlessManualAttendance = false,
                    AttendanceType = InOut.Checked ? "IN/OUT" : Full.Checked ? "FULL" : _settings.AttendanceType,
                    EarlyOutEndsMorning = earlyOutEndsMorning.ToString("HH:mm:ss"),
                    EarlyOutEndsAfternoon = earlyOutEndsAfternoon.ToString("HH:mm:ss"),
                    LateStartTimeMorning = lateMorning.ToString("HH:mm:ss"),
                    LateStartTimeAfternoon = lateAfternoon.ToString("HH:mm:ss")
                };

                var apiData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Settings.UpdateSettings, settings);

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    GunaMessage.Info(apiData.Data, "Success");
                    await GetSettings();
                }
                else
                {
                    ToastNotify.Info("Problem occured updating settings, try again later");
                    Console.WriteLine(apiData.ErrorMessage);
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void LoadSettings(SystemSettingsDto data)
        {
            try
            {
                await Task.Run(() =>
                {
                    Invoke((Action)(() =>
                    {
                        var earlyOutEndsMorning = TimeOnly.ParseExact(data.EarlyOutEndsMorning, "HH:mm:ss");
                        var earlyOutEndsAfternoon = TimeOnly.ParseExact(data.EarlyOutEndsAfternoon, "HH:mm:ss");
                        var lateMorning = TimeOnly.ParseExact(data.LateStartTimeMorning, "HH:mm:ss");
                        var lateAfternoon = TimeOnly.ParseExact(data.LateStartTimeAfternoon, "HH:mm:ss");



                        InOut.Checked = (InOut.Text == data.AttendanceType);
                        Full.Checked = (Full.Text == data.AttendanceType);
                        EarlyOutMorningCutoff.Text = earlyOutEndsMorning.ToString("h:mm tt");
                        EarlyOutAfternoonCutOff.Text = earlyOutEndsAfternoon.ToString("h:mm tt");
                        LateAfternoonCutOff.Text = lateAfternoon.ToString("h:mm tt");
                        LateMorningCutOff.Text = lateMorning.ToString("h:mm tt");
                    }));
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            await UpdateSettings();
        }
    }
}
