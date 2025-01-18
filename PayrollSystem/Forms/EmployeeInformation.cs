using PayrollSystem.Forms.ChildrenForm;
using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using PayrollSystem.UserControls;
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

namespace PayrollSystem.Forms
{
    public partial class EmployeeInformation : Form
    {
        MainForm _mainForm;
        EmployeeDetails _employeeDetails;
        CustomMessageBox _MessageBox;
        private List<PersonalInformationDisplayDto> _employeesRaw;
        private List<PersonalInformationDisplayDto> _employees;
        private List<object> _personalData;
        private EmployeeView _employeeView;
        private int _viewCount;
        private int _skipCount;
        private int _currentPage;
        private int _maxPage;

        private bool _employeeAscending = false;
        private bool _positionAscending = false;
        private bool _emailAscending = false;
        private bool _activeAscending = false;

        public static List<string> MaritalStatusFilter { get; set; } = new List<string>();
        public static List<string> PositionFilter { get; set; } = new List<string>();
        public static List<string> ActiveStatusFilter { get; set; } = new List<string>();
        public static List<string> GenderFilter { get; set; } = new List<string>();


        // 1. Delegate and Event for Both Changes
        public delegate void CountChangedEventHandler(object sender, CountChangedEventArgs e);
        public event CountChangedEventHandler CountChanged;

        //2. Event Data class
        public class CountChangedEventArgs : EventArgs
        {
            public int OldValue { get; }
            public int NewValue { get; }
            public string PropertyName { get; } // added property name

            public CountChangedEventArgs(int oldValue, int newValue, string propertyName)
            {
                OldValue = oldValue;
                NewValue = newValue;
                PropertyName = propertyName; //added property name
            }
        }


        // Properties (with the setter event trigger)
        public int ViewCount
        {
            get { return _viewCount; }
            set
            {
                int oldValue = _viewCount;
                if (value != oldValue)
                {
                    _viewCount = value;
                    OnCountChanged(new CountChangedEventArgs(oldValue, value, nameof(ViewCount))); // Added name of property
                }
            }
        }

        public int SkipCount
        {
            get { return _skipCount; }
            set
            {
                int oldValue = _skipCount;
                if (value != oldValue)
                {
                    _skipCount = value;
                    OnCountChanged(new CountChangedEventArgs(oldValue, value, nameof(SkipCount)));  //Added name of property
                }
            }
        }
        private int CurrentPage
        {
            get { return _currentPage; }
            set
            {
                if (_currentPage == value) return;
                Console.WriteLine($"Current page change to {value}");
                _currentPage = value;
                SkipCount = (_currentPage - 1) * ViewCount;
                CurrentPageLabel.Text = _currentPage.ToString();
            }
        }

        private void CalculateMaxPage()
        {
            if (_employees == null)
            {
                _maxPage = 0;
                return;
            }
            _maxPage = (int)Math.Ceiling((double)_employees.Count / ViewCount);
        }


        protected virtual void OnCountChanged(CountChangedEventArgs e)
        {
            CountChanged?.Invoke(this, e);
        }

        private void HandleCountChanged(object sender, CountChangedEventArgs e)
        {
            Console.WriteLine($"{e.PropertyName} changed from {e.OldValue} to {e.NewValue}.");
            FillEmployeeView(_employees);
        }



        private const int SB_BOTH = 3; // Both scroll bars

        public EmployeeInformation(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _employeeDetails = new EmployeeDetails();
            //DisplayPersonalInfo();
            TimeLabel.Text = DateTime.Now.ToString("t");
            DateLabel.Text = DateTime.Now.Date.ToString("dddd, MMMM d, yyyy");
            TimerProcess.Start();
            EmployeeTableView.VerticalScroll.Visible = false;
            EmployeeTableView.VerticalScroll.Maximum = 0;
            ViewCount = 10;
            SkipCount = 0;
            _currentPage = 1;
            CountChanged += HandleCountChanged;

        }


        private async void FillEmployeeView(List<PersonalInformationDisplayDto> data)
        {
            try
            {
                CalculateMaxPage();
                var paginatedData = data.Skip(SkipCount).Take(ViewCount).ToList();
                PageCountLabel.Text = data.Count == 0 ? "0 of 0" :
                                      _currentPage == _maxPage ? $"{SkipCount + 1} - {data.Count} of {data.Count}" :
                                      $"{SkipCount + 1} - {ViewCount + SkipCount} of {data.Count}";
                CurrentPageLabel.Text = _currentPage.ToString();
                ProgressCircle.Value = 0;
                ProgressCircle.Minimum = 0;
                ProgressCircle.Maximum = data.Count;
                await EmployeeView.DataViewAsync(_mainForm, paginatedData, EmployeeTableView);

                for (int i = 0; i < data.Count; i++)
                {
                    ProgressCircle.Value = i + 1;
                    await Task.Delay(25);
                }
                ProgressCircle.Visible = false; 
                RefreshButton.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<ApiResponse<List<PersonalInformationDisplayDto>>> RetrieveEmployeeData()
        {
            try
            {
                return await HttpHelper.GetAsync<ApiResponse<List<PersonalInformationDisplayDto>>>(ApiEndpoint.Employee.GetPersonalInfo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private async Task PopulateEmployeeTable()
        {
            try
            {
                RefreshButton.Visible = false;
                ProgressCircle.Visible = true;
                _currentPage = 1;
                _skipCount = 0;
                var employeeData = await RetrieveEmployeeData();
                EmployeeTableView.Visible = false;

                if (employeeData == null)
                {
                    GunaMessage.Error("No employee data found!", "ERROR");
                    EmployeeTableView.Controls.Clear();
                    EmployeeTableView.Visible = true;
                    ProgressCircle.Visible = false;
                    return;
                }

                if (employeeData.isSuccess)
                {
                    _employeesRaw = employeeData.Data;
                    _employees = employeeData.Data;
                    _mainForm.EmployeeInfo = employeeData.Data;
                    FillEmployeeView(_employees);
                }
                else
                {
                    GunaMessage.Error(employeeData.ErrorMessage, "ERROR");
                }
            }
            catch (Exception ex)
            {
                GunaMessage.Error(ex.Message, "ERROR");
            }
            finally
            {
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

        private void EmployeeDataGrid_Leave(object sender, EventArgs e)
        {
            //EmployeeDataGrid.ClearSelection();
        }
        

        private async void EmployeeInformation_Load(object sender, EventArgs e)
        {
            await PopulateEmployeeTable();

        }

        private async void EmployeeTableView_SizeChanged(object sender, EventArgs e)
        {
            var controls = EmployeeTableView.Controls.OfType<EmployeeView>().ToList();
            await Task.Run(() =>
            {
                foreach (var control in controls)
                {
                    // Calculate the new width
                    int newWidth = EmployeeTableView.ClientSize.Width - 13;

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
            PersonalInformationDto employee = new PersonalInformationDto();
            EmployeeCanvasModal _canvasModal = new EmployeeCanvasModal(employee, _mainForm);
            using (_canvasModal)
            {
                ControlsHelper.ShowModal(_mainForm, _canvasModal);
            }
            await PopulateEmployeeTable();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage == _maxPage) return;
            CurrentPage += 1;
        }

        private void BackPageButton_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 1) return;
            CurrentPage -= 1;
        }

        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            CurrentPage = _maxPage;
        }
        
        private void CurrentPageLabel_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CurrentPageLabel.Text)) return;
            var page = int.Parse(CurrentPageLabel.Text);
            if (page > _maxPage) 
            { 
                GunaMessage.Warning($"Page doesn't exist", "Warning");
                CurrentPage = 1;
                return;
            }
            CurrentPage = page;
        }

        private void CurrentPageLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                // 1. Get the current text box text
                string currentText = CurrentPageLabel.Text;

                // 2. Get the current caret (cursor) position
                int caretPosition = CurrentPageLabel.SelectionStart;

                // 3. Construct the potential new text by inserting the key press
                string potentialNewText = currentText.Insert(caretPosition, e.KeyChar.ToString());

                // 4. Check if the combined text would result in a valid value
                if (int.TryParse(potentialNewText, out int newPageNumber))
                {
                    //5. Check leading zeroes and reject zero
                    if (potentialNewText.Length > 1 && potentialNewText[0] == '0')
                    {
                        e.Handled = true; // Prevent leading zeros if more than one character
                    }
                    else if (newPageNumber > _maxPage || newPageNumber < 1)
                    {
                        e.Handled = true; // Ignore if out of max page range
                    }
                }
                else
                {
                    e.Handled = true; // Ignore if it cannot be parsed into an integer
                }
            }
            else if (e.KeyChar != '\b') // Allow backspace
            {
                e.Handled = true; // Ignore all non-digits, except for backspace
            }
        }
        private void ViewCountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewCount = int.Parse(ViewCountComboBox.SelectedItem.ToString());
            CurrentPage = 1;
        }

        

        private async void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                await Task.Delay(500);
                if (String.IsNullOrEmpty(SearchBox.Text))
                {
                    _employees = _employeesRaw;
                    FillEmployeeView(_employees);
                    return;
                }

                var filter = SearchBox.Text.ToLower();
                //FilterPersonnel(guna2TextBox1.Text);
                _employees = _employeesRaw.Where
                (
                    x => $"{x.FirstName} {(String.IsNullOrEmpty(x.MiddleName) ? "" : $"{x.MiddleName[0]}. ")}{x.LastName}".ToLower().Contains(filter)
                ).ToList();
                FillEmployeeView(_employees);

                
            }
        }

        private void SetFilterButton_Click(object sender, EventArgs e)
        {
            SetFilterModal filterModal = new SetFilterModal(this);
            ControlsHelper.ShowModal(_mainForm, filterModal);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private async void EmployeeSort_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            if (_employeeAscending) _employees = _employees.OrderByDescending(x => x.FirstName).ToList();
            else _employees = _employees.OrderBy(x => x.FirstName).ToList();
            _employeeAscending = !_employeeAscending;
            FillEmployeeView(_employees);
        }

        private async void PositionSort_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            if (_positionAscending) _employees = _employees.OrderByDescending(x => x.PositionName).ToList();
            else _employees = _employees.OrderBy(x => x.PositionName).ToList();
            _positionAscending = !_positionAscending;
            FillEmployeeView(_employees);
        }

        private async void EmailSort_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            if (_emailAscending) _employees = _employees.OrderByDescending(x => x.Email).ToList();
            else _employees = _employees.OrderBy(x => x.Email).ToList();
            _emailAscending = !_emailAscending;
            FillEmployeeView(_employees);
        }

        private async void ActiveSort_Click(object sender, EventArgs e)
        {
            await Task.Delay(250);
            if (_activeAscending) _employees = _employees.OrderByDescending(x => x.IsActive).ToList();
            else _employees = _employees.OrderBy(x => x.IsActive).ToList();
            _activeAscending = !_activeAscending;
            FillEmployeeView(_employees);
        }

        public void ApplyFilter()
        {
            try
            {
                _employees = _employeesRaw;

                if (PositionFilter.Count > 0)
                {
                    _employees = _employeesRaw.Where(x => PositionFilter.Contains(x.PositionName.ToLower())).ToList();
                }

                if (GenderFilter.Count > 0)
                {
                    _employees = _employees.Where(x => GenderFilter.Contains(x.Gender.ToLower())).ToList();
                }
                
                if (MaritalStatusFilter.Count > 0)
                {
                    _employees = _employees.Where(x => MaritalStatusFilter.Contains(x.MaritalStatus.ToLower())).ToList();
                }
                
                if (ActiveStatusFilter.Contains("active") && ActiveStatusFilter.Count == 1)
                {
                    _employees = _employees.Where(x => x.IsActive).ToList();
                }
                else if (ActiveStatusFilter.Contains("inactive") && ActiveStatusFilter.Count == 1)
                {
                    _employees = _employees.Where(x => !x.IsActive).ToList();
                }

                FillEmployeeView(_employees); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            TestModal test = new TestModal();
            ControlsHelper.ShowModal(_mainForm, test);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        public async void RefreshView()
        {
            await PopulateEmployeeTable();
        }
    }
}
