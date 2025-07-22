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

namespace Winform_UI.Controls
{
    public partial class DrivingLicenseControl : UserControl
    {
        public DrivingLicenseControl()
        {
            InitializeComponent();
        }
        public void LoadInfo(int LocalAppId)
        {
            DrivingLicenseCard info =
                DrivingLicenseManager.GetLicenseCardInfo(LocalAppId);
            labelClass.Text = info.ClassTitle;
            labelName.Text = info.FullName;
            labelDateOfBirth.Text = info.DateOfBirth.ToString();
            labelLicenseID.Text = info.LicenseID.ToString();
            labelNationalNo.Text = info.NationalNo.ToString();
            labelGender.Text = info.Gender.ToString();
            labelIssueDate.Text = info.IssueDate.ToShortDateString();
            labelIssueReason.Text = info.IssueReason.ToString();
            labelNotes.Text = info.Notes == null ? "None" : info.Notes.ToString();
            labelIsActive.Text = info.IsActive ? "Active" : "Inactive";
            labelDateOfBirth.Text = info.DateOfBirth.ToShortDateString();
            labelDriverID.Text = info.DriverID.ToString();
            labelExpDate.Text = info.ExpirationDate.ToShortDateString();
            labelIsDetained.Text = info.IsDetained ? "Yes" : "No";
            pictureBox1.ImageLocation = info.PicturePath;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void DrivingLicenseControl_Load(object sender, EventArgs e)
        {

            
        
        }
    }
}
