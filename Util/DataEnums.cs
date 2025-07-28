using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public enum enDrivingTestType
    {
        None, Vision = 1, Theory = 2, Practical = 3
    }
    public enum enIssueReason
    {
        FirstTime = 1,
        Renew = 2,
        ReplacementForDamaged = 3,
        ReplacementForLost = 4
    }
    public enum enLicenseClass
    {
        Class1 = 1,
        Class2 = 2,
        Class3 = 3,
        Class4 = 4,
        Class5 = 5,
        Class6 = 6,
        Class7 = 7,
    }

}
