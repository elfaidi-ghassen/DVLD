using DataAccessLayer;
using DVLVBusinessLayer;
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

namespace Winform_UI.Forms.InternationalLicense
{
    public partial class RenewLicenseApp : UserControl
    {
        
        public DateTime applicationDate { get; set; }
        public DateTime issueDate { get; set; } 
        public DateTime expirationDate { get; set; }
        public Decimal? applicationFees { get; set; } = null;
        public Decimal? TotalFees { get; set; } = null;
        public Decimal? LicenseFees { get; set; }  = null;
        public int? newLocalApplicationID { get; set; }  = null;

        public int? oldLicenseID { get; set; } = null;
        public int? userId { get; set; } = null;
        public int? RenewLicenseID { get; set; } = null;
        public bool initalized { get; set; } = false;
        public string Notes
        {
            get
            {
                return richTextBox1.Text;
            }
        }
        public RenewLicenseApp()
        {
            InitializeComponent();
        }

        private int GetValidityLengthInYears(int localLicenseId)
        {
            int licenseClassID = (int)DrivingLicenseManager.GetLicenseCardInfoByLicenseId(localLicenseId).LicenseClass;
            return LicenseClassManager.GetLicenseClassById(
                        licenseClassID
                    ).DefaultValidityLength;
        }

        private decimal GetLicenseFees(int localLicenseId)
        {

            int licenseClassID = (int)DrivingLicenseManager
                        .GetLicenseCardInfoByLicenseId(localLicenseId).LicenseClass;
            return LicenseClassManager.GetLicenseClassById(licenseClassID).ClassFees;
        }

        public void InializeControl(int localLicenseId, int userId)
        {
            this.initalized = true;
            this.oldLicenseID = localLicenseId;
            this.userId = userId;
            this.applicationDate = DateTime.Today;
            this.issueDate = DateTime.Today;
            this.expirationDate =
                DateTime.Now.AddYears(GetValidityLengthInYears(localLicenseId));
                


            this.applicationFees = ApplicationTypeManager.GetApplicationTypeById
                            ((int)enApplicationType.RenewLicense).ApplicationFees;
            this.LicenseFees = GetLicenseFees(localLicenseId);


            this.TotalFees = applicationFees + LicenseFees;
            LoadValues();
        }
        public bool LoadValues()
        {
            if (initalized == false)
            {
                return false;
            }

            if (RenewLicenseID != null)
                labelRenewLicenseId.Text = RenewLicenseID.ToString();

            labelAppDate.Text = applicationDate.ToShortDateString();
            labelIssueDate.Text = issueDate.ToShortDateString();

            labelAppFees.Text = applicationFees.ToString();
            labelLicenseFees.Text = LicenseFees.ToString();
            labelTotalFees.Text = TotalFees.ToString();

            if (oldLicenseID != null)
                labelOldLicenseID.Text = oldLicenseID.ToString();

            if (newLocalApplicationID != null)
                labelAppId.Text = newLocalApplicationID.ToString();

            labelExpirationDate.Text = expirationDate.ToShortDateString();
            labelCreatedBy.Text = UserManager.GetUserById((int)userId).UserName;

            return true;
        }
    }
}

