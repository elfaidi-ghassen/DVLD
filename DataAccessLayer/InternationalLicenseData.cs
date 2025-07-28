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
    public class InternationalLicenseData
    {
        public static DataTable GetInterLicenseDataTableByPersonID(int personID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                               SELECT InternationalLicenseID
                                , CONCAT_WS(' ',
                                    FirstName,
                                    SecondName,
                                    ThirdName,
                                    LastName) AS FullName
                                , DateOfBirth
                                , Gendor
                                , ImagePath
                                , NationalNo
                                ,[ApplicationID]
                                ,[InternationalLicenses].[DriverID]
                                ,[IssuedUsingLocalLicenseID]
                                ,[IssueDate]
                                ,[ExpirationDate]
                                ,[IsActive]
                                ,[InternationalLicenses].CreatedByUserID
                            FROM [DVLD].[dbo].[InternationalLicenses]
                            JOIN Drivers
                                ON Drivers.DriverID = [InternationalLicenses].DriverID
                            JOIN People
                                ON People.PersonID = Drivers.PersonID
                            WHERE People.PersonID = @personID";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@personID", personID);

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
        public static DataTable GetInterLicenseDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                               SELECT InternationalLicenseID
                                , CONCAT_WS(' ',
                                    FirstName,
                                    SecondName,
                                    ThirdName,
                                    LastName) AS FullName
                                , DateOfBirth
                                , Gendor
                                , ImagePath
                                , NationalNo
                                ,[ApplicationID]
                                ,[InternationalLicenses].[DriverID]
                                ,[IssuedUsingLocalLicenseID]
                                ,[IssueDate]
                                ,[ExpirationDate]
                                ,[IsActive]
                                ,[InternationalLicenses].CreatedByUserID
                            FROM [DVLD].[dbo].[InternationalLicenses]
                            JOIN Drivers
                                ON Drivers.DriverID = [InternationalLicenses].DriverID
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
        public static DataRow GetInterLicenseCardInfoByLicenseID(int licenseID)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                               SELECT InternationalLicenseID
                                , CONCAT_WS(' ',
                                    FirstName,
                                    SecondName,
                                    ThirdName,
                                    LastName) AS FullName
                                , DateOfBirth
                                , Gendor
                                , ImagePath
                                , NationalNo
                                ,[ApplicationID]
                                ,[InternationalLicenses].[DriverID]
                                ,[IssuedUsingLocalLicenseID]
                                ,[IssueDate]
                                ,[ExpirationDate]
                                ,[IsActive]
                                ,[InternationalLicenses].CreatedByUserID
                            FROM [DVLD].[dbo].[InternationalLicenses]
                            JOIN Drivers
                                ON Drivers.DriverID = [InternationalLicenses].DriverID
                            JOIN People
                                ON People.PersonID = Drivers.PersonID
                            WHERE InternationalLicenseID = @licenseID";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@licenseID", licenseID);
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
        public static int? CreateLicense(
            int driverId, 
            int applicationID, 
            int localLicenseId, 
            DateTime issueDate, 
            DateTime expirationDate, 
            int active, 
            int userId
            )
        {
            int? licenseID = null;
            
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        INSERT INTO [dbo].[InternationalLicenses]
                               ([ApplicationID]
                               ,[DriverID]
                               ,[IssuedUsingLocalLicenseID]
                               ,[IssueDate]
                               ,[ExpirationDate]
                               ,[IsActive]
                               ,[CreatedByUserID])
                         VALUES
                            (
                                 @ApplicationID
                                ,@DriverID
                                ,@IssuedUsingLocalLicenseID
                                ,@IssueDate
                                ,@ExpirationDate
                                ,@IsActive
                                ,@CreatedByUserID
                            );

                        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@DriverID", driverId);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", localLicenseId);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@IsActive", active);
            command.Parameters.AddWithValue("@CreatedByUserID", userId);



            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    licenseID = insertedID;
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
            return licenseID;

        }
        public static bool HasActiveLicense(int driverId)
        {
            bool licenseExists = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT 1 AS LicenseExists
                            FROM [InternationalLicenses]
                            WHERE [DriverID] = @driverId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@driverId", driverId);


            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int HasLicense))
                {
                    licenseExists = (HasLicense == 1);
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
            return licenseExists;

        }
    }
}
