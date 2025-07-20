using DVLVBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace Winform_UI.Controls
{
    public partial class DrivingLicenseApplicationForm : UserControl
    {
        public DrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }

        public void LoadInfo(int localAppId)
        {
            LocalManageDLApplication app = LocalDLApplicationManager.GetApplicatioByLocalId(localAppId);
            labelID.Text = app.LocalApplicationID.ToString();
            labelPassedTests.Text = $"{app.PassedTests}/3";
            labelClass.Text = app.DrivingLicenseClassTitle;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
