using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DVLVBusinessLayer
{
    public class AppointmentManager
    {
        public static bool UpdateAppointmentDate(int AppointmentID, DateTime NewDate)
        {
            return AppointmentsData.UpdateAppointmentDate(AppointmentID, NewDate);
        }
        public static bool UpdateAppointmentLockStatus(int AppointmentID, bool status)
        {
            return AppointmentsData.UpdateAppointmentLockStatus(AppointmentID, status ? 1 : 0);
        }

        public static bool AddAppointment(enDrivingTestType TestType,
                                          int LocalApplicationID,
                                          DateTime AppointmentDate,
                                          decimal TestFees,
                                          int UserID,
                                          bool IsLocked)
        {

            return AppointmentsData.AddAppointment((int)TestType,
                                              LocalApplicationID,
                                              AppointmentDate,
                                              TestFees,
                                              UserID,
                                              IsLocked ? 1 : 0) != null;
        }
        public static bool HasActiveAppointment(int LocalApplicationID, enDrivingTestType TestType)
        {
            return GetAppointmentsByLocalAppId(LocalApplicationID, TestType)
                .Where(app => !app.IsLocked).Count() > 0;
        }
        private static TestAppointment RowToTestAppointment(DataRow row)
        {
            int? testTypeID = null;
            if (row["TestID"] != DBNull.Value)
            {
                testTypeID = Convert.ToInt32(row["TestID"]);
            }
                return new TestAppointment(
                Convert.ToInt32(row["TestAppointmentID"]),
                Convert.ToInt32(row["TestTypeID"]),
                Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]),
                (DateTime)row["AppointmentDate"],
                Convert.ToDecimal(row["PaidFees"]),
                Convert.ToInt32(row["CreatedByUserID"]),
                Convert.ToInt32(row["IsLocked"]) == 1,
                testTypeID
                );
        }
        public static List<TestAppointment> GetAppointmentsByLocalAppId(int localAppId, enDrivingTestType TestType)
        {
            List<TestAppointment> appointments = new List<TestAppointment>();
            foreach (DataRow row in AppointmentsData.GetDataTableByLocalApplicationId(localAppId, TestType).Rows)
            {
                appointments.Add(RowToTestAppointment(row));
            }
            return appointments;
        }
        public static TestAppointment GetAppointmentByID(int AppointmentID)
        {
            return RowToTestAppointment(AppointmentsData
                                        .GetAppointmentRowByID(AppointmentID));
        }
    }


}
