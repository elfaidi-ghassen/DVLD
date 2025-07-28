using DataAccessLayer;
using DVLVBusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
using Winform_UI.Forms.DrivingLicense;

namespace Winform_UI.Forms.InternationalLicense
{
    public partial class AddInternationalDrivingLicenseForm : Form
    {
        private int UserID;
        private int DriverId;
        public AddInternationalDrivingLicenseForm(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            btnAdd.Enabled = false;
            btnHistory.Enabled = false;
            btnShow.Enabled = false;
        }

        private void AddInternationalDrivingLicenseForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int localLicenseId = (int)guna2NumericUpDown1.Value;
            if (DrivingLicenseManager.LicenseExists(localLicenseId) == false)
            {
                MessageBox.Show(
                    "This Driving License doesn't exist",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            int? driverID = DrivingLicenseManager.GetDriverID(localLicenseId);
            if (driverID == null)
            {
                MessageBox.Show(
                        "There was an error loading the driver ID",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            this.DriverId = (int)driverID;
        

            DrivingLicenseCard license = DrivingLicenseManager
                .GetLicenseCardInfoListByLicenseID(localLicenseId);
            if (license.LicenseClass != enLicenseClass.Class3)
            {
                MessageBox.Show(
                    "This license is not of class 3",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (license.IsActive == false)
            {
                MessageBox.Show(
                        "The license is not active.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            if (InternationalLicenseManager.HasActiveLicense((int)driverID))
            {
                MessageBox.Show(
                "Already has an active international license.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            drivingLicenseControl1.LoadInfoByLicenseID(localLicenseId);
            internationalApplicationInfo1.InializeControl(localLicenseId, (int)UserID);
            btnAdd.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (int?, int?)? applicationLicensePair = InternationalLicenseManager.CreateLicense(
                DriverManager.GetDriverByDriverId(DriverId).PersonID,
                DriverId,
                internationalApplicationInfo1.applicationDate,
                internationalApplicationInfo1.issueDate,
                (decimal)internationalApplicationInfo1.fees,
                (int)internationalApplicationInfo1.localLicenseiD,
                internationalApplicationInfo1.expirationDate,
                (int)internationalApplicationInfo1.userId
             );
            if (applicationLicensePair == null)
            {
                MessageBox.Show(
                "Error: Couldn't create a new license.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                "A new license was added succesfully.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                btnAdd.Enabled = false;
                internationalApplicationInfo1.applicationID = applicationLicensePair.Value.Item1;
                internationalApplicationInfo1.internationalLicenseID = applicationLicensePair.Value.Item2;
                internationalApplicationInfo1.LoadValues();
                btnShow.Enabled = true;
                btnHistory.Enabled = true;
                guna2NumericUpDown1.Enabled = false;
            }

        }

        private void linkLabelViewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void showLicense_Click(object sender, EventArgs e)
        {
            int licenseId = (int)internationalApplicationInfo1.internationalLicenseID;
            new ShowInternationalLicenseForm(licenseId).ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            int personID = DriverManager.GetDriverByDriverId(DriverId).PersonID;
            new ShowDrivingLicenseHistoryForm(personID).ShowDialog();
        }
    }
}
