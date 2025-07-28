using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_UI.Forms.InternationalLicense
{
    public partial class ShowInternationalLicenseForm : Form
    {
        public ShowInternationalLicenseForm(int internationalLicenseID)
        {
            InitializeComponent();
            internationalLicenseControl1.LoadInfoByLicenseID(internationalLicenseID);

        }

        private void ShowInternationalLicenseForm_Load(object sender, EventArgs e)
        {
        }

        private void internationalLicenseControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
