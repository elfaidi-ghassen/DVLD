using DataAccessLayer;
using DVLVBusinessLayer;
using Microsoft.VisualBasic.ApplicationServices;
using Models;
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
using Util.DVLVBusinessLayer;
using Winform_UI.Debug;
using Winform_UI.Forms.InternationalLicense;

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class ReplaceLostDamagedForm : Form
    {
        private int userId;
        public ReplaceLostDamagedForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ReplaceLostDamagedForm_Load(object sender, EventArgs e)
        {
            btnRenew.Enabled = false;
            linkLabelHistory.Enabled = false;
            linkLabelLicense.Enabled = false;

        }

        private int GetInputLicenseID()
        {
            return Convert.ToInt32(numericInput.Value);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            bool found = drivingLicenseControl
                .LoadInfoByLicenseID(GetInputLicenseID());
            if (!found)
            {
                MessageBox.Show(
                "This Driving License doesn't exist",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }


            DrivingLicenseCard oldCard = DrivingLicenseManager
                .GetLicenseCardInfoByLicenseId(GetInputLicenseID());

            if (oldCard.IsActive == false)
            {
                MessageBox.Show(
                "This license is inactive",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            
            btnRenew.Enabled = true;
            ReloadApplicationDetails();
        }



        // =========================================================
        // Event Handlers
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
                            => ReloadApplicationDetails();
            
       

        private void radLost_CheckedChanged(object sender, EventArgs e)
                            => ReloadApplicationDetails();


        private void btnCancel_Click(object sender, EventArgs e)
                        => Close();

        private void btnRenew_Click(object sender, EventArgs e)
        {
            int oldLicenseId = (int)LostDamagedApplicationControl.OldLicenseID;
            DrivingLicenseCard oldInfo =
                DrivingLicenseManager.GetLicenseCardInfoByLicenseId(oldLicenseId);

            int applicantPersonID = DriverManager.GetDriverByDriverId(oldInfo.DriverID).PersonID;

            DateTime applicationDate = LostDamagedApplicationControl.ApplicationDate;
            enApplicationType applicationType = GetApplicationType();
            enApplicationStatus applicationStatus = enApplicationStatus.Completed;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = (decimal) LostDamagedApplicationControl.ApplicationFees;
            int createdByUserID = userId;
            
            
            int? applicationID = ApplicationManager.AddApplication(
                applicantPersonID,
                applicationDate,
                (int)applicationType,
                applicationStatus,
                lastStatusDate,
                paidFees,
                createdByUserID
                );
            if (applicationID == null)
            {
                MessageBox.Show(
                    "Error: couldn't create an application",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
            // TODO: this should be a "trasaction" and use ROLLBACK in case of errors
            bool wasDisbaled = DrivingLicenseManager.DisableDrivingLicense(oldLicenseId);
            if (!wasDisbaled)
            {
                MessageBox.Show(
                    "Error: couldn't disable the old license",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
            int? localApplicationID = LocalDLApplicationManager
                .CreateApplication((int)applicationID, (int)oldInfo.LicenseClass);

            int? newLicenseId = DrivingLicenseManager.AddLicense(
                    (int)applicationID,
                    oldInfo.DriverID,
                    notes: null,
                    IsActive: true,
                     applicationType == enApplicationType.ReplacementForDamaged 
                     ? enIssueReason.ReplacementForDamaged
                     : enIssueReason.ReplacementForLost,
                    userId
                );

            if (newLicenseId == null)
            {
                MessageBox.Show(
                    "Error: couldn't create a new license",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }
            else
            {
                MessageBox.Show(
                    $"a driving new license was issued {(int)newLicenseId}",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            btnRenew.Enabled = false;
            linkLabelHistory.Enabled = true;
            linkLabelLicense.Enabled = true;
            LostDamagedApplicationControl.ReplacedLicenseID = (int)newLicenseId;
            LostDamagedApplicationControl.NewLocalApplicationID = (int)localApplicationID;
            LostDamagedApplicationControl.DisplayFormValues();
        }
        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int localAppId = (int)LostDamagedApplicationControl.NewLocalApplicationID;
            int personID = LocalDLApplicationManager.GetApplicationByLocalId(localAppId).PersonID;

            new ShowDrivingLicenseHistoryForm(personID).ShowDialog();

        }

        private void linkLabelLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ShowDrivingLicenseForm((int)LostDamagedApplicationControl.NewLocalApplicationID).ShowDialog();

        }


        // =========================================================
        // Helpers
        private enApplicationType GetApplicationType()
        {
            CustomAssert.That(radLost.Checked ^ radDamaged.Checked, 
                "both lost and damaged chechboxes are checked or both are unchecked");

            if (radLost.Checked)
                return enApplicationType.ReplacementForLost;
            else
                return enApplicationType.ReplacementForDamaged;
        }


        private void ReloadApplicationDetails()
        {
            LostDamagedApplicationControl.InializeControlData(
                GetInputLicenseID(),
                userId,
                GetApplicationType());
            LostDamagedApplicationControl.DisplayFormValues();
        }
    }
}
