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
