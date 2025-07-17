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
using Util.DVLVBusinessLayer;

namespace Winform_UI.Forms.DrivingLicense
{
    enum enLocalLicenseFilterOption
    {
        None, NationalNo, Status
    }
    public partial class ManageLocalDrivingLicenseApplicaions : Form
    {
        private int UserId { get; set; }
        public ManageLocalDrivingLicenseApplicaions(int userId)
        {
            InitializeComponent();
            this.UserId = userId;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void InitColumns()
        {
            dgvData.Columns.Add("Column1", "L.DL. ID");
            dgvData.Columns.Add("Column2", "Driving Class");
            dgvData.Columns.Add("Column3", "National No.");
            dgvData.Columns.Add("Column4", "Full Name");
            dgvData.Columns.Add("Column4", "Application Date");
            dgvData.Columns.Add("Column4", "Passed tests");
            dgvData.Columns.Add("Column4", "Status");
        }

        private string FilterOptionToString(enLocalLicenseFilterOption option)
        {
            switch (option)
            {
                case enLocalLicenseFilterOption.None:
                    return "All";
                case enLocalLicenseFilterOption.NationalNo:
                    return "National Number";
                case enLocalLicenseFilterOption.Status:
                    return "Status";
                default:
                    return string.Empty;
            }
        }

        private enLocalLicenseFilterOption StringToFilterOption(string optionString)
        {
            switch (optionString.ToUpper())
            {
                case "ALL":
                    return enLocalLicenseFilterOption.None;
                case "NATIONAL NUMBER":
                    return enLocalLicenseFilterOption.NationalNo;
                case "STATUS":
                    return enLocalLicenseFilterOption.Status;
                default:
                    return enLocalLicenseFilterOption.None;
            }
        }

        private enApplicationStatus StringToStatusOption(string optionString)
        {
            switch (optionString.ToUpper())
            {
                case "ALL":
                    return enApplicationStatus.None;
                case "NEW":
                    return enApplicationStatus.New;
                case "CANCELED":
                    return enApplicationStatus.Canceled;
                case "COMPLETED":
                default:
                    return enApplicationStatus.Completed;
            }
        }private string StatusToString(enApplicationStatus option)
        {
            switch (option)
            {
                case enApplicationStatus.New:
                    return "New";
                case enApplicationStatus.Canceled:
                    return "Canceled";
                case enApplicationStatus.Completed:
                    return "Completed";
                case enApplicationStatus.None:
                    return "All";
                default:
                    return string.Empty;
            }
        }


        private void InitFiltersComboBox()
        {
            foreach (enLocalLicenseFilterOption option 
                    in Enum.GetValues(typeof(enLocalLicenseFilterOption)))
            {
                string displayText = FilterOptionToString(option);
                filterCombo.Items.Add(displayText);
            }
            filterCombo.SelectedIndex = 0;
        }

        private void InitFilterStatusCombo()
        {
            foreach (enApplicationStatus option in Enum.GetValues(typeof(enApplicationStatus)))
            {
                string displayText = StatusToString(option);
                filterStatusCombo.Items.Add(displayText);
            }
            filterStatusCombo.SelectedIndex = 0;
        }


        private void LoadLocalDrivingApplications(List<LocalManageDLApplication> applications)
        {
            dgvData.Rows.Clear();

            foreach (LocalManageDLApplication localApp in applications)
            {
                dgvData.Rows.Add(localApp.LocalApplicationID,
                                 localApp.DrivingLicenseClassTitle,
                                 localApp.NationalNo,
                                 localApp.FullName,
                                 localApp.ApplicationDate,
                                 localApp.PassedTests,
                                 ((enApplicationStatus)localApp.Status));
            }
        }
        private void LoadApplications()
        {
            LoadLocalDrivingApplications(LocalDLApplicationManager.GetApplications());
        }
        private void UpdateCountLabel()
        {
            labelCountRecords.Text = $"# Records: {dgvData.RowCount}";
        }
        private void HideAllFilterInputs()
        {
            filterTextBox.Visible = false;
            filterNumber.Visible = false;
            filterStatusCombo.Visible = false;
        }
        private void ManageLocalDrivingLicenseApplicaions_Load(object sender, EventArgs e)
        {
            HideAllFilterInputs();
            InitColumns();
            InitFiltersComboBox();
            InitFilterStatusCombo();
            LoadApplications();
            UpdateCountLabel();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StringToFilterOption(filterCombo.Text))
            {
                //case enLocalLicenseFilterOption.NationalNoUserID:
                //case enLocalLicenseFilterOption.PersonID:
                //    HideAllFilterInputs();
                //    filterNumber.Visible = true;
                //    break;

                case enLocalLicenseFilterOption.NationalNo:
                    HideAllFilterInputs();
                    filterTextBox.Visible = true;
                    break;
                case enLocalLicenseFilterOption.Status:
                    HideAllFilterInputs();
                    filterStatusCombo.Visible = true;
                    break;
                case enLocalLicenseFilterOption.None:
                default:
                    HideAllFilterInputs();
                    LoadApplications();
                    break;

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new DrivingLicenseApplicationForm(UserId).ShowDialog();
            LoadApplications();
        }

        private void filterStatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            enApplicationStatus status = StringToStatusOption(filterStatusCombo.Text);
            switch (status)
            {
                case enApplicationStatus.New:
                case enApplicationStatus.Canceled:
                case enApplicationStatus.Completed:
                    LoadLocalDrivingApplications(LocalDLApplicationManager
                                    .GetApplicationsByStatus(status));
                    break;
                default:
                    LoadApplications();
                    break;
            }
            UpdateCountLabel();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StringToFilterOption(filterCombo.Text) == enLocalLicenseFilterOption.NationalNo)
                LoadLocalDrivingApplications(LocalDLApplicationManager.GetApplications()
                    .Where(app => app.NationalNo.Contains(filterTextBox.Text)).ToList());

            
            UpdateCountLabel();

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvData.CurrentRow.Cells[0].Value;

            new ViewLocalDrivingLicenseApplicatiionForm(selectedId)
                .ShowDialog();
        }

        private void DisableAllTests()
        {
            visionTestToolStripMenuItem.Enabled = false;
            theoryTestToolStripMenuItem.Enabled = false;
            practicalTestToolStripMenuItem.Enabled = false;

        }
        private void EnableTest(int index)
        {
            new List<ToolStripMenuItem>() {
                visionTestToolStripMenuItem,
                theoryTestToolStripMenuItem,
                practicalTestToolStripMenuItem
            }[index].Enabled = true;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int selectedId = (int)dgvData.CurrentRow.Cells[0].Value;
            LocalManageDLApplication application = LocalDLApplicationManager
                        .GetApplicatioByLocalId(selectedId);

            // Can't cancel if it's already canceled or completed (i.e. not New)
            bool IssuedBefore = true;
           cancelApplicationToolStripMenuItem.Enabled = application.IsNew;
           issueDrivingLicensefirstTimeToolStripMenuItem.Enabled
                 = application.IsCompleted && !IssuedBefore;
           showLicenseToolStripMenuItem.Enabled = IssuedBefore;
            DisableAllTests();
            if (application.PassedTests < 3)
            {
                EnableTest(application.PassedTests);
            } else
            {
                scheduleTestToolStripMenuItem.Enabled = false;
            }
            


        }

        private void deleteApplicatioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int selectedId = (int)dgvData.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete?", "caution",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            if (LocalDLApplicationManager.DeleteEntireApplication(selectedId))
            {
                MessageBox.Show("Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadApplications();
            }

            else
            {
                MessageBox.Show("Error while deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
