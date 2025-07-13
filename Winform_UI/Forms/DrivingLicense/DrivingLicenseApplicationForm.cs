using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_UI.Controls;

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class DrivingLicenseApplicationForm : Form
    {
        public DrivingLicenseApplicationForm()
        {
            InitializeComponent();
        }
            

        private void AddUpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (userChoosePerson1.ChosenId == null)
            {
                MessageBox.Show("Please selected a person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                tabControl1.SelectedIndex = 1;
            }
        }


        private void InitializeApplicationInfo(int personId)
        {
            labelApplicationDate.Text = "";
            
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 1
                && userChoosePerson1.ChosenId == null)
            {
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Please selected a person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                InitializeApplicationInfo((int)userChoosePerson1.ChosenId);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
