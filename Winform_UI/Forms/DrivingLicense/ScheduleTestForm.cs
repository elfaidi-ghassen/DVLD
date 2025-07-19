using DataAccessLayer;
using DVLVBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;
using Winform_UI.Debug;

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class ScheduleTestForm : Form
    {
        private int LocalApplicationID { get; set; }
        private int? AppointmentID { get; set; }
        private int UserID { get; set; }
        private enMode FormMode { get; set; }
        private enDrivingTestType TestType { get; set; }
        public ScheduleTestForm(int LocalApplicationID,
                                enDrivingTestType TestType,
                                int UserID,
                                int? AppointmentID = null)
        {
            InitializeComponent();
            this.LocalApplicationID = LocalApplicationID;
            this.TestType = TestType;
            this.UserID = UserID;
            this.AppointmentID = AppointmentID;
            SetFormMode(AppointmentID);
            SetButtonText(FormMode);
            SetGroupBoxTitle(TestType);
            SetPickerMinDate(GetAppointmentDate(AppointmentID));
            LoadFormInfo(LocalApplicationID, TestType);
        }
        private DateTime GetAppointmentDate(int? AppointmentID)
        {
            if (AppointmentID == null)
            {
                return DateTime.Today;
            }
            else
            {
                return AppointmentManager.GetAppointmentByID((int)AppointmentID)
                                         .AppointmentDate;
            }
        }
        private void SetButtonText(enMode FormMode)
        {
            btnSave.Text = FormMode == enMode.Add ? "Add" : "Update";    
        }
        private void SetFormMode(int? AppointmentID)
        {
            this.FormMode = (AppointmentID == null) ? enMode.Add : enMode.Update;
        }

        private void LoadFormInfo(int LocalApplicationID, enDrivingTestType TestType)
        {
            LocalManageDLApplication app =  LocalDLApplicationManager
                                        .GetApplicatioByLocalId(LocalApplicationID);
            labelDLAppId.Text = app.LocalApplicationID.ToString();
            labelFullName.Text = app.FullName;
            labelDriverClass.Text = app.DrivingLicenseClassTitle;
            labelFees.Text = GetTestFees(TestType).ToString();
            labelTrial.Text = TestManager
                                .GetPreviousTrialsCount(LocalApplicationID, TestType)
                                .ToString();
        }       
        private decimal GetTestFees(enDrivingTestType TestType)
        {
            return TestTypeManager.GetTestTypeById((int)TestType).TestTypeFees;
        }
        private void SetPickerMinDate(DateTime Min)
        {
            dateTimePicker1.MinDate = Min;
        }
        private void SetGroupBoxTitle(enDrivingTestType TestType)
        {
            testGroupBox.Text = TestType.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormMode == enMode.Add)
            {
                HandleAddingAppointment();
            } 
            else if (FormMode == enMode.Update)
            {
                HandleUpdatingAppointment();
            }
        }
        private void HandleAddingAppointment()
        {
            bool wasAdded = AppointmentManager.AddAppointment(TestType,
                                  LocalApplicationID,
                                  dateTimePicker1.Value,
                                  GetTestFees(TestType),
                                  UserID,
                                  IsLocked: false);


            if (wasAdded)
            {
                MessageBox.Show("Added successfully",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Couldn't add an appointment",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            Close();
        }
        private void HandleUpdatingAppointment()
        {
            try
            {
                CustomAssert.That(dateTimePicker1.Value >= DateTime.Today, "Selected Date is less than today, but we can't select such a date from the UI.");
            } catch (Exception ex)
            {
                // ask for feedback from the user
                CustomAssert.ShowUserInputForm(ex, UserID);
                Close();
            }

            bool wasUpdated = AppointmentManager.UpdateAppointmentDate(
                                                       (int)AppointmentID,
                                                       dateTimePicker1.Value);
            if (wasUpdated)
            {
                MessageBox.Show("Updated successfully",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Couldn't update the appointment",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            Close();
        }
    }
}
