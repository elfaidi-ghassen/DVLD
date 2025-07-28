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

namespace Winform_UI.Forms.InternationalLicense
{
    public partial class InternationalLicenseControl : UserControl
    {
        public InternationalLicenseControl()
        {
            InitializeComponent();
        }

        private void labelNationalNo_Click(object sender, EventArgs e)
        {

        }
        private void LoadInfo(InternationalDrivingLicenseCard info)
        {
            labelName.Text = info.FullName;
            labelDateOfBirth.Text = info.DateOfBirth.ToString();
            labelLicenseID.Text = info.LicenseID.ToString();
            labelNationalNo.Text = info.NationalNo.ToString();
            labelGender.Text = info.Gender.ToString();
            labelIssueDate.Text = info.IssueDate.ToShortDateString();
            labelIsActive.Text = info.IsActive ? "Active" : "Inactive";
            labelDateOfBirth.Text = info.DateOfBirth.ToShortDateString();
            labelDriverID.Text = info.DriverID.ToString();
            labelExpDate.Text = info.ExpirationDate.ToShortDateString();
            pictureBox1.ImageLocation = info.PicturePath;
            labelInternationalID.Text = info.InternationalLicenseID.ToString();
            labelAppId.Text = info.AppId.ToString();
        }

        public void LoadInfoByLicenseID(int licenseID)
        {
            InternationalDrivingLicenseCard info = InternationalLicenseManager
                .GetInterLicenseCardInfoByLicenseID(licenseID);
            LoadInfo(info);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
