using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataAccessLayer
{
    public class ApplicationData
    {
        public static int? Add(
               int applicantPersonID,
               DateTime applicationDate,
               int applicationTypeID,
               int applicationStatus,
               DateTime lastStatusDate,
               decimal paidFees,
               int createdByUserID)
        {
            int? applicationID = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            INSERT INTO [dbo].[Applications]
                                   ([ApplicantPersonID]
                                   ,[ApplicationDate]
                                   ,[ApplicationTypeID]
                                   ,[ApplicationStatus]
                                   ,[LastStatusDate]
                                   ,[PaidFees]
                                   ,[CreatedByUserID])
                             VALUES (
                                    @ApplicantPersonID,
                                    @ApplicationDate,
                                    @ApplicationTypeID,
                                    @ApplicationStatus,
                                    @LastStatusDate,
                                    @PaidFees,
                                    @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);

            command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);


            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    applicationID = insertedID;
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
            return applicationID;

        }
    }
}
