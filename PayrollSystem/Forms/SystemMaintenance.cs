﻿using PayrollSystem.Forms.Modals;
using PayrollSystem.Forms.Modals.ModalHelpers;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
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
using System.Media;
using System.Speech.Synthesis;

namespace PayrollSystem.Forms
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
        private List<UsersDto> _users = new List<UsersDto>();
        private PositionDisplayDto _selectedPosition;

        public PositionDisplayDto SelectedPosition
        {
            get { return _selectedPosition; }
            set
            {
                _selectedPosition = value;
            }
        }

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


        private async void SystemMaintenance_Load(object sender, EventArgs e)
        {
            await _mainForm.GetSettingsAsync();
            SetSettings = _mainForm.Settings;
        }
    
        public void RemoveSelectedPosition()
        {
            var control = PositionDataView.Controls.OfType<PositionView>().FirstOrDefault(x => x.Selected);
            if (control != null) control.Selected = false;
        }


        private async void SystemMaintenanceTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SystemMaintenanceTabs.SelectedTab.Name == "Positions")
            {
                await GetPositionData();
            }
            if (SystemMaintenanceTabs.SelectedTab.Name == "SystemSettings")
            {
                await _mainForm.GetSettingsAsync();
                SetSettings = _mainForm.Settings;
            }
            if (SystemMaintenanceTabs.SelectedTab.Name == "UserManagement")
            {
                await GetUsers();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var fingerprintEnrollment = new FingerPrintEnrollment(_mainForm, _employee);
            ControlsHelper.ShowModal(_mainForm, fingerprintEnrollment);
        }

        private async void AddPosition_Click(object sender, EventArgs e)
        {
            var addPosition = new PositionModal(_mainForm);
            using (addPosition)
            {
                ControlsHelper.ShowModal(_mainForm, addPosition);
            }
            await GetPositionData();
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
                    await PositionView.DataViewAsync(_positionList, this, PositionDataView);
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
            var controls = PositionDataView.Controls.OfType<PositionView>().ToList();

            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    // Calculate the new width
                    int newWidth = PositionDataView.ClientSize.Width - 13;

                    // Update the control on the UI thread
                    PositionDataView.Invoke((Action)(() =>
                    {
                        control.Width = newWidth;
                    }));
                }
            });
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
                    AttendanceType = (InOut.Checked, Full.Checked) switch
                    {
                        (true, _) => "IN/OUT",
                        (false, true) => "FULL",
                        _ => _settings.AttendanceType
                    },
                    EarlyOutEndsMorning = earlyOutEndsMorning.ToString("HH:mm:ss"),
                    EarlyOutEndsAfternoon = earlyOutEndsAfternoon.ToString("HH:mm:ss"),
                    LateStartTimeMorning = lateMorning.ToString("HH:mm:ss"),
                    LateStartTimeAfternoon = lateAfternoon.ToString("HH:mm:ss"),
                    DeductLate = LateTrue.Checked ? true : false,
                    DeductUnderTime = UndertimeTrue.Checked ? true : false,
                    TTSVoice = FemaleTTS.Checked ? "Microsoft Zira Desktop" : "Microsoft David Desktop",
                    LateDeductionPerMinute = Decimal.Parse(LateDeductionBox.Text),
                    UndertimeDeductionPerHour = Decimal.Parse(UndertimeDeductionBox.Text)
                };

                var apiData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Settings.UpdateSettings, settings);

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    GunaMessage.Info(apiData.Data, "Success");
                    await _mainForm.GetSettingsAsync();
                    SetSettings = _mainForm.Settings;
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
                        LateTrue.Checked = data.DeductLate;
                        LateFalse.Checked = !data.DeductLate;
                        UndertimeTrue.Checked = data.DeductUnderTime;
                        UndertimeFalse.Checked = !data.DeductUnderTime;
                        if (data.TTSVoice == "Microsoft Zira Desktop")
                        {
                            FemaleTTS.Checked = true;
                        }
                        else if (data.TTSVoice == "Microsoft David Desktop")
                        {
                            MaleTTS.Checked = true;
                        }
                        LateDeductionBox.Text = data.LateDeductionPerMinute.ToString("F1");
                        UndertimeDeductionBox.Text = data.UndertimeDeductionPerHour.ToString("F1");
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

        private async Task GetUsers()
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<UsersDto>>>(ApiEndpoint.Auth.GetUsers);

                if (apiData == null) throw new HttpRequestException("Failed fetching user data(s)");

                if (apiData.isSuccess)
                {
                    _users = apiData.Data.Where(x => x.UserName != "attendance").ToList();
                    await UserView.DataViewAsync(_mainForm, _users, this, UsersView);
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

        private void RegisterButton_Click_1(object sender, EventArgs e)
        {
            var userModal = new UserModal();
            using (userModal)
            {
                ControlsHelper.ShowModal(_mainForm, userModal);
            }
            RefreshUsers();
        }

        private async void UsersView_SizeChanged(object sender, EventArgs e)
        {
            var controls = UsersView.Controls.OfType<UserView>().ToList();

            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    // Calculate the new width
                    int newWidth = UsersView.ClientSize.Width - 13;

                    // Update the control on the UI thread
                    UsersView.Invoke((Action)(() =>
                    {
                        control.Width = newWidth;
                    }));
                }
            });
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshUsers();
        }

        public async void RefreshUsers()
        {
            await GetUsers();
        }

        private void InOut_Click(object sender, EventArgs e)
        {
            InOut.Checked = true;
            Full.Checked = false;
        }

        private void Full_Click(object sender, EventArgs e)
        {
            InOut.Checked = false;
            Full.Checked = true;
        }

        private void LateTrue_Click(object sender, EventArgs e)
        {
            LateFalse.Checked = false;
            LateTrue.Checked = true;
        }

        private void LateFalse_Click(object sender, EventArgs e)
        {
            LateFalse.Checked = true;
            LateTrue.Checked = false;
        }

        private void UndertimeTrue_Click(object sender, EventArgs e)
        {
            UndertimeTrue.Checked = true;
            UndertimeFalse.Checked = false;
        }

        private void UndertimeFalse_Click(object sender, EventArgs e)
        {
            UndertimeTrue.Checked = false;
            UndertimeFalse.Checked = true;
        }

        private async void UpdatePositionButton_Click(object sender, EventArgs e)
        {
            if (SelectedPosition == null)
            {
                ToastNotify.Warning("Please select a position to modify first");
                return;
            }
            var updatePosition = new PositionModal(_mainForm, SelectedPosition);
            using (updatePosition)
            {
                ControlsHelper.ShowModal(_mainForm, updatePosition);
            }
            await GetPositionData();
        }

        private async void DeletePositionButton_Click(object sender, EventArgs e)
        {
            if (SelectedPosition == null)
            {
                ToastNotify.Warning("Please select a position to delete first");
                return;
            }
            var result = GunaMessage.Question(_mainForm, "Are you sure you want to delete this position?", "Confirm");
            if (result == DialogResult.Cancel || result == DialogResult.No) return;

            if (SelectedPosition.EmployeeCount > 0)
            {
                ToastNotify.Warning("Can't delete position, there is some employees set!");
                return;
            }

            await DeletePosition();
            await GetPositionData();
        }

        private async Task DeletePosition()
        {
            try
            {
                var apiDelete = await HttpHelper.DeleteAsync<ApiResponse<string>>($"{ApiEndpoint.Employee.DeletePosition}/{SelectedPosition.PositionId}");
                if (apiDelete == null) throw new HttpRequestException("Error deleting position, try again later");

                if (apiDelete.isSuccess)
                {
                    ToastNotify.Success(apiDelete.Data);
                }
                else
                {
                    ToastNotify.Warning(apiDelete.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void MaleTTS_Click(object sender, EventArgs e)
        {
            MaleTTS.Checked = true;
            FemaleTTS.Checked = false;
        }

        private void FemaleTTS_Click(object sender, EventArgs e)
        {
            MaleTTS.Checked = false;
            FemaleTTS.Checked = true;
        }

        private void DeductionBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void LateDeductionBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
