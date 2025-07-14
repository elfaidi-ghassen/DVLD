using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.DVLVBusinessLayer;
using Util;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class DrivingLicenseApplicationData
    {

        public static bool PersonHasActiveDLApplication(int personId, int licenseClassId)
        {
            bool hasLicense = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT 1 AS HasLicense
                            FROM LocalDrivingLicenseApplications  L
                            JOIN Applications A
                                ON L.ApplicationID = A.ApplicationID
                            WHERE A.ApplicantPersonID = @PersonID
                                AND L.LicenseClassID = @LicenseClassID
                                AND L.ApplicationStatus = 1;";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonID", personId);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassId);


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
        public static int? CreateApplication(int applicationId, int licenseClassId)
        {
            int? drivingLicenseApplicationID = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                               ([ApplicationID]
                               ,[LicenseClassID])
                           VALUES (
                                @ApplicationId,
                                @LicenseClassId);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ApplicationId", applicationId);
            command.Parameters.AddWithValue("@LicenseClassId", licenseClassId);


            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    drivingLicenseApplicationID = insertedID;
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
            return drivingLicenseApplicationID;


        }
    }
}
