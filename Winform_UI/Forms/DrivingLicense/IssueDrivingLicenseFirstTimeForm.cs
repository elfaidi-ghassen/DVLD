using DataAccessLayer;
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

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class IssueDrivingLicenseFirstTimeForm : Form
    {
        private int UserID { get; set; }
        private int LocalAppID { get; set; }
        public IssueDrivingLicenseFirstTimeForm(int UserID, int LocalAppID)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.LocalAppID = LocalAppID;
            LoadFormInfo(LocalAppID);
        }
        private void LoadFormInfo(int LocalAppID)
        {
            int ApplicationID = LocalDLApplicationManager.GetApplicationIdByLocalId(LocalAppID);
            applicationInfo1.LoadInfo(ApplicationID);
            drivingLicenseApplicationForm1.LoadInfo(LocalAppID);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LocalManageDLApplication app = LocalDLApplicationManager.GetApplicatioByLocalId(LocalAppID);
            int ApplicationID = LocalDLApplicationManager.GetApplicationIdByLocalId(LocalAppID);
            int PersonID = app.PersonID;

            string notes = richTextBox1.Text;
            int? driverID = null;
            if (DriverManager.PersonIsDriver(PersonID))
            {
                driverID = DriverManager.GetDriverByPersonId(PersonID).DriverID;
            } else
            {
                driverID = DriverManager.AddDriverGetId(PersonID, UserID);
                MessageBox.Show($"A new driver account was opened",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            if (notes == string.Empty) {
                notes = null;
            }
            int? licenseID = DrivingLicenseManager.AddLicense(ApplicationID,
                                            (int)driverID,
                                            notes,
                                            IsActive: true,
                                            IssueReason: enIssueReason.FirstTime,
                                            UserID);
            if (licenseID == null)
            {
                MessageBox.Show("Error: couldn't create the driving license.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Error: Driving License was created ID = {licenseID}.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            Close();
        }
    }
}
