using ARIAR_PayrollSystem.Forms.Modals;
using ARIAR_PayrollSystem.Forms.Modals.ModalHelpers;
using ARIAR_PayrollSystem.Helpers;
using ARIAR_PayrollSystem.Models;
using Guna.UI2.WinForms;
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
using System.Xml.Linq;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class SystemMaintenance : Form
    {
       
        MainForm _mainForm;
        //TestModal _testModal;
        public readonly HttpClient client = new HttpClient();
        private Dictionary<Guna2TextBox, Tuple<Label, int>> textBoxLabelMap;
        private Guid selectedId;
        public class Employee
        {
            public Guid PersonalId { get; set; }
            public string Fullname { get; set; }
        }
        private Employee _employee;




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

        private void SystemMaintenance_Load(object sender, EventArgs e)
        {
         
        }




        //Textbox and label animation FUCKKKKKKK
        private void TextBox_Enter(object sender, EventArgs e)
        {
            Guna2TextBox guna2TextBox = sender as Guna2TextBox;
            ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, true);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            Guna2TextBox guna2TextBox = sender as Guna2TextBox;
            ControlsHelper.LabelTransition(guna2TextBox, textBoxLabelMap, LabelTransition, false);
        }

        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ControlsHelper.ClearAllTextBoxes(this);
            ControlsHelper.LabelTransitionAll(textBoxLabelMap, LabelTransition);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            ControlsHelper.FocusTextBox(clickedLabel, textBoxLabelMap);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //OverlayForm overlayForm = new OverlayForm(_mainForm);
            //overlayForm.Show(_mainForm);

            //using (FingerPrintEnrollment _enrollmentModal = new FingerPrintEnrollment(_mainForm, _employee)) 
            //{
            //    _enrollmentModal.ShowDialog(_mainForm);
            //}

            //overlayForm.Close();
            FingerPrintEnrollment _enrollmentModal = new FingerPrintEnrollment(_mainForm, _employee);
            ControlsHelper.ShowModal(_mainForm, _enrollmentModal);



        }

        private async void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            OpenFile.Title = "Select Employee Picture";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = OpenFile.FileName;

                // Load image asynchronously
                Image image = await Task.Run(() => Image.FromFile(filePath));

            }
        }



        private async void GetEmployeeInfo()
        {
            try
            {
                var _employeeInfo = await HttpHelper.GetAsync<ApiResponse<List<PersonalInformationDto>>>(ApiEndpointHelper.Employee.GetPersonalInfo);
                
                if (_employeeInfo == null)
                {
                    //GunaMessage.ErrorMessage(_mainForm, "Cannot retrieve employee information!", "ERROR");
                    ToastNotify.Error("No employee record found!");
                    return;
                }
                var employeeData = _employeeInfo.Data.Select(e => new Employee
                {
                    Fullname = $"{e.FirstName} {(string.IsNullOrEmpty(e.MiddleName) ? "" : $"{e.MiddleName[0]}. ")}{e.LastName}",
                    PersonalId = (Guid)e.PersonalId
                }).ToList();

                EmployeeDataGrid.DataSource = employeeData;
            }
            catch (Exception ex)
            {
                GunaMessage.Error($"Error: {ex.Message}", "ERROR");
            }
        }

        private void Biometrics_Click(object sender, EventArgs e)
        {
            GetEmployeeInfo();
        }

        private void SystemMaintenanceTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SystemMaintenanceTabs.SelectedTab.Text == "Biometrics")
            {
                GetEmployeeInfo();
            }
        }

        private void EmployeeDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fullName = EmployeeDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (Guid.TryParse(EmployeeDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString(), out Guid result))
                {
                    _employee = new Employee
                    {
                        PersonalId = result,
                        Fullname = fullName
                    };

                    guna2Button6.Enabled = true;
                }
                else
                {
                    ToastNotify.Error("Invalid Personal ID");
                }

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            EmployeeCanvasModal _canvasModal = new EmployeeCanvasModal();
            ControlsHelper.ShowModal(_mainForm, _canvasModal);
        }
    }
}
