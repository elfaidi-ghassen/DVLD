using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class ShowDrivingLicenseForm : Form
    {
        public ShowDrivingLicenseForm(int localAppId)
        {
            InitializeComponent();
            drivingLicenseControl1.LoadInfo(localAppId);
        }

        private void ShowDrivingLicenseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
