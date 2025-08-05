using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_UI.Controls
{
    public partial class ReleaseDetainedApplication : UserControl
    {
        public int? DetainID { get; set; } = null;
        public DateTime? DetainDate { get; set; } = null;
        public int? LicenseID { get; set; } = null;
        public int? CreatedByUserId { get; set; } = null;
        public decimal? FineAmount { get; set; } = null;
        public decimal? TotalFees { get; set; } = null;
        public decimal? ApplicationFees { get; set; } = null;
        public int? ReleaseApplicationID { get; set; } = null;


        public void DisplayData()
        {
            if (DetainID != null)
                labelDetainID.Text = DetainID.ToString();

            if (DetainDate != null)
                labelDetainDate.Text = ((DateTime)DetainDate).ToShortDateString();

            if (LicenseID != null)
                labelLicenseID.Text = LicenseID.ToString();
            
            if (CreatedByUserId != null)
                labelCreatedBy.Text = CreatedByUserId.ToString();
            
            if (ReleaseApplicationID != null)
                labelApplicationID.Text = ReleaseApplicationID.ToString();
            
            if (ApplicationFees != null)
                labelApplicationFees.Text = ApplicationFees.ToString();
            
            if (FineAmount != null)
                labelFineAmount.Text = FineAmount.ToString();

            if (TotalFees != null)
                labelTotalFee.Text = TotalFees.ToString();

        }
        public ReleaseDetainedApplication()
        {
            InitializeComponent();
        }
    }
}
