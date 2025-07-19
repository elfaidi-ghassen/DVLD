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


    public partial class TestAppointmentForm : Form
    {

        private int LocalApplicationID { get; }
        private int UserID { get; set;  }
        private string FormTitle { get; }
        private enDrivingTestType TestType { get; }
        private string TestTypeToTitle(enDrivingTestType type)
        {
            switch(type)
            {
                case enDrivingTestType.Vision:
                    return "Vision Test Appointment";
                case enDrivingTestType.Theory:
                    return "Theory Test Appointment";
                case enDrivingTestType.Practical:
                    return "Practical Test Appointment";
                case enDrivingTestType.None:
                default:
                    return "";
            }
        }
        public TestAppointmentForm(int localAppId, enDrivingTestType type, int UserID)
        {
            InitializeComponent();
            this.LocalApplicationID = localAppId;
            this.UserID = UserID;
            this.FormTitle = TestTypeToTitle(type);
            this.TestType = type;
            InitializeForm();
        }
        private void InitializeForm()
        {
            labelTitle.Text = FormTitle;
            applicationInfo1.LoadInfo(LocalDLApplicationManager
                .GetApplicationIdByLocalId(LocalApplicationID));
            drivingLicenseApplicationForm1.LoadApplication(LocalApplicationID);

        }
        private void InitColumns()
        {
            dgvData.Columns.Add("Column1", "AppointmentID");
            dgvData.Columns.Add("Column2", "Appointment Date");
            dgvData.Columns.Add("Column3", "Paid Fees");
            dgvData.Columns.Add("Column3", "Is Locked");
        }

        private string LockedString(bool isLocked)
        {
            if (isLocked)
                return "Locked";
            else
                return "Not locked";
        }
        private void LoadAppointments(List<TestAppointment> appointments)
        {
            dgvData.Rows.Clear();
            
            foreach (TestAppointment appointment in appointments)
            {
                dgvData.Rows.Add(
                    appointment.TestAppointmentID,
                    appointment.AppointmentDate.ToShortDateString(),
                    appointment.PaidFees,
                    LockedString(appointment.IsLocked)
                    );
            }


        }
        private void LoadAppointments()
        {
            LoadAppointments(
                AppointmentManager.GetAppointmentsByLocalAppId(LocalApplicationID, TestType));
        }
        private void UpdateCountLabel()
        {
            labelCountRecords.Text = $"# Records: {dgvData.RowCount}";

        }
        private void TestAppointmentForm_Load(object sender, EventArgs e)
        {
            InitColumns();
            LoadAppointments();
            UpdateCountLabel();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (AppointmentManager.HasActiveAppointment(LocalApplicationID, TestType))
            {
                MessageBox.Show("There's already an active appointment",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (TestManager.AlreadyPassedTest(LocalApplicationID, TestType))
            {
                MessageBox.Show("The applicant already passed the exam.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            new ScheduleTestForm(LocalApplicationID, TestType, UserID).ShowDialog();
            LoadAppointments();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = (int)dgvData.CurrentRow.Cells[0].Value;

            new ScheduleTestForm(LocalApplicationID, TestType, UserID, AppointmentID).ShowDialog();
            LoadAppointments();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)

        {
            int AppointmentID = (int)dgvData.CurrentRow.Cells[0].Value;
            new TakeTestForm(AppointmentID, UserID).ShowDialog();
            LoadAppointments();
        }
    }
}
