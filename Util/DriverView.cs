using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class DriverView
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public int ActiveLicensesCount { get; set; }
        public DriverView(int driverId, int personId, string nationalNo, string fullName, DateTime date, int activeLicenses)
        {
            DriverID = driverId;
            PersonID = personId;
            NationalNo = nationalNo;
            FullName = fullName;
            Date = date;
            ActiveLicensesCount = activeLicenses;
        }

    }

}
