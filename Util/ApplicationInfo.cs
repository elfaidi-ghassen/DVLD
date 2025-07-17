using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ApplicationInfo
    {
        public enum enApplicationStatus
        {
            None = 0,
            New = 1,
            Canceled = 2,
            Completed = 3
        }
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public string ApplicantFullName { get; set; }
            
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }

        public ApplicationInfo(
            int applicationID,
            int applicantPersonID,
            string applicantFullName,
            DateTime applicationDate,
            int applicationTypeID,
            string applicationTypeTitle,
            enApplicationStatus applicationStatus,
            DateTime lastStatusDate,
            decimal paidFees,
            int createdByUserID,
            string createdByUserName)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicantFullName = applicantFullName;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            CreatedByUserName = createdByUserName;
            ApplicationTypeTitle = applicationTypeTitle;
        }



    }


}

