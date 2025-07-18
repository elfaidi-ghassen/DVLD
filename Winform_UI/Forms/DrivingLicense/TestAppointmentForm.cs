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
        private string FormTitle { get; }
        public TestAppointmentForm(int localAppId, string formTitle)
        {
            InitializeComponent();
            this.LocalApplicationID = localAppId;
            this.FormTitle = formTitle;
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
            LoadAppointments(AppointmentManager.GetAppointmentsByLocalAppId(LocalApplicationID));
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
    }
}
