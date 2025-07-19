using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DVLVBusinessLayer
{

    public class TestManager
    {

        public static bool AddTest(int AppointmentID,
                                int TestResult,
                                string Notes,
                                int UserID) {
            AppointmentManager.UpdateAppointmentLockStatus(AppointmentID, true);
            return DrivingTestData.AddTest(AppointmentID, TestResult, Notes, UserID);
            
        }
        public static int GetPreviousTrialsCount(int LocalApplicationID, enDrivingTestType TestType)
        {
            return DrivingTestData.GetPreviousTrialsCount(LocalApplicationID, (int)TestType);
        }
        public static bool AlreadyPassedTest(int LocalApplicationID,
            enDrivingTestType TestType)
        {
            return DrivingTestData.AlreadyPassedTest(LocalApplicationID, (int)TestType);
        }
    }
}
