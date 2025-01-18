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
        public ApiSwitcher()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HttpHelper.SetApiBasicUri(UriComboBox.Text);
            this.Close();
        }

    }
}
