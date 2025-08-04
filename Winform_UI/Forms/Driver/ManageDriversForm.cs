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
using Winform_UI.Controls;
using Winform_UI.Forms.DrivingLicense;

namespace Winform_UI.Forms.Driver
{
    public partial class ManageDriversForm : Form
    {
        public ManageDriversForm()
        {
            InitializeComponent();
        }

        private void ManageDriversForm_Load(object sender, EventArgs e)
        {
            InitializeColumns();
            LoadDrivers();
            UpdateRowCount();
        }
        private void UpdateRowCount()
        {
            labelRecordsCount.Text = $"# Records: {dgvData.RowCount}";
        }
        private void InitializeColumns()
        {
            dgvData.Columns.Add("col1", "Driver ID");
            dgvData.Columns.Add("col2", "Person ID");
            dgvData.Columns.Add("col3", "National No");
            dgvData.Columns.Add("col4", "Full Name");
            dgvData.Columns.Add("col5", "Driver since");
            dgvData.Columns.Add("col6", "Active Licenses");
        }

        private void LoadDrivers()
        {
            LoadDrivers(DriverManager.GetDriversViewList());
        }
        private void LoadDrivers(List<DriverView> drivers) 
        {
            foreach (DriverView driver in drivers)
            {
                dgvData.Rows.Add(
                        driver.DriverID,
                        driver.PersonID,
                        driver.NationalNo,
                        driver.FullName,
                        driver.Date,
                        driver.ActiveLicensesCount
                    );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvData.CurrentRow.Cells[1].Value;
            new ShowDrivingLicenseHistoryForm(selectedId).ShowDialog();
        }
    }
}
