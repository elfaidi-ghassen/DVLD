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
        public static bool HasActiveAppointment(int LocalApplicationID)
        {
            return GetAppointmentsByLocalAppId(LocalApplicationID)
                .Where(app => !app.IsLocked).Count() > 0;
        }
        private static TestAppointment RowToTestAppointment(DataRow row)
        {
            return new TestAppointment(
                Convert.ToInt32(row["TestAppointmentID"]),
                Convert.ToInt32(row["TestTypeID"]),
                Convert.ToInt32(row["LocalDrivingLicenseApplicationID"]),
                (DateTime)row["AppointmentDate"],
                Convert.ToDecimal(row["PaidFees"]),
                Convert.ToInt32(row["CreatedByUserID"]),
                Convert.ToInt32(row["IsLocked"]) == 1
                );
        }
        public static List<TestAppointment> GetAppointmentsByLocalAppId(int localAppId)
        {
            List<TestAppointment> appointments = new List<TestAppointment>();
            foreach (DataRow row in AppointmentsData.GetDataTableByLocalApplicationId(localAppId).Rows)
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
