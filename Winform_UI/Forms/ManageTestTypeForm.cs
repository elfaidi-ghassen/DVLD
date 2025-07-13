using DVLVBusinessLayer;
using Models;
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

namespace Winform_UI.Forms
{
    public partial class ManageTestTypeForm : Form
    {
        public ManageTestTypeForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void InitColumns()
        {
            dgvTestTypes.Columns.Add("Column1", "ID");
            dgvTestTypes.Columns.Add("Column2", "Title");
            dgvTestTypes.Columns.Add("Column3", "Description");
            dgvTestTypes.Columns.Add("Column3", "Fees");


        }

        private void LoadApplicationsTypes(List<TestType> types)
        {
            dgvTestTypes.Rows.Clear();

            foreach (TestType type in types)
            {
                dgvTestTypes.Rows.Add(
                        type.TestTypeID,
                        type.TestTypeTitle,
                        type.TestTypeDescription,
                        type.TestTypeFees
                    );
            }
        }
        private void LoadApplicationTypes()
        {
            LoadApplicationsTypes(TestTypeManager.GetAllTestTypes());
        }

        private void UpdateCountLabel()
        {
            rowCountLabel.Text = $"# Records: {dgvTestTypes.RowCount}";
        }
        private void ManageTestTypeForm_Load(object sender, EventArgs e)
        {
            InitColumns();
            LoadApplicationTypes();
            UpdateCountLabel();
        }
    }
}
