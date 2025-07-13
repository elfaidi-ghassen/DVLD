using DVLVBusinessLayer;
using Models;
using System;
using System.CodeDom;
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
    public partial class ApplicationTypesForm : Form
    {
        public ApplicationTypesForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void InitColumns()
        {
            dgvApplicationTypes.Columns.Add("Column1", "ID");
            dgvApplicationTypes.Columns.Add("Column2", "Title");
            dgvApplicationTypes.Columns.Add("Column3", "Fees");

        }

        private void LoadApplicationsTypes(List<ApplicationType> types)
        {
            dgvApplicationTypes.Rows.Clear();

            foreach (ApplicationType type in types)
            {
                dgvApplicationTypes.Rows.Add(
                        type.ApplicationTypeID,
                        type.ApplicationTypeTitle,
                        type.ApplicationFees
                    );
            }
        }
        private void LoadApplicationTypes()
        {
            LoadApplicationsTypes(ApplicationTypeManager.GetAllApplicationsTypes());
        }
        private void UpdateCountLabel()
        {
            rowCountLabel.Text = $"# Records: {dgvApplicationTypes.RowCount}";
        }
        private void ApplicationTypesForm_Load(object sender, EventArgs e)
        {
            InitColumns();
            LoadApplicationTypes();
            UpdateCountLabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dgvApplicationTypes.CurrentRow.Cells[0].Value;
            new UpdateApplicationTypeForm(selectedId).ShowDialog();
            LoadApplicationTypes();
        }

        private void dgvApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rowCountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
