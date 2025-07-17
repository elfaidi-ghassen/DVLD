using DataAccessLayer;
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
    
    public class ApplicationManager
    {
        private static ApplicationInfo RowToApplicationInfo(DataRow row)
        {
            return new ApplicationInfo(
                    applicationID: Convert.ToInt32(row["ApplicationID"]),
                    applicantPersonID: Convert.ToInt32(row["ApplicantPersonID"]),
                    applicantFullName: row["FullName"].ToString(),
                    applicationDate: Convert.ToDateTime(row["ApplicationDate"]),
                    applicationTypeTitle: (string)(row["ApplicationTypeTitle"]),
                    applicationTypeID: Convert.ToInt32(row["ApplicationTypeID"]),
                    applicationStatus: (ApplicationInfo.enApplicationStatus)Convert.ToInt32(row["ApplicationStatus"]),
                    lastStatusDate: Convert.ToDateTime(row["LastStatusDate"]),
                    paidFees: Convert.ToDecimal(row["PaidFees"]),
                    createdByUserID: Convert.ToInt32(row["CreatedByUserID"]),
                    createdByUserName: row["UserName"].ToString()
                );
        }
        public static ApplicationInfo GetApplicationInfoById(int appId)
        {
            DataRow row = ApplicationData.GetApplicationInfoRow(appId);
            if (row == null) { return null; } 
            return RowToApplicationInfo(row);
        }
        public static int? AddApplication(
               int applicantPersonID,
               DateTime applicationDate,
               int applicationTypeID,
               enApplicationStatus applicationStatus,
               DateTime lastStatusDate,
               decimal paidFees,
               int createdByUserID)
        {
            return ApplicationData.Add(applicantPersonID, applicationDate, applicationTypeID,
                    (int)applicationStatus, lastStatusDate, paidFees, createdByUserID);
        }
    }
}
