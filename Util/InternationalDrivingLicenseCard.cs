using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class InternationalDrivingLicenseCard
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int LicenseID { get; set; }
        public string NationalNo { get; set; }
        public enGender Gender { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsActive { get; set; }
        public int DriverID { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PicturePath { get; set; }
        public int InternationalLicenseID { get; set; }
        public int AppId { get; set; }

        // Optionally, you can add a constructor
        public InternationalDrivingLicenseCard() { }

        public InternationalDrivingLicenseCard(
            string fullName,
            DateTime dateOfBirth,
            int licenseID,
            string nationalNo,
            enGender gender,
            DateTime issueDate,
            bool isActive,
            int driverID,
            DateTime expirationDate,
            string picturePath,
            int internationalLicenseID,
            int appId
            )
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            LicenseID = licenseID;
            NationalNo = nationalNo;
            Gender = gender;
            IssueDate = issueDate;
            IsActive = isActive;
            DriverID = driverID;
            ExpirationDate = expirationDate;
            PicturePath = picturePath;
            InternationalLicenseID = internationalLicenseID;
            AppId = appId;
        }
    }
}
