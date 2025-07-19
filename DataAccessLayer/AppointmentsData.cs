using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataAccessLayer
{
    public class AppointmentsData
    {

        public static bool UpdateAppointmentDate(int AppointmentID, DateTime NewDate)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                   UPDATE TestAppointments
                   SET 
                      AppointmentDate = @AppointmentDate
                   WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@AppointmentDate", NewDate);
            command.Parameters.AddWithValue("@TestAppointmentID", AppointmentID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }

            return true;
        }


        public static DataRow GetAppointmentRowByID(int AppointmentID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                           SELECT [TestAppointmentID]
                          ,[TestTypeID]
                          ,[LocalDrivingLicenseApplicationID]
                          ,[AppointmentDate]
                          ,[PaidFees]
                          ,[CreatedByUserID]
                          ,[IsLocked]
                      FROM [DVLD].[dbo].[TestAppointments]
                      WHERE TestAppointmentID = @AppointmentID";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }
            return dataTable.Rows.Count == 1 ? dataTable.Rows[0] : null;
        }

        public static int? AddAppointment(int TestTypeID,
                                  int LocalApplicationID,
                                  DateTime AppointmentDate,
                                  decimal TestFees,
                                  int UserID,
                                  int IsLocked)
        {


                int? appointmentID = null;
                SqlConnection connection = new SqlConnection(Settings.ConnectionString);
                string QUERY = @"
                            INSERT INTO [dbo].[TestAppointments]
                                   ([TestTypeID]
                                   ,[LocalDrivingLicenseApplicationID]
                                   ,[AppointmentDate]
                                   ,[PaidFees]
                                   ,[CreatedByUserID]
                                   ,[IsLocked])
                             VALUES (
                                    @TestTypeID
                                   ,@LocalApplicationID
                                   ,@AppointmentDate
                                   ,@TestFees
                                   ,@UserID
                                   ,@IsLocked);
                             SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(QUERY, connection);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);

                command.Parameters.AddWithValue("@TestFees", TestFees);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@IsLocked", IsLocked);


                try
                {

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        appointmentID = insertedID;
                    }
                }
                catch (Exception e)
                {
                    // ---
                }
                finally
                {
                    connection.Close();
                }
                return appointmentID;

            }
            public static DataTable GetDataTableByLocalApplicationId(int localAppId)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                           SELECT [TestAppointmentID]
                          ,[TestTypeID]
                          ,[LocalDrivingLicenseApplicationID]
                          ,[AppointmentDate]
                          ,[PaidFees]
                          ,[CreatedByUserID]
                          ,[IsLocked]
                      FROM [DVLD].[dbo].[TestAppointments]
                      WHERE LocalDrivingLicenseApplicationID = @localAppId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@localAppId", localAppId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
    }
}
