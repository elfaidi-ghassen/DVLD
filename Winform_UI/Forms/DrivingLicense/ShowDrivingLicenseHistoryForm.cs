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

namespace Winform_UI.Forms.DrivingLicense
{
    public partial class ShowDrivingLicenseHistoryForm : Form
    {

        private int LocalAppId { get; set; }
        public ShowDrivingLicenseHistoryForm(int personID)
        {
            InitializeComponent();
            personInfo1.LoadPerson(personID);
            licensesHistory1.LoadPerson(personID);
        }

        
        private void ShowDrivingLicenseHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void licensesHistory1_Load(object sender, EventArgs e)
        {

        }
    }
}
