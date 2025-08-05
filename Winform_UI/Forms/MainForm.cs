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
using Winform_UI.Forms;
using Winform_UI.Forms.DetainedLicenses;
using Winform_UI.Forms.Driver;
using Winform_UI.Forms.DrivingLicense;
using Winform_UI.Forms.InternationalLicense;

namespace Winform_UI
{
    public partial class MainForm : Form
    {
        private int UserId { get; set; }
        public MainForm(int id)
        {
            InitializeComponent();
            UserId = id;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeopleForm form = new ManagePeopleForm();
            form.Show();
        }

        private void dEBUGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UsersStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageUsersForm().ShowDialog();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ApplicationTypesForm().Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageTestTypeForm().Show();
        }


        private void ShowDrivingLicenseApplicationForm()
        {
            new DrivingLicenseApplicationForm(UserId).Show();
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrivingLicenseApplicationForm();
        }

        private void localLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ManageLocalDrivingLicenseApplicaions(UserId).ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ManageDriversForm().Show();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddInternationalDrivingLicenseForm(UserId).ShowDialog();

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RenewLocalDrivingLicenseForm(UserId).ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ListInternationalLicenseForm(UserId).ShowDialog();
        }

        private void replaceLostLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReplaceLostDamagedForm(UserId).ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
                    => new ManageDetainedLicenseForm().ShowDialog();

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
                    => new DetainLicenseForm().ShowDialog();

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
                    => new ReleaseLicenseForm().ShowDialog();
    }
}
