using DVLVBusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Winform_UI.Controls;
using Winform_UI.Forms.DrivingLicense;
using Winform_UI.Forms.InternationalLicense;

namespace Winform_UI.Forms.DetainedLicenses
{
    public partial class DetainLicenseForm : Form
    {
        private int UserId;
        public DetainLicenseForm(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
            linkLabelHistory.Enabled = false;
            btnDetain.Enabled = false;

        }

        private void ShowError(string message)
        {
            MessageBox.Show(
            message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            return;
        }
        private void ShowInformation(string message)
        {
            MessageBox.Show(
            message,
            "Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            return;
        }


        private (bool, string) ValidateLicense(int licenseID)
        {
            if (!drivingLicenseControl1.LoadInfoByLicenseID(licenseID))
                return (false, "This Driving License doesn't exist");

            DrivingLicenseCard card = DrivingLicenseManager
                .GetLicenseCardInfoByLicenseId(licenseID);

            
            if (!card.IsActive)
                return (false, "This license is inactive");

            if (card.IsDetained)
                return (false, "This license is already detained");

            return (true, null);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

            (bool, string) isValid = ValidateLicense(GetInputLicenseID());
            if (!isValid.Item1)
            {
                ShowError(isValid.Item2);
                btnDetain.Enabled = false;
                return;
            }

            btnDetain.Enabled = true;
            linkLabelHistory.Enabled = true;
            InitializeDetainInfo(UserId);
        }

        // =====================================================================
        // Helpers
        // =====================================================================
        private int GetInputLicenseID() => (int)inputLicenseID.Value;

        public void InitializeDetainInfo(int UserId)
        {
            DrivingLicenseCard card = DrivingLicenseManager
                .GetLicenseCardInfoByLicenseId(GetInputLicenseID());
            detainInfo1.DetainDate = DateTime.Now;
            detainInfo1.LicenseID = card.LicenseID;
            detainInfo1.CreatedByUserId = UserId;
            detainInfo1.DisplayData();
        }

        // =====================================================================
        // Event Handlers
        // =====================================================================

        private void DetainButtonClicked(object sender, EventArgs e)
        {
            if (detainInfo1.FineAmount == null
                || detainInfo1.FineAmount < 0)
            {
                ShowError("Fine cannot be empty or nonpositive!");
                return;
            }

            int? detainID = DetainedLicensesManager.DetainLicense(
                (int)detainInfo1.LicenseID,
                (DateTime)detainInfo1.DetainDate,
                (decimal)detainInfo1.FineAmount,
                UserId,
                isReleased: false);


            if (detainID == null)
            {
                ShowError("Internal Error: could not detain this license");
            } else
            {
                ShowInformation("The license was detained successfully");
                btnDetain.Enabled = false;
                btnFind.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int appId = DrivingLicenseManager.GetLicenseCardInfoByLicenseId(
                (int)detainInfo1.LicenseID).ApplicationID;
            int localAppId = LocalDLApplicationManager.GetLocalIdByApplicationId(appId);
            int personID = LocalDLApplicationManager
                .GetApplicationByLocalId(localAppId).PersonID;
            new ShowDrivingLicenseHistoryForm(personID).ShowDialog();
        }
    }
}