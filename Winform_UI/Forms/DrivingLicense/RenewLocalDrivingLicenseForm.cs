using DataAccessLayer;
using DVLVBusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Util.DVLVBusinessLayer;

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class RenewLocalDrivingLicenseForm : Form
    {
        private int UserId;
        public RenewLocalDrivingLicenseForm(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
            btnRenew.Enabled = false;
            linkLabelHistory.Enabled = false;
            linkLabelLicense.Enabled = false;
            
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

            renewLicenseApp1.InializeControl(GetInputLicenseID(), UserId);
            btnRenew.Enabled = true;

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

            if (oldCard.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show(
                    "This license hasn't expired yet",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    btnRenew.Enabled = false;
                return;
            }

        }
        private int GetInputLicenseID()
        {
            return Convert.ToInt32(numericInput.Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            int oldLicenseId = (int) renewLicenseApp1.oldLicenseID;
            DrivingLicenseCard oldInfo = 
                DrivingLicenseManager.GetLicenseCardInfoByLicenseId(oldLicenseId);

            int applicantPersonID = DriverManager.GetDriverByDriverId(oldInfo.DriverID).PersonID;

            DateTime applicationDate = renewLicenseApp1.applicationDate;
            int applicationTypeID = (int)enApplicationType.RenewLicense;
            enApplicationStatus applicationStatus = enApplicationStatus.Completed;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = Convert.ToDecimal(renewLicenseApp1.applicationFees);
            int createdByUserID = UserId;
            int? applicationID = ApplicationManager.AddApplication(
                applicantPersonID,
                applicationDate,
                applicationTypeID,
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
                    renewLicenseApp1.Notes,
                    IsActive: true,
                    enIssueReason.Renew,
                    UserId
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
            } else
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
            renewLicenseApp1.RenewLicenseID = (int)newLicenseId;
            renewLicenseApp1.newLocalApplicationID = (int)localApplicationID;
            renewLicenseApp1.LoadValues();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int localAppId = (int)renewLicenseApp1.newLocalApplicationID;
            int personID = LocalDLApplicationManager.GetApplicationByLocalId(localAppId).PersonID;

            new ShowDrivingLicenseHistoryForm(personID).ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ShowDrivingLicenseForm((int)renewLicenseApp1.newLocalApplicationID).ShowDialog();
        }
    }
}
