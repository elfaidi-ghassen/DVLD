using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class LocalManageDLApplication
    {
        public int LocalApplicationID { get; set; }
        public string DrivingLicenseClassTitle { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int PassedTests { get; set; }
        public int Status { get; set; }
        public LocalManageDLApplication(int localApplicationID, string drivingLicenseClassTitle, string nationalNo, string fullName, DateTime applicationDate, int passedTests, int status)
        {
            LocalApplicationID = localApplicationID;
            DrivingLicenseClassTitle = drivingLicenseClassTitle;
            NationalNo = nationalNo;
            FullName = fullName;
            ApplicationDate = applicationDate;
            PassedTests = passedTests;
            Status = status;
        }
    }
}
