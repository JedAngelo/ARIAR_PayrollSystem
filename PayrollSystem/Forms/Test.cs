using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms
{
    public partial class Test : Form
    {
        private readonly MainForm _mainForm;

        public Test(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
