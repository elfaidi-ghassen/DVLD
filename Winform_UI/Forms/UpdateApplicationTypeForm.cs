using DVLVBusinessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_UI.Forms
{
    public partial class UpdateApplicationTypeForm : Form
    {
        private int ApplicationTypeId { get; set; }
        public UpdateApplicationTypeForm(int ApplicationTypeId)
        {
            InitializeComponent();
            LoadFormData(ApplicationTypeId);
            this.ApplicationTypeId = ApplicationTypeId;
        }

        private void LoadFormData(int ApplicationTypeId)
        {
            ApplicationType type = ApplicationTypeManager
                                .GetApplicationTypeById(ApplicationTypeId);
            LabelId.Text = type.ApplicationTypeID.ToString();
            tbTitle.Text = type.ApplicationTypeTitle;
            tbFees.Text = type.ApplicationFees.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateApplicationTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            ApplicationType type = ApplicationTypeManager.GetApplicationTypeById(ApplicationTypeId);
            type.ApplicationTypeTitle = tbTitle.Text;
            type.ApplicationFees = Convert.ToDecimal(tbFees.Text);

            if(ApplicationTypeManager.Update(type))
            {
                MessageBox.Show("Updated Succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show("Couldn't update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
