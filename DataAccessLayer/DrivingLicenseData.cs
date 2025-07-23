    using System;
    using System.Data;
    using System.Data.SqlClient;
    using Util;

    namespace DataAccessLayer
    {
    public class DrivingLicenseData
    {


        public static DataTable GetLicensesDataTableByPerson(int personID)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                    SELECT Licenses.[LicenseID]
                            ,Licenses.[ApplicationID]
                            ,Licenses.[DriverID]
                            ,Licenses.[LicenseClass]
                            ,Licenses.[IssueDate]
                            ,Licenses.[ExpirationDate]
                            ,Licenses.[Notes]
                            ,Licenses.[PaidFees]
                            ,Licenses.[IsActive]
                            ,Licenses.[IssueReason]
                            ,Licenses.[CreatedByUserID]
                            ,LocalDrivingLicenseApplications.[LocalDrivingLicenseApplicationID]
                            ,LocalDrivingLicenseApplications.[LicenseClassID]
                            ,[ClassName]
                            , CONCAT_WS(' ',
                                FirstName,
                                SecondName,
                                ThirdName,
                                LastName) AS FullName
                            , NationalNo
                            , Gendor
                            , DateOfBirth
                            , ImagePath
                            , CASE 
                                  WHEN EXISTS (
                                     SELECT 1 FROM DetainedLicenses 
                                     WHERE LicenseID = Licenses.LicenseID AND IsReleased = 0
                                  ) THEN 1 ELSE 0
                              END  AS isDetained
                        FROM Licenses
                        JOIN [LocalDrivingLicenseApplications]
                            ON [LocalDrivingLicenseApplications].ApplicationID = 
                                                    Licenses.ApplicationID
                        JOIN LicenseClasses
                            ON LicenseClasses.LicenseClassID =
                                                    LocalDrivingLicenseApplications.LicenseClassID
                        JOIN Drivers
                            ON Drivers.DriverID = Licenses.DriverID
                        JOIN People
                            ON People.PersonID =
                                            Drivers.PersonID
                        WHERE People.PersonID = @personID
                        ORDER BY Licenses.[IssueDate] DESC";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("personID", personID);
            DataTable result = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    result.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception if needed

            }
            finally
            {
                connection.Close();
            }

            return result;
        }
        public static DataRow GetLicenseCardRow(int localAppId)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                    SELECT Licenses.[LicenseID]
                            ,Licenses.[ApplicationID]
                            ,Licenses.[DriverID]
                            ,Licenses.[LicenseClass]
                            ,Licenses.[IssueDate]
                            ,Licenses.[ExpirationDate]
                            ,Licenses.[Notes]
                            ,Licenses.[PaidFees]
                            ,Licenses.[IsActive]
                            ,Licenses.[IssueReason]
                            ,Licenses.[CreatedByUserID]
                            ,LocalDrivingLicenseApplications.[LocalDrivingLicenseApplicationID]
                            ,LocalDrivingLicenseApplications.[LicenseClassID]
                            ,[ClassName]
                            , CONCAT_WS(' ',
                                FirstName,
                                SecondName,
                                ThirdName,
                                LastName) AS FullName
                            , NationalNo
                            , Gendor
                            , DateOfBirth
                            , ImagePath
                            , CASE 
                                  WHEN EXISTS (
                                     SELECT 1 FROM DetainedLicenses 
                                     WHERE LicenseID = Licenses.LicenseID AND IsReleased = 0
                                  ) THEN 1 ELSE 0
                              END  AS isDetained
                        FROM Licenses
                        JOIN [LocalDrivingLicenseApplications]
                            ON [LocalDrivingLicenseApplications].ApplicationID = 
                                                    Licenses.ApplicationID
                        JOIN LicenseClasses
                            ON LicenseClasses.LicenseClassID =
                                                    LocalDrivingLicenseApplications.LicenseClassID
                        JOIN Drivers
                            ON Drivers.DriverID = Licenses.DriverID
                        JOIN People
                            ON People.PersonID =
                                            Drivers.PersonID
                        WHERE [LocalDrivingLicenseApplications]
                            .LocalDrivingLicenseApplicationID = @localAppId";
                ;
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@localAppId", localAppId);

            DataTable result = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    result.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception if needed

            }
            finally
            {
                connection.Close();
            }

            if (result.Rows.Count == 1)
            {
                return result.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public static bool HasDrivingLicenseWithClass(
                int personId, int LicenseClassID)
        {
            bool hasLicense = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT 1 AS HasLicense
                            FROM Licenses
                            JOIN Drivers
                                ON Drivers.DriverID = Licenses.DriverID
                            WHERE PersonID = @PersonID
                                AND LicenseClass = @LicenseClassID";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonID", personId);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int HasLicense))
                {
                    hasLicense = (HasLicense == 1);
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
            return hasLicense;
        }

        public static int? AddLicenseGetId(
            int ApplicationID,
            int DriverID,
            string Notes,
            bool IsActive,
            enIssueReason IssueReason,
            int UserID)
        {
            int? licenseId = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        INSERT INTO [dbo].[Licenses]
                            ([ApplicationID], [DriverID], [LicenseClass]
                            ,[IssueDate], [ExpirationDate], [Notes]
                            ,[PaidFees],[IsActive],[IssueReason],[CreatedByUserID])
                        VALUES
                            (@ApplicationID,
                            @DriverID,
                            (SELECT LicenseClassID
                                FROM LocalDrivingLicenseApplications LD
                                WHERE LD.ApplicationID = @ApplicationID),
                            GETDATE(),
                            DATEADD(year,     
                                    
                                    (SELECT DefaultValidityLength
                                    FROM LicenseClasses
                                    WHERE LicenseClassID = (SELECT LicenseClassID
                                        FROM LocalDrivingLicenseApplications LD
                                        WHERE LD.ApplicationID = @ApplicationID)),
                                    
                                    GETDATE()),
                            @Notes,
                            (SELECT ClassFees
                                    FROM LicenseClasses
                                    WHERE LicenseClassID = (SELECT LicenseClassID
                                        FROM LocalDrivingLicenseApplications LD
                                        WHERE LD.ApplicationID = @ApplicationID)),
                            @IsActive,
                            @IssueReason,
                            @CreatedByUserID);

                            UPDATE Applications
                            SET ApplicationStatus = 3
                            WHERE ApplicationID = @ApplicationID;
                        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            if (Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);
            command.Parameters.AddWithValue("@IssueReason", (int)IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", UserID);



            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    licenseId = insertedID;
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
            return licenseId;
        }
    }
    }
