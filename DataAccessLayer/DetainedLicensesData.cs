using Models;
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
    public class DetainedLicensesData
    {

        public static int? DetainLicense(
            int licenseId,
            decimal fineAmount,
            int userId)
        {

            int? detainID = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                INSERT INTO [dbo].[DetainedLicenses]
                       ([LicenseID]
                       ,[DetainDate]
                       ,[FineFees]
                       ,[CreatedByUserID]
                       ,[IsReleased]
                       ,[ReleaseDate]
                       ,[ReleasedByUserID]
                       ,[ReleaseApplicationID])
                 VALUES
                        (
                        @licenseID,       
                        GETDATE(), 
                        @fees,
                        @userID,
                        0, -- IsReleased (false)
                        null,
                        null,
                        null
                        );
                SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@licenseID", licenseId);
            command.Parameters.AddWithValue("@fees", fineAmount);
            command.Parameters.AddWithValue("@userID", userId);

            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    detainID = Convert.ToInt32(result);
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
            return detainID;
        }

        public static DataTable GetRecordsDataTable()
        {
                DataTable dataTable = new DataTable();
                SqlConnection connection = new SqlConnection(Settings.ConnectionString);
                string QUERY = @"
                             SELECT [DetainID],Licenses.[LicenseID]
                            ,[DetainDate]
                            ,[FineFees]
                            ,DetainedLicenses.[CreatedByUserID]
                            ,[IsReleased]
                            ,[ReleaseDate]
                            ,[ReleasedByUserID]
                            ,[ReleaseApplicationID]
                            ,NationalNo
                            ,CONCAT_WS(' ',
                                FirstName,
                                SecondName,
                                ThirdName,
                                LastName) AS FullName
                            ,Drivers.DriverId
                            FROM [DVLD].[dbo].[DetainedLicenses]
                            JOIN Licenses
                            ON Licenses.LicenseID = DetainedLicenses.LicenseID
                            JOIN Drivers
                            ON Drivers.DriverID = Licenses.DriverID
                            JOIN People
                            ON People.PersonID = Drivers.PersonID";

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
        public static DataRow GetDetainedRecordByLicenseId(int licenseID)
        {

            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                             SELECT [DetainID],Licenses.[LicenseID]
                            ,[DetainDate]
                            ,[FineFees]
                            ,DetainedLicenses.[CreatedByUserID]
                            ,[IsReleased]
                            ,[ReleaseDate]
                            ,[ReleasedByUserID]
                            ,[ReleaseApplicationID]
                            ,NationalNo
                            ,CONCAT_WS(' ',
                                FirstName,
                                SecondName,
                                ThirdName,
                                LastName) AS FullName
                            ,Drivers.DriverId
                            FROM [DVLD].[dbo].[DetainedLicenses]
                            JOIN Licenses
                            ON Licenses.LicenseID = DetainedLicenses.LicenseID
                            JOIN Drivers
                            ON Drivers.DriverID = Licenses.DriverID
                            JOIN People
                            ON People.PersonID = Drivers.PersonID
                            WHERE Licenses.[LicenseID] = @licenseID";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("licenseID", licenseID);
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

        public static int? ReleaseLicense(int LicenseID, int UserId)
        {
            int? appId = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string APPLICATION_QUERY = @"
                    INSERT INTO [dbo].[Applications]
                       ([ApplicantPersonID]
                       ,[ApplicationDate]
                       ,[ApplicationTypeID]
                       ,[ApplicationStatus]
                       ,[LastStatusDate]
                       ,[PaidFees]
                       ,[CreatedByUserID])

                    VALUES (
                        (SELECT Drivers.PersonID FROM Licenses JOIN Drivers 
                        ON Drivers.DriverID = Licenses.DriverID WHERE LicenseID = @LicenseID),
                        GETDATE(),     
                        5, -- ApplicationTypeID
                        3,
                        GETDATE(),                      
                        (SELECT [ApplicationFees]
                         FROM [ApplicationTypes]
                         WHERE ApplicationTypeID = 5),
                        @UserID);
                     SELECT SCOPE_IDENTITY()";
                
            string RELEASE_QUERY = @"
                UPDATE [dbo].[DetainedLicenses]
                SET 
                     [IsReleased] = 1
                    ,[ReleaseDate] = GETDATE()
                    ,[ReleasedByUserID] = @UserID
                    ,[ReleaseApplicationID] = @ReleaseAppId
                WHERE LicenseID = @LicenseID";


            connection.Open();
            

            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                SqlCommand command1 = new SqlCommand(APPLICATION_QUERY, connection, transaction);
                command1.Parameters.AddWithValue("@LicenseID", LicenseID);
                command1.Parameters.AddWithValue("@UserID", UserId);
                object result = command1.ExecuteScalar();
                
                if (result != null)
                {
                    appId = Convert.ToInt32(result);
                }
                SqlCommand command2 = new SqlCommand(RELEASE_QUERY, connection, transaction);
                command2.Parameters.AddWithValue("@ReleaseAppId", appId);
                command2.Parameters.AddWithValue("@UserID", UserId);
                command2.Parameters.AddWithValue("@LicenseID", LicenseID);
                command2.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                connection.Close();
                return null;
            }
            finally
            {
                connection.Close();
            }

            return appId;

        }
    }
}
