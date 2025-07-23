using DataAccessLayer;
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

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class TakeTestForm : Form
    {
        private int AppointmentID { get; set; }
        private int UserID { get; set; }
        public TakeTestForm(int AppointmentID, int UserID)
        {
            InitializeComponent();
            this.AppointmentID = AppointmentID;
            this.UserID = UserID;
            LoadFormInfo(AppointmentID);
            TestAppointment appointment = AppointmentManager
                                    .GetAppointmentByID(AppointmentID);
            if (appointment.TestID != null)
            {
                btnSave.Enabled = false;
            }
        }


        private decimal GetTestFees(enDrivingTestType TestType)
        {
            return TestTypeManager.GetTestTypeById((int)TestType).TestTypeFees;
        }
        private void LoadFormInfo(int AppointmentID)
        {
            TestAppointment appointment = AppointmentManager
                                    .GetAppointmentByID(AppointmentID);
            LocalManageDLApplication app = LocalDLApplicationManager
                  .GetApplicationByLocalId(appointment.LocalDrivingLicenseApplicationID);

            labelDLAppId.Text = app.LocalApplicationID.ToString();
            labelFullName.Text = app.FullName;
            labelDate.Text = appointment.AppointmentDate.ToShortDateString();
            labelDriverClass.Text = app.DrivingLicenseClassTitle;
            labelFees.Text = GetTestFees((enDrivingTestType)appointment.TestTypeID)
                .ToString();
            labelTrial.Text = TestManager
                                .GetPreviousTrialsCount(appointment.LocalDrivingLicenseApplicationID,
                                                    (enDrivingTestType)appointment.TestTypeID)
                                .ToString();
            if (appointment.TestID != null)
            {
                labelTestId.Text = appointment.TestID.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int testResult = radioPass.Checked ? 1 : 0;
            string notes = null;
            if (richTextBox1.Text != string.Empty)
            {
                notes = richTextBox1.Text;
            }

            if (TestManager.AddTest(AppointmentID,
                                testResult,
                                notes,
                                UserID))
            {
                MessageBox.Show("Test completed",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("There's already an active appointment",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
            Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
