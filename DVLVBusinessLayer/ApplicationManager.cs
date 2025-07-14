using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.DVLVBusinessLayer;

namespace DVLVBusinessLayer
{
    
    public class ApplicationManager
    {
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
