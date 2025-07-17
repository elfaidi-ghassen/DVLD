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

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class ViewLocalDrivingLicenseApplicatiionForm : Form
    {
        private int LocalAppId { get; set; }
        public ViewLocalDrivingLicenseApplicatiionForm(int localAppId)
        {
            InitializeComponent();
            LocalAppId = localAppId;
        }

        private void ViewLocalDrivingLicenseApplicatiionForm_Load(object sender, EventArgs e)
        {
            int appId = LocalDLApplicationManager.GetApplicationIdByLocalId(LocalAppId);
            applicationInfo1.LoadInfo(appId);
            drivingLicenseApplicationForm1.LoadApplication(LocalAppId);
        }

        private void applicationInfo1_Load(object sender, EventArgs e)
        {

        }

        private void drivingLicenseApplicationForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
