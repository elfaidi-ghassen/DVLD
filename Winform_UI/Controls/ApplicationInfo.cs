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
using Winform_UI.Forms;

namespace Winform_UI.Controls
{
    public partial class ApplicationInfo : UserControl
    {
        private int? personID = null;
        public ApplicationInfo()
        {
            InitializeComponent();
        }


        public void LoadInfo(int ApplicationID)
        {
            Util.ApplicationInfo app = ApplicationManager.GetApplicationInfoById(ApplicationID);
            this.personID = app.ApplicantPersonID;
            labelID.Text = app.ApplicationID.ToString();
            labelStatus.Text = app.ApplicationStatus.ToString();
            labelFees.Text = app.PaidFees.ToString();
            labelType.Text = app.ApplicationTypeTitle;
            labelApplicantName.Text = app.ApplicantFullName;
            labelDate.Text = app.ApplicationDate.ToShortDateString();
            labelStatusDate.Text = app.LastStatusDate.ToShortDateString();
            labelCreatedBy.Text = app.CreatedByUserName;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.personID != null)
            {
                new PersonInfoForm((int)personID).ShowDialog();
            }
        }
    }
}
