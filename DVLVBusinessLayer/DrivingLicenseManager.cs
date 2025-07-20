using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DVLVBusinessLayer
{
    public class DrivingLicenseManager
    {
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
