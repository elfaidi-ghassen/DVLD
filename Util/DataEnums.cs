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

}
