using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARIAR_PayrollSystem.Forms
{
    public partial class SystemMaintenance : Form
    {
        MainForm _mainForm;

        public SystemMaintenance(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            guna2DateTimePicker1.CustomFormat = "MMMM d, yyyy";
        }

       
    }
}
