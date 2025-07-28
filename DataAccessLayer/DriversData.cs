using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataAccessLayer
{
    public class DriversData
    {

        public static DataTable GetDriversViewDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT Licenses.[DriverID]
                            ,[People].[PersonID]
                            ,Drivers.[CreatedByUserID]
                            ,NationalNo
                            ,CONCAT_WS(' ',
                                FirstName,
                                SecondName,
                                ThirdName,
                                LastName) AS FullName
                            ,[CreatedDate]
                            , COUNT(LicenseID) AS ActiveLicensesCount
                        FROM [Drivers]
                        JOIN [People]                         
                            ON [People].[PersonID] = [Drivers].[PersonID]          
                        JOIN [Licenses]
                        ON [Licenses].[DriverID] = [Drivers].[DriverID]
                    GROUP BY Licenses.DriverID, [People].[PersonID], NationalNo, Drivers.CreatedByUserID, CONCAT_WS(' ',
                                FirstName,
                                SecondName,
                                ThirdName,
                                LastName), CreatedDate";
            SqlCommand command = new SqlCommand(QUERY, connection);
            
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

        public static DataRow GetDataRowByPersonID(int PersonID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT [DriverID]
                           ,[PersonID]
                           ,[CreatedByUserID]
                           ,[CreatedDate]
                        FROM [Drivers]
                        WHERE PersonID = @PersonID ";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
        public static DataRow GetDataRowByDriverId(int DriverId)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT [DriverID]
                           ,[PersonID]
                           ,[CreatedByUserID]
                           ,[CreatedDate]
                        FROM [Drivers]
                        WHERE DriverId = @DriverId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@DriverId", DriverId);
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
        public static bool PersonIsDriver(int PersonID)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        SELECT 1 as IsDriver
                        FROM Drivers
                        WHERE PersonID = @PersonID";
            bool isActive = false;

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isActive = true;
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
            return isActive;
        }


        public static int? AddDriverGetId(int PersonID, int UserID)
        {
            int? driverId = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        INSERT INTO [dbo].[Drivers]
                            ([PersonID]
                            ,[CreatedByUserID]
                            ,[CreatedDate])
                        VALUES
                            (@PersonID,
                             @CreatedByUserID,
                             GETDATE());
                        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", UserID);



            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    driverId = insertedID;
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
            return driverId;
        }

    }
}
