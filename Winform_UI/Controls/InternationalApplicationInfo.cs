using DVLVBusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_UI.Debug;

namespace Winform_UI.Controls
{
    public partial class InternationalApplicationInfo : UserControl
    {
        public DateTime applicationDate;
        public DateTime issueDate;
        public DateTime expirationDate;
        public Decimal? fees = null;
        public int? applicationID = null;
        public int? internationalLicenseID = null;
        public int? localLicenseiD = null;
        public int? userId = null;
        public bool initalized = false;
        public InternationalApplicationInfo()
        {
            InitializeComponent();

        }
        public void InializeControl(int localLicenseId, int userId)
        {
            this.initalized = true;
            this.localLicenseiD = localLicenseId;
            this.userId = userId;
            this.applicationDate = DateTime.Today;
            this.issueDate = DateTime.Today;
            this.expirationDate = DateTime.Today.AddYears(1);
            this.fees = ApplicationTypeManager.GetApplicationTypeById
                            ((int)enApplicationType.InternationalLicense).ApplicationFees;
            LoadValues();
        }
        public bool LoadValues()
        {
            if (initalized == false)
            {
                return false;
            }
            
            if (applicationID != null)
            {
                labelInterAppId.Text = ((int)applicationID).ToString();
            }
            
            if (internationalLicenseID != null)
            {
                labelInterAppId.Text = ((int)internationalLicenseID).ToString();
            }

            labelAppDate.Text = applicationDate.ToShortDateString();
            labelIssueDate.Text = issueDate.ToShortDateString();
            labelFees.Text = fees.ToString();
            labelLocalLicenseId.Text = localLicenseiD.ToString();
            labelExpirationDate.Text = expirationDate.ToShortDateString();
            labelCreatedBy.Text = UserManager.GetUserById((int)userId).UserName;

            return true;
        }


    
        public void CreateLicense()
        {
            
        }
        private void labelClass_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
        private void InternationalApplicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
