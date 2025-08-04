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
using Winform_UI.Forms.InternationalLicense;

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class ReplaceLostDamagedForm : Form
    {
        public ReplaceLostDamagedForm(int UserId)
        {
            InitializeComponent();
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


        }
    }
}
