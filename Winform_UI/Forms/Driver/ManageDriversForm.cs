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
        List<DriverView> driversCache = new List<DriverView>();
        public ManageDriversForm()
        {
            InitializeComponent();
        }
        public void FilterBy(Func<DriverView, bool> pred)
        {
            DisplayDrivers(driversCache.Where(pred).ToList());
            UpdateRowCount();
        }

        private void ManageDriversForm_Load(object sender, EventArgs e)
        {
            InitializeColumns();
            LoadDrivers();
            DisplayDrivers(driversCache);
            UpdateRowCount();
            filterBox1.AddTextFilterOption(
                "Full Name",
                (name) => FilterBy(dv => dv.FullName.Contains(name)));
            
            filterBox1.AddTextFilterOption(
                "National No",
                (name) => FilterBy(dv => dv.NationalNo.Contains(name)));
            
            filterBox1.AddNumberFilterOption(
                "Driver ID",
                (number) => FilterBy(dv => dv.DriverID == number));

            filterBox1.AddResetFilterOption(
                () => FilterBy(_ => true));

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
            driversCache = DriverManager.GetDriversViewList();
        }
        private void DisplayDrivers(List<DriverView> drivers) 
        {
            dgvData.Rows.Clear();
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
