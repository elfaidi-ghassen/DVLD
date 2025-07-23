using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DVLVBusinessLayer
{
    public class DrivingLicenseManager
    {
        public static List<DrivingLicenseCard> GetLicenseCardInfoListByPersonID(int personID)
        {
            List<DrivingLicenseCard> infos = new List<DrivingLicenseCard>();
            foreach(DataRow row in DrivingLicenseData.GetLicensesDataTableByPerson(personID).Rows)
            {
                infos.Add(RowToLicenseCard(row));
            }
            return infos;
        }
        public static DrivingLicenseCard GetLicenseCardInfo(int localID)
        {
            return RowToLicenseCard(
                DrivingLicenseData.GetLicenseCardRow(localID));
        }

        public static DrivingLicenseCard RowToLicenseCard(DataRow row)
        {
            if (row == null) return null;
            int licenseID = Convert.ToInt32(row["LicenseID"]);
            int applicationID = Convert.ToInt32(row["ApplicationID"]);
            int driverID = Convert.ToInt32(row["DriverID"]);
            string licenseClass = row["LicenseClass"].ToString();
            DateTime issueDate = Convert.ToDateTime(row["IssueDate"]);
            DateTime expirationDate = Convert.ToDateTime(row["ExpirationDate"]);
            string notes = row["Notes"] == DBNull.Value ? null : row["Notes"].ToString();
            decimal paidFees = Convert.ToDecimal(row["PaidFees"]);
            bool isActive = Convert.ToInt32(row["IsActive"]) == 1;
            bool isDetained = row["isDetained"] != DBNull.Value && Convert.ToInt32(row["isDetained"]) == 1;
            enIssueReason issueReason = (enIssueReason)Convert.ToInt32(row["IssueReason"]);
            int createdByUserID = Convert.ToInt32(row["CreatedByUserID"]);
            string classTitle = row["ClassName"].ToString();
            string fullName = row["FullName"].ToString();
            string nationalNo = row["NationalNo"].ToString();
            enGender gender = (enGender)Enum.Parse(typeof(enGender), row["Gendor"].ToString(), ignoreCase: true);
            DateTime dateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
            string picturePath = row["ImagePath"] == DBNull.Value ? null : row["ImagePath"].ToString();

            // Now pass to constructor
            return new DrivingLicenseCard(
                licenseID,
                applicationID,
                driverID,
                licenseClass,
                issueDate,
                expirationDate,
                notes,
                paidFees,
                isActive,
                isDetained,
                issueReason,
                createdByUserID,
                classTitle,
                fullName,
                nationalNo,
                gender,
                dateOfBirth,
                picturePath
            );
        }

        public static bool HasDrivingLicenseWithClass(
              int personId, int licenseClassID)
        {
            return DrivingLicenseData.HasDrivingLicenseWithClass(personId, licenseClassID);   
        }
        public static int? AddLicense(
            int ApplicationID,
            int driverID,
            string notes,
            bool IsActive,
            enIssueReason IssueReason,
            int UserID)
        {
            return DrivingLicenseData.AddLicenseGetId(ApplicationID,
                                            (int)driverID,
                                            notes,
                                            IsActive: IsActive,
                                            IssueReason: IssueReason,
                                            UserID);
        }
    }
}
