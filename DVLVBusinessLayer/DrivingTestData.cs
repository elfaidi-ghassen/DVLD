using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DVLVBusinessLayer
{
    public class DrivingTestData
    {

        public static bool AddTest(int AppointmentID,
                        int TestResult,
                        string Notes,
                        int UserID)
        {

            int? testID = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        INSERT INTO [dbo].[Tests]
                               ([TestAppointmentID]
                               ,[TestResult]
                               ,[Notes]
                               ,[CreatedByUserID])
                        VALUES (
                                @AppointmentID,
                                @TestResult,
                                @Notes,
                                @UserID);
                        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            if (Notes == null)
            {
            command.Parameters.AddWithValue("@Notes", DBNull.Value);
            } 
            else
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            command.Parameters.AddWithValue("@UserID", UserID);



            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    testID = insertedID;
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
            return testID != null;


        }
        public static bool AlreadyPassedTest(int LocalApplicationID,
            int TestTypeId)
        {
            bool passed = false;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        SELECT 1 AS Passed
                        FROM [TestAppointments]
                        JOIN Tests
                            ON Tests.[TestAppointmentID] 
                                        = [TestAppointments].[TestAppointmentID]
                        WHERE LocalDrivingLicenseApplicationID = @LocalApplicationID
                            AND [TestResult] = 1
                            AND [TestTypeID] = @TestTypeId";


            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
            command.Parameters.AddWithValue("@TestTypeId", TestTypeId);


            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int alreadyPassed))
                {
                    passed = (alreadyPassed == 1);
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
            return passed;

        }
        public static int GetPreviousTrialsCount(int LocalApplicationID, int TestTypeID)
        {

            int count = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        SELECT COUNT(*) AS PreviousTrials
                        FROM TestAppointments
                        JOIN Tests
                            ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                        WHERE LocalDrivingLicenseApplicationID = @LocalApplicationID
                            AND TestTypeID = @TestTypeID
                            AND TestResult = 0";


            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);


            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int failsCount))
                {
                    count = failsCount;
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
            return count;
        }
    }
}
