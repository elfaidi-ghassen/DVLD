using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
using Util.DVLVBusinessLayer;

namespace DVLVBusinessLayer
{
    public class InternationalLicenseManager
    {

        public static List<InternationalDrivingLicenseCard> GetInterLicenseCardInfoListByPersonID(int personID)
        {
            List<InternationalDrivingLicenseCard> licenses = new List<InternationalDrivingLicenseCard>();
            foreach (DataRow row in InternationalLicenseData
                .GetInterLicenseDataTableByPersonID(personID).Rows)
            {
                licenses.Add(DataRowToInternationalCard(row));
            }
            return licenses;
        }

        public static List<InternationalDrivingLicenseCard> GetInterLicenseCardInfoList()
        {
            List<InternationalDrivingLicenseCard> licenses = new List<InternationalDrivingLicenseCard>();
            foreach (DataRow row in InternationalLicenseData
                .GetInterLicenseDataTable().Rows)
            {
                licenses.Add(DataRowToInternationalCard(row));
            }
            return licenses;
        }
        public static InternationalDrivingLicenseCard GetInterLicenseCardInfoByLicenseID(int licenseID)
        {
            return DataRowToInternationalCard(
                InternationalLicenseData.GetInterLicenseCardInfoByLicenseID(licenseID)
                );
        }

        public static InternationalDrivingLicenseCard DataRowToInternationalCard(DataRow row)
        {
            if (row == null) return null;

            return new InternationalDrivingLicenseCard
            {
                InternationalLicenseID = Convert.ToInt32(row["InternationalLicenseID"]),
                FullName = row["FullName"].ToString(),
                DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                Gender = (enGender)Convert.ToInt32(row["Gendor"]),
                PicturePath = row["ImagePath"] == DBNull.Value ? null : row["ImagePath"].ToString(),
                LicenseID = Convert.ToInt32(row["IssuedUsingLocalLicenseID"]),
                DriverID = Convert.ToInt32(row["DriverID"]),
                IssueDate = Convert.ToDateTime(row["IssueDate"]),
                ExpirationDate = Convert.ToDateTime(row["ExpirationDate"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                NationalNo = row["NationalNo"].ToString(),
                AppId = Convert.ToInt32(row["ApplicationID"])
            };
        }

        public static (int?, int?)? CreateLicense(
            int personID,
            int driverId,
            DateTime applicationDate,
            DateTime issueDate,
            decimal fees,
            int localLicenseId,
            DateTime expirationDate,
            int userId
        )
        {
            int appTypeId = (int)enApplicationType.InternationalLicense;
            int? applicationID = ApplicationManager
                .AddApplication(personID, applicationDate, appTypeId,
                enApplicationStatus.Completed,
                DateTime.Today,
                ApplicationTypeManager.GetApplicationTypeById(appTypeId).ApplicationFees,
                userId);
            int active = 1;
            if (applicationID == null)
            {
                return null;
            }
            int? licenseID = InternationalLicenseData
                .CreateLicense(driverId, (int)applicationID, localLicenseId, issueDate, expirationDate, active, userId);
            if (licenseID == null)
            {
                return null;
            }
            return ((int)applicationID, (int)licenseID);
        }
        public static bool HasActiveLicense(int driverId)
        {
            return InternationalLicenseData.HasActiveLicense(driverId);
        }
    }
}
