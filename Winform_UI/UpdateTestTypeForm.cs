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

namespace Winform_UI
{
    public partial class UpdateTestTypeForm : Form
    {

        private int TestTypeId { get; set; }
        public UpdateTestTypeForm(int ID)
        {
            InitializeComponent();
            LoadFormData(ID);
            TestTypeId = ID;
        }

        private void LoadFormData(int testTypeId)
        {
            TestType type = TestTypeManager
                                .GetTestTypeById(testTypeId);
            LabelId.Text = type.TestTypeID.ToString();
            tbTitle.Text = type.TestTypeTitle;
            textDescription.Text = type.TestTypeDescription;

            tbFees.Text = type.TestTypeFees.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            TestType type = TestTypeManager.GetTestTypeById(TestTypeId);
            type.TestTypeTitle = tbTitle.Text;
            type.TestTypeFees = Convert.ToDecimal(tbFees.Text);
            type.TestTypeDescription = textDescription.Text;

            if (TestTypeManager.Update(type))
            {
                MessageBox.Show("Updated Succesfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Couldn't update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
