using DVLVBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace Winform_UI.Controls
{

    public partial class LicensesHistory : UserControl
    {
        private enum SelectedTab { Local, International }
        private int? personID = null;

        public LicensesHistory()
        {
            InitializeComponent();
            InitializeDataGridColumns();
        }
        private void InitializeDataGridColumns()
        {
            dgvLocal.Columns.Add("col1", "l.id.");
            dgvLocal.Columns.Add("col2", "app.id.");
            dgvLocal.Columns.Add("col3", "Class Name");
            dgvLocal.Columns.Add("col4", "Issue Date");
            dgvLocal.Columns.Add("col5", "Expiration Date");
            dgvLocal.Columns.Add("col6", "Active Status");

            dgvInternational.Columns.Add("col1", "Inter. L.ID");
            dgvInternational.Columns.Add("col2", "Application ID");
            dgvInternational.Columns.Add("col3", "L. License ID");
            dgvInternational.Columns.Add("col4", "Issue Date");
            dgvInternational.Columns.Add("col5", "Expiration Date");
            dgvInternational.Columns.Add("col6", "Is Active");
        }

        public void LoadPerson(int personID)
        {
            this.personID = personID;
            LoadLicenses();
        }
        private void LoadLicenses()
        {
            LoadLicenses(this.personID);
            
        }
        private void LoadLicenses(int? personID)
        {
            LoadLocalLicenses(personID);
            LoadInternationalLicenses(personID);
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UpdateLocalRowCount()
        {
            int count = dgvLocal.RowCount;
            labelLocalRecordsNumber.Text = $"# Records: {count}";
        }
        private void UpdateInterRowCount()
        {
            int count = dgvInternational.RowCount;
            labelInterRecordsNumber.Text = $"# Records: {count}";
        }
        private void LoadLocalLicenses(int? personID)
        {
            dgvLocal.Rows.Clear();
            if (personID == null) { return; }
            foreach (DrivingLicenseCard info in 
                    DrivingLicenseManager.GetLicenseCardInfoListByPersonID((int)personID))
            {
                dgvLocal.Rows.Add(
                    info.LicenseID,
                    info.ApplicationID,
                    info.ClassTitle,
                    info.IssueDate,
                    info.ExpirationDate,
                    info.IsActive
                );
            UpdateLocalRowCount();
            }
        }
        private void LoadInternationalLicenses(int? personID)
        {
            if (personID == null) { return; }
            
            
                
            foreach(InternationalDrivingLicenseCard info in InternationalLicenseManager
                .GetInterLicenseCardInfoListByPersonID((int)personID))
            {
                dgvInternational.Rows.Add(
                            info.LicenseID,
                            info.AppId,
                            info.LicenseID,
                            info.IssueDate,
                            info.ExpirationDate,
                            info.IsActive ? "Active" : "Inactive"
                    );
            }
        UpdateInterRowCount();
            
        }

        private void tabLocal_Click(object sender, EventArgs e)
        {

        }

        private void labelInterRecordsNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
