using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLVBusinessLayer
{
    public class UserAssertInfoManager
    {
        public static bool Add(int userId, string message, string feedback)
        {
            return UserAssertInfoData.Add(userId, message, feedback);
        }
    }
}
