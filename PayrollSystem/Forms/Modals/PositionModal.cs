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
        public PositionModal()
        {
            InitializeComponent();
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new PostionDto
                {
                    PositionName = PositionTextBox.Text,
                    CreatedBy = "ADMIN"
                };
                await AddPositionAsync(dto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private async Task AddPositionAsync(PostionDto dto)
        {
            try
            {
                var _apiData = await HttpHelper.PostAsync<ApiResponse<string>, dynamic>(ApiEndpoint.Employee.AddPositions, dto);

                if (_apiData == null) throw new HttpRequestException("API returned null");

                if (_apiData.isSuccess)
                {
                    Console.WriteLine(_apiData.Data);
                    GunaMessage.Info("Position added successfully", "Success");
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
