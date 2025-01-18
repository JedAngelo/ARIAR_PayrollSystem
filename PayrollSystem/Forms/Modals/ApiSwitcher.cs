using PayrollSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Modals
{
    public partial class ApiSwitcher : Form
    {
        private bool IsCustom = false;
        public ApiSwitcher()
        {
            InitializeComponent();
            CurrentUriLabel.Text = $"Current URI: {UriHelper.LoadUri().Uri}";
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            var uri = new AppApiUri();
            if (IsCustom)
            {
                uri = new AppApiUri { Uri = CustomURIBox.Text };
            }
            else
            {
                uri = new AppApiUri { Uri = UriComboBox.Text };
            }
            UriHelper.SaveUri(uri);
            this.Close();
        }

        private void CustomButton_Click_1(object sender, EventArgs e)
        {
            IsCustom = !IsCustom;
            if (IsCustom)
            {
                CustomURIBox.BringToFront();
                CustomButton.Text = "Default URIs";
            }
            else
            {
                CustomURIBox.SendToBack();
                CustomButton.Text = "Custom URI";
            }
        }

        private void ApiSwitcher_Load(object sender, EventArgs e)
        {
        }
    }
}
