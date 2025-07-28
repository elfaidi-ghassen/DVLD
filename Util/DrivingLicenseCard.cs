using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class DrivingLicenseCard
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public string LicenseClassTitle { get; set; }
        public enLicenseClass LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public bool IsDetained { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public string ClassTitle { get; set; }
        public string FullName { get; set; }
        public string NationalNo { get; set; }
        public enGender Gender { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public string PicturePath { get; set; }


        public DrivingLicenseCard(
    int licenseID,
    int applicationID,
    int driverID,
    string licenseClassTitle,
    enLicenseClass licenseClass,
    DateTime issueDate,
    DateTime expirationDate,
    string notes,
    decimal paidFees,
    bool isActive,
    bool isDetained,
    enIssueReason issueReason,
    int createdByUserID,
    string classTitle,
    string fullName,
    string nationalNo,
    enGender gender,
    DateTime dateOfBirth,
    string picturePath)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClassTitle = licenseClassTitle;
            this.LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IsDetained = isDetained;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            ClassTitle = classTitle;
            FullName = fullName;
            NationalNo = nationalNo;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PicturePath = picturePath;
        }
    }
}
