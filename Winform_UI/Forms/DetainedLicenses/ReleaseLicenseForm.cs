using DVLVBusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Winform_UI.Controls;

namespace Winform_UI.Forms.DetainedLicenses
{
    public partial class ReleaseLicenseForm : Form
    {

        private int UserId;
        public ReleaseLicenseForm(int UserId)
        {
            InitializeComponent();
            this.UserId = UserId;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
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


        private void btnFind_Click(object sender, EventArgs e)
        {
            (bool, string) isValid = ValidateLicense(GetInputLicenseID());
            if (!isValid.Item1)
            {
                ShowError(isValid.Item2);
                btnRelease.Enabled = false;
                return;
            }

            btnRelease.Enabled = true;
            InitializeReleaseInfo(UserId);
        }
        private void InitializeReleaseInfo(int UserId)
        {
            decimal appFees = ApplicationTypeManager.GetApplicationTypeById(
                    (int)enApplicationType.ReleaseDetained).ApplicationFees;
            DrivingLicenseCard card = DrivingLicenseManager
                .GetLicenseCardInfoByLicenseId(GetInputLicenseID());
            DetainedRecord detainedRecord = DetainedLicensesManager
                .GetDetainedRecordByLicenseId(card.LicenseID);
            decimal fineFees = detainedRecord.FineFees;
            releaseDetainedApplication1.DetainDate = DateTime.Now;
            releaseDetainedApplication1.LicenseID = card.LicenseID;
            releaseDetainedApplication1.CreatedByUserId = UserId;
            releaseDetainedApplication1.ApplicationFees = appFees;
            releaseDetainedApplication1.FineAmount = fineFees;
            releaseDetainedApplication1.TotalFees = appFees + fineFees;
            releaseDetainedApplication1.DetainID = detainedRecord.DetainID;
            releaseDetainedApplication1.DisplayData();
        }
        private int GetInputLicenseID() => (int)inputLicenseID.Value;

        private (bool, string) ValidateLicense(int licenseID)
        {
            if (!drivingLicenseControl1.LoadInfoByLicenseID(licenseID))
                return (false, "This Driving License doesn't exist");

            DrivingLicenseCard card = DrivingLicenseManager
                .GetLicenseCardInfoByLicenseId(licenseID);


            if (!card.IsActive)
                return (false, "This license is inactive");

            if (!card.IsDetained)
                return (false, "This license is not detained, please choose another one.");

            return (true, null);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            int? applicationID = DetainedLicensesManager.ReleaseLicense(
                (int)releaseDetainedApplication1.LicenseID, UserId);
            if (applicationID == null)
            {
                ShowError("Couldn't release the license");
                return;
            } else
            {
                releaseDetainedApplication1.ReleaseApplicationID = (int)applicationID;
                ShowInformation("The licenses was released");
            }

            btnRelease.Enabled = false;
            inputLicenseID.Enabled = false;
        }
    }
}