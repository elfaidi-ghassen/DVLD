using DVLVBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Util;

namespace Winform_UI.Forms
{

    
    /// <summary>Represents columns in the detained licenses data grid.</summary>
    public enum LicenseColumn
    {
        DriverId, LicenseId, DetainedOn, Released,
        Fine, ReleasedOn, NationalNumber,
        FullName, ReleaseAppId
    }

    public partial class ManageDetainedLicenseForm : Form
    {
        private List<DetainedRecord> listOfDetaiendLicenses
            = new List<DetainedRecord>();
        

        public ManageDetainedLicenseForm()
        {
            InitializeComponent();
        }



        /* ==================================================================== */
        /* Events */
        private void OnCloseButtonClick(object sender, EventArgs e) => Close();



        private void ManageDetainedLicenseForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridColumns(
                Enum.GetValues(typeof(LicenseColumn)));
            LoadDetainedLicenses();
            DisplayDetainedLicenses(listOfDetaiendLicenses);
            UpdateCountLabel();

            filterBox1.AddResetFilterOption(() => FilterBy(_ => true)); 

            filterBox1.AddNumberFilterOption
                (GetColumnLabel(LicenseColumn.DriverId),
                (value) => 
                    FilterBy(rec => rec.DriverID == value));

            filterBox1.AddNumberFilterOption
                (GetColumnLabel(LicenseColumn.Fine),
                (value) => 
                    FilterBy(rec => (int)rec.FineFees == value));

            filterBox1.AddNumberFilterOption
                (GetColumnLabel(LicenseColumn.LicenseId),
                (value) => 
                    FilterBy(rec => rec.LicenseID== value));

            filterBox1.AddTextFilterOption
                (GetColumnLabel(LicenseColumn.NationalNumber),
                (input) => 
                    FilterBy(rec => rec.NationalNumber.Contains(input)));

           filterBox1.AddTextFilterOption
                (GetColumnLabel(LicenseColumn.FullName),
                (input) => 
                    FilterBy(rec => rec.FullName.Contains(input)));

        }

        private void OnRefreshToolStripMenuItemClick(object sender, EventArgs e)
        {
            LoadDetainedLicenses();
            DisplayDetainedLicenses(listOfDetaiendLicenses);
        }

        /* ==================================================================== */
        /* Helper methods */

        /// this function are used to generate callbacks 
        /// that we will pass to the filtering contol element
        public void FilterBy(Func<DetainedRecord, bool> pred)
        {
            DisplayDetainedLicenses(listOfDetaiendLicenses.Where(pred).ToList());
            UpdateCountLabel();
        }



        private string GetColumnLabel(LicenseColumn col)
        {
            if (col == LicenseColumn.DriverId)       return "D.ID";
            if (col == LicenseColumn.LicenseId)      return "L.ID";
            if (col == LicenseColumn.DetainedOn)     return "Detained on";
            if (col == LicenseColumn.Released)       return "Released?";
            if (col == LicenseColumn.Fine)           return "Fine";
            if (col == LicenseColumn.ReleasedOn)     return "Released on?";
            if (col == LicenseColumn.NationalNumber) return "N.No";
            if (col == LicenseColumn.FullName)       return "Full Name";
            if (col == LicenseColumn.ReleaseAppId)   return "Release AppID";

            throw new ArgumentOutOfRangeException("Invalid Detained license column, did you update the enum?");
        }


        /// <summary>takes an Array of LicenseColumn and initalize the datagrid view<summary>
        private void InitializeDataGridColumns(Array fields)
        {
            foreach (LicenseColumn field in fields)
            {
                int position = dgvData.Columns.Count;
                dgvData.Columns.Add(field.ToString(), GetColumnLabel(field));
            }
        }

        /// <summary>
        /// Gets a List of DetainedRecord and store them in a list
        /// as a cache, so that we can filter them later.
        /// </summary>
        private void LoadDetainedLicenses()
        {
            listOfDetaiendLicenses = DetainedLicensesManager
                .GetDetainedLicensesList();
        }
        

        /// <summary>
        /// Update the state of the datagrid to match the content 
        /// of the given list
        /// </summary>
        private void DisplayDetainedLicenses(List<DetainedRecord> listOfDetaiendLicenses)
        {
            dgvData.Rows.Clear();
            foreach (DetainedRecord record in listOfDetaiendLicenses)
            {
                dgvData.Rows.Add(record.ToDataRow());
            }
        }

        private void UpdateCountLabel()
        {
            labelRecordsCount.Text = $"# Records: {dgvData.RowCount}";
        }

    }
}
