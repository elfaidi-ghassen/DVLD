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
using Winform_UI.Debug;

namespace Winform_UI.Controls
{
    public partial class ReplaceLostDamagedApplicationForm : UserControl
    {
        public DateTime ApplicationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Decimal? ApplicationFees { get; set; } = null;
        public int? NewLocalApplicationID { get; set; } = null;

        public int? OldLicenseID { get; set; } = null;
        public int? UserId { get; set; } = null;
        public int? ReplacedLicenseID { get; set; } = null;
        public bool Initialized { get; set; } = false;
        public ReplaceLostDamagedApplicationForm()
        {
            InitializeComponent();
        }
        public void InializeControlData(
            int localLicenseId,
            int userId,
            enApplicationType type)
        {
            this.Initialized = true;
            this.OldLicenseID = localLicenseId;
            this.UserId = userId;
            this.ApplicationDate = DateTime.Today;

            this.ApplicationFees = GetApplicationFees(type);
        }

        public bool DisplayFormValues()
        {
            if (Initialized == false)
                return false;


            if (ReplacedLicenseID != null)
                labelReplacedLicenseId.Text = ReplacedLicenseID.ToString();

            labelAppDate.Text = ApplicationDate.ToShortDateString();

            labelAppFees.Text = ApplicationFees.ToString();

            if (OldLicenseID != null)
                labelOldLicenseID.Text = OldLicenseID.ToString();

            if (NewLocalApplicationID != null)
                labelAppId.Text = NewLocalApplicationID.ToString();


            labelCreatedBy.Text = UserManager.GetUserById((int)UserId).UserName;

            return true;
        }


        // ===========================================================
        // Helpers
        private decimal GetApplicationFees(enApplicationType type)
        {
            return ApplicationTypeManager.GetApplicationTypeById
                            ((int)type).ApplicationFees;
        }


    }
}
