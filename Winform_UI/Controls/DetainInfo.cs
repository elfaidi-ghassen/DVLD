using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Winform_UI.Controls
{
    public partial class DetainInfo : UserControl
    {
        public int? DetainID { get; set; } = null;
        public DateTime? DetainDate { get; set; } = null;
        public int? LicenseID { get; set; } = null;
        public int? CreatedByUserId { get; set; } = null;
        public decimal? FineAmount
        {
            get
            {
                if (Decimal.TryParse(tbFineAmount.Text, out decimal result))
                {
                    return result;
                }
                return null;
            }
        }
        public DetainInfo()
        {
            InitializeComponent();
        }
        public void DisplayData()
        {
            if (DetainID != null)
                labelDetainDate.Text = DetainDate.ToString();
            if (DetainDate != null)
                labelDetainDate.Text = ((DateTime)DetainDate).ToShortDateString();
            if (LicenseID != null)
                labelLicenseID.Text = LicenseID.ToString();
            if (CreatedByUserId != null)
                labelCreatedBy.Text = CreatedByUserId.ToString();
        }


    }
}
