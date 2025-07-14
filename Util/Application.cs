using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    using System;

    namespace DVLVBusinessLayer
    {
        public enum enApplicationStatus
        {
            New = 1,
            Canceled = 2,
            Completed = 3
        }
        public class Application
        {
            public int ApplicationID { get; set; }
            public int ApplicantPersonID { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public enApplicationStatus ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public decimal PaidFees { get; set; }
            public int CreatedByUserID { get; set; }
        }
    }
}
