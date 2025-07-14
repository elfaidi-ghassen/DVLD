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
using Winform_UI.Controls;
using Util;
using Models;
using Util.DVLVBusinessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class DrivingLicenseApplicationForm : Form
    {

        private int UserId { get; set; }
        public DrivingLicenseApplicationForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
            labelTitle.Text = "Create an application";
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
            DateTime applicationDate = DateTime.Today;

   
            labelApplicationDate.Text = applicationDate.ToString();
            labelApplicationFees.Text = ApplicationTypeManager.GetApplicationTypeById(1)
                                                              .ApplicationFees
                                                              .ToString();
            labelCreatedBy.Text = UserManager.GetUserById(UserId).UserName;
            List<LicenseClass> classes = LicenseClassManager.GetAllClasses();
            foreach (LicenseClass licenseClass in classes)
            {
                comboLicenseClass.Items.Add(licenseClass.ClassName);
            }
            comboLicenseClass.SelectedIndex = 0;

            
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex != 1) { return; }

            if (userChoosePerson1.ChosenId == null)
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

        private void tabApplication_Click(object sender, EventArgs e)
        {

        }

        private void DrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void comboLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private int GetSelectedLicenseClassID()
        {
            List<LicenseClass> classes = LicenseClassManager.GetAllClasses();
            return classes[comboLicenseClass.SelectedIndex].LicenseClassID;

        }



        private int? CreateApplication()
        {
            int personId = (int)userChoosePerson1.ChosenId;
            DateTime applicationDate = DateTime.Now;
            int applicationTypeID = (int)enApplicationType.NewDrivingLicenseService;
            enApplicationStatus applicationStatus = enApplicationStatus.New;
            DateTime lastStatusDate = DateTime.Now;
            decimal paidFees = ApplicationTypeManager
                                .GetApplicationTypeById(1).ApplicationFees;
            int createdByUserId = UserId;

            int? applicationId = ApplicationManager.AddApplication(
                    personId, applicationDate,
                    applicationTypeID, applicationStatus, lastStatusDate,
                    paidFees, createdByUserId);
            return applicationId;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            int personId = (int)userChoosePerson1.ChosenId;
            int licenseClassID = GetSelectedLicenseClassID();
            if (DrivingLicenseApplicationManager.PersonHasActiveDLApplication(personId, licenseClassID))
            {
                MessageBox.Show("This person already has a license with this class",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
                
            int? applicationId = CreateApplication();
            if (applicationId == null)
            {
                MessageBox.Show("Couldn't create application",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            
            labelApplicationID.Text = ((int)applicationId).ToString();
            int? dlApplicationId = DrivingLicenseApplicationManager
                                .CreateApplication((int)applicationId, licenseClassID);
            if (dlApplicationId == null)
            {
                MessageBox.Show("Couldn't create driving license application",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
                // if couldn't create DL application we should delete the initial application

            } else
            {
                labelApplicationID.Text = ((int)dlApplicationId).ToString();
                MessageBox.Show("Application created Successfully",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                saveButton.Enabled = false;
                comboLicenseClass.Enabled = false;
            }

        }
    }
}
