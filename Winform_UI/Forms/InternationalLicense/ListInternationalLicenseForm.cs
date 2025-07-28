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
using Winform_UI.Forms.DrivingLicense;

namespace Winform_UI.Forms.InternationalLicense
{
    enum enInternationalFilterOption { All, InternationalLicenseID, ApplicationID }
    public partial class ListInternationalLicenseForm : Form
    {
        private int UserID;
        private List<InternationalDrivingLicenseCard> licensesCache = new List<InternationalDrivingLicenseCard>();
        public ListInternationalLicenseForm(int userID)
        {
            this.UserID = userID;
            InitializeComponent();
        }
        
        private void ListInternationalLicenseForm_Load(object sender, EventArgs e)
        {
            HideAllFilterInputs();
            InitColumns();
            InitFiltersComboBox();
            UpdateLicensesList();
            LoadLicenses();
            UpdateCountLabel();
        }
        private void LoadLicenses(List<InternationalDrivingLicenseCard> licenses)
        {
            dgvData.Rows.Clear();

            foreach (InternationalDrivingLicenseCard license in licenses)
            {
                dgvData.Rows.Add(
                    license.InternationalLicenseID,
                    license.AppId,
                    license.DriverID,
                    license.LicenseID,
                    license.IssueDate,
                    license.ExpirationDate,
                    license.IsActive ? "Active" : "Inactive"
                    );
            }

        }

        private void UpdateLicensesList()
        {
            licensesCache = InternationalLicenseManager.GetInterLicenseCardInfoList();
        } 
        private void LoadLicenses()
        {
            LoadLicenses(licensesCache);
        }
        private void UpdateCountLabel()
        {
            labelCountRecords.Text = $"# Records: {dgvData.RowCount}";
        }
        private void InitColumns()
        {
            dgvData.Columns.Add("Column1", "Int. License ID");
            dgvData.Columns.Add("Column2", "Application ID");
            dgvData.Columns.Add("Column3", "Driver ID");
            dgvData.Columns.Add("Column5", "L. License ID");
            dgvData.Columns.Add("Column6", "Issue Date");
            dgvData.Columns.Add("Column7", "Expiration Date");
            dgvData.Columns.Add("Column8", "Is Active");
        }

        private void InitFiltersComboBox()
        {
            foreach (enInternationalFilterOption option
                    in Enum.GetValues(typeof(enInternationalFilterOption)))
            {
                string displayText = FilterOptionToString(option);
                filterCombo.Items.Add(displayText);
            }
            filterCombo.SelectedIndex = 0;
        }

        private enInternationalFilterOption StringToFilterOption(string strOption)
        {
            switch (strOption)
            {
                case "Application ID":
                    return enInternationalFilterOption.ApplicationID;
                case "International Application ID":
                    return enInternationalFilterOption.InternationalLicenseID;
                case "All":
                default:
                    return enInternationalFilterOption.All;
            }
        }

        private string FilterOptionToString(enInternationalFilterOption option)
        {
            switch (option)
            {
                case enInternationalFilterOption.ApplicationID:
                    return "Application ID";
                case enInternationalFilterOption.InternationalLicenseID:
                    return "International Application ID";
                case enInternationalFilterOption.All:
                default:
                    return "All";
            }
        }


        private void HideAllFilterInputs()
        {
            filterNumber.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddInternationalDrivingLicenseForm(UserID).ShowDialog();
            LoadLicenses();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void filterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StringToFilterOption(filterCombo.Text))
            {
                case enInternationalFilterOption.ApplicationID:
                case enInternationalFilterOption.InternationalLicenseID:
                    HideAllFilterInputs();
                    filterNumber.Visible = true;
                    break;
                default:
                    HideAllFilterInputs();
                    LoadLicenses();
                    break;
            }


        }

        private void filterNumber_ValueChanged(object sender, EventArgs e)
        {
            if (filterNumber.Value == 0)
            {
                LoadLicenses();
                return;
            }
            switch (StringToFilterOption(filterCombo.Text))
            {
                case enInternationalFilterOption.ApplicationID:
                    LoadLicenses(
                            licensesCache
                                .Where(license => license.AppId == filterNumber.Value).ToList()
                             );
                    break;
                case enInternationalFilterOption.InternationalLicenseID:
                    LoadLicenses(
                        licensesCache
                            .Where(license => license.InternationalLicenseID == filterNumber.Value).ToList()
                         );
                    break;
                default:
                    LoadLicenses();
                    break;
            }


            UpdateCountLabel();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateLicensesList();
            LoadLicenses();
        }

        private void viewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int licenseId = (int)dgvData.CurrentRow.Cells[0].Value;

            new ShowInternationalLicenseForm(licenseId).ShowDialog();
        }

        private void viewLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = DriverManager.GetDriverByDriverId(dgvDriverId()).PersonID;
            new ShowDrivingLicenseHistoryForm(personId).ShowDialog();
        }
        private int dgvDriverId()
        {
            return (int)dgvData.CurrentRow.Cells[2].Value;
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personId = DriverManager.GetDriverByDriverId(dgvDriverId()).PersonID;
            new PersonInfoForm(personId).ShowDialog();
        }
    }
}
