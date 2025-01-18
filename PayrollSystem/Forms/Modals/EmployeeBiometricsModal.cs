using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
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

namespace PayrollSystem.Forms.Modals
{
    public partial class EmployeeBiometricsModal : Form
    {
        private PersonalInformationDisplayDto _employee;
        private List<EmployeeBiometricsDto> _biometrics = new List<EmployeeBiometricsDto>();
        private List<EmployeeBiometricsDto> _selectedBiometrics = new List<EmployeeBiometricsDto>();
        private MainForm _mainForm;

        public List<EmployeeBiometricsDto> SelectedBiometrics
        {
            get { return _selectedBiometrics; }
            set
            {
                _selectedBiometrics = value;
            }
        }

        public EmployeeBiometricsModal(PersonalInformationDisplayDto employee, MainForm mainForm)
        {
            InitializeComponent();
            _employee = employee;
            _mainForm = mainForm;
        }

        private async Task LoadView(List<EmployeeBiometricsDto> data)
        {
            try
            {
                await EmployeeBiometricsView.DataViewAsync(data, this, BiometricsView);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task GetBiometrics(string id)
        {
            try
            {
                var apiData = await HttpHelper.GetAsync<ApiResponse<List<EmployeeBiometricsDto>>>($"{ApiEndpoint.Biometric.GetBiometricsById}/{id}");

                if (apiData == null) throw new HttpRequestException(nameof(apiData) + " returned null");

                if (apiData.isSuccess)
                {
                    _biometrics = apiData.Data;
                    Console.WriteLine("Success fetching biometrics");
                    if (_biometrics.Count == 0)
                    {
                        NullLabel.Visible = true;
                        await LoadView(_biometrics);
                    }
                    else
                    {
                        NullLabel.Visible = false;
                        await LoadView(_biometrics);
                    }
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

        private async void EmployeeBiometricsModal_Load(object sender, EventArgs e)
        {
            await GetBiometrics(_employee.PersonalId.ToString());
            NameLabel.Text = $"Biometric Data:    {_employee.FirstName} {(string.IsNullOrEmpty(_employee.MiddleName) ? "" : $"{_employee.MiddleName[0]}. ")}{_employee.LastName}";
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var fingerprintEnrollment = new FingerPrintEnrollment(_mainForm, _employee);
            ControlsHelper.ShowModal(_mainForm, fingerprintEnrollment);
        }

        private async void RefreshButton_Click(object sender, EventArgs e)
        {
            await GetBiometrics(_employee.PersonalId.ToString());
        }

        private async void RemoveSelected()
        {
            var controls = BiometricsView.Controls.OfType<EmployeeBiometricsView>().Where(x => x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    if (control.InvokeRequired)
                    {
                        control.BeginInvoke((Action)(() =>
                        {
                            control.Selected = false;
                        }));
                    }
                    else
                    {
                        control.Selected = false;
                    }
                }
            });
        }

        private async void SelectAll()
        {
            var controls = BiometricsView.Controls.OfType<EmployeeBiometricsView>().Where(x => !x.Selected).ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    if (control.InvokeRequired)
                    {
                        control.BeginInvoke((Action)(() =>
                        {
                            control.Selected = true;
                        }));
                    }
                    else
                    {
                        control.Selected = true;
                    }
                }
            });
        }


        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            await Task.Delay(300);
            
            if (SelectedBiometrics.Count == 0)
            {
                GunaMessage.Warning("Please select a biometric to delete first", "Try Again");
                return;
            }

            var result = GunaMessage.Question(_mainForm, "Are you sure you want to delete the selected biometric(s)?", "Confirm");

            if (result == DialogResult.Cancel || result == DialogResult.No) return;

            foreach(var biometric in SelectedBiometrics)
            {
                await DeleteBiometric((int)biometric.RecordId);
            }
            await GetBiometrics(_employee.PersonalId.ToString());
            ToastNotify.Success("Selected Biometrics has been deleted");
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private async Task DeleteBiometric(int id)
        {
            try
            {
                var apiData = await HttpHelper.DeleteAsync<ApiResponse<string>>($"{ApiEndpoint.Biometric.DeleteBiometricById}/{id}");
                
                if (apiData == null) throw new HttpRequestException("Delete biometric api endpoint returned null");

                if (apiData.isSuccess)
                {
                    Console.WriteLine(apiData.Data);
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

        private void RegiserButton_Click(object sender, EventArgs e)
        {
            var fingerprintEnrollment = new FingerPrintEnrollment(_mainForm, _employee);
            ControlsHelper.ShowModal(_mainForm, fingerprintEnrollment);
        }
    }
}
