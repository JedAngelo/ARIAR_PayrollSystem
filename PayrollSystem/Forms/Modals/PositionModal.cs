using PayrollSystem.Forms.Modals;
using PayrollSystem.Helpers;
using PayrollSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class PositionModal : Form
    {
        private PositionDisplayDto? _position;
        private MainForm _mainForm;
        public PositionModal(MainForm mainForm, PositionDisplayDto? position = null)
        {
            InitializeComponent();
            _position = position;
            if (_position != null)
            {
                PositionTextBox.Text = _position.PositionName;
                TitleLabel.Text = "Update Position";
            }
            _mainForm = mainForm;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new PostionDto();
                if (_position != null)
                {
                    dto = new PostionDto
                    {
                        PositionId = _position.PositionId,
                        PositionName = PositionTextBox.Text,
                        CreatedBy = _position.CreatedBy,
                        ModifiedBy = _mainForm.UserData.UserName
                    };
                }
                else
                {
                    dto = new PostionDto
                    {
                        PositionName = PositionTextBox.Text,
                        CreatedBy = _mainForm.UserData.UserName
                    };
                }
                await AddOrUpdatePositionAsync(dto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private async Task AddOrUpdatePositionAsync(PostionDto dto)
        {
            try
            {
                var _apiData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Employee.AddPositions, dto);

                if (_apiData == null) throw new HttpRequestException("API returned null");

                if (_apiData.isSuccess)
                {
                    GunaMessage.Info(_apiData.Data, "Success");
                }
                else
                {
                    Console.WriteLine(_apiData.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
