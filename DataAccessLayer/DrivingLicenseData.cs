using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataAccessLayer
{
    public class DrivingLicenseData
    {
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
                            GETDATE() +     
                                  (SELECT DefaultValidityLength
                                   FROM LicenseClasses
                                   WHERE LicenseClassID = (SELECT LicenseClassID
                                     FROM LocalDrivingLicenseApplications LD
                                     WHERE LD.ApplicationID = @ApplicationID)),
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
