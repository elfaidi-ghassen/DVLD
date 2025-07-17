using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
using Util.DVLVBusinessLayer;

namespace DataAccessLayer
{
    public class LocalDLApplicationData
    {

        public static bool DeleteEntireApplication(int localAppId, int appId)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            
            string DELETE_DL_APP_QUERY = @"
                    DELETE FROM [dbo].[LocalDrivingLicenseApplications]
                    WHERE LocalDrivingLicenseApplicationID = @localAppId";
            string DELETE_APP_QUERY = @"
                    DELETE FROM [dbo].[Applications]
                    WHERE ApplicationID = @appId;";
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {

                SqlCommand command1 = new SqlCommand(DELETE_DL_APP_QUERY, connection, transaction);
                command1.Parameters.AddWithValue("@localAppId", localAppId);
            
                SqlCommand command2 = new SqlCommand(DELETE_APP_QUERY, connection, transaction);
                command2.Parameters.AddWithValue("@appId", appId);

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                transaction.Commit();

            }
            catch (Exception e)
            {
                transaction.Rollback();
            }
            finally
            {
                connection.Close();
            }

            return true;
        }

        public static int GetApplicationIdByLocalId(int localAppId)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                    SELECT ApplicationID
                    FROM LocalDrivingLicenseApplications
                    WHERE LocalDrivingLicenseApplicationID = @localAppId;";
            int? AppId = null;
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@localAppId", localAppId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    AppId = Convert.ToInt32(reader["ApplicationID"]);
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
            return (int)AppId;

        }


        public static DataRow GetApplicatioByLocalId(int localAppId)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT      
                                LD.LocalDrivingLicenseApplicationID
                                ,LD.LicenseClassID
                                ,LC.ClassName
                                ,PE.FirstName + ' ' + PE.LastName 
                                    AS FullName
                                ,PE.NationalNo
                                ,AP.ApplicationDate
                                ,AP.ApplicationStatus
                                , COUNT(DISTINCT CASE WHEN TestResult = 1 THEN TestTypeID ELSE NULL END) as PassedTests
                        FROM LocalDrivingLicenseApplications LD
                        JOIN LicenseClasses LC
                            ON LD.LicenseClassID = LC.LicenseClassID
                        JOIN Applications AP
                            ON AP.ApplicationID = LD.ApplicationID
                        JOIN People PE
                            ON PE.PersonID = AP.ApplicantPersonID
                        LEFT JOIN TestAppointments
                            ON TestAppointments.LocalDrivingLicenseApplicationID
                                        = LD.LocalDrivingLicenseApplicationID
                        LEFT JOIN Tests
                            ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID

                        WHERE LD.LocalDrivingLicenseApplicationID = @localId
                        GROUP BY 
                            LD.LocalDrivingLicenseApplicationID,
                            LD.LicenseClassID, 
                            LC.ClassName, 
                            PE.FirstName + ' ' + PE.LastName,
                            PE.NationalNo,
                            AP.ApplicationDate,
                            AP.ApplicationStatus;
                            ";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@localId", localAppId);
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
        public static DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            
            string QUERY = @"SELECT      
                                LD.LocalDrivingLicenseApplicationID
                                ,LD.LicenseClassID
                                ,LC.ClassName
                                ,PE.FirstName + ' ' + PE.LastName 
                                    AS FullName
                                ,PE.NationalNo
                                ,AP.ApplicationDate
                                ,AP.ApplicationStatus
                                , COUNT(DISTINCT CASE WHEN TestResult = 1 THEN TestTypeID ELSE NULL END) as PassedTests
                        FROM LocalDrivingLicenseApplications LD
                        JOIN LicenseClasses LC
                            ON LD.LicenseClassID = LC.LicenseClassID
                        JOIN Applications AP
                            ON AP.ApplicationID = LD.ApplicationID
                        JOIN People PE
                            ON PE.PersonID = AP.ApplicantPersonID
                        LEFT JOIN TestAppointments
                            ON TestAppointments.LocalDrivingLicenseApplicationID
                                        = LD.LocalDrivingLicenseApplicationID
                        LEFT JOIN Tests
                            ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID

                        GROUP BY 
                            LD.LocalDrivingLicenseApplicationID,
                            LD.LicenseClassID, 
                            LC.ClassName, 
                            PE.FirstName + ' ' + PE.LastName,
                            PE.NationalNo,
                            AP.ApplicationDate,
                            AP.ApplicationStatus;
                            ";
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


        public static DataTable GetDataTableByStatusDataTable(enApplicationStatus status)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT      
                                LD.LocalDrivingLicenseApplicationID
                                ,LD.LicenseClassID
                                ,LC.ClassName
                                ,PE.FirstName + ' ' + PE.LastName 
                                    AS FullName
                                ,PE.NationalNo
                                ,AP.ApplicationDate
                                ,AP.ApplicationStatus
                                , COUNT(DISTINCT CASE WHEN TestResult = 1 THEN TestTypeID ELSE NULL END) as PassedTests
                        FROM LocalDrivingLicenseApplications LD
                        JOIN LicenseClasses LC
                            ON LD.LicenseClassID = LC.LicenseClassID
                        JOIN Applications AP
                            ON AP.ApplicationID = LD.ApplicationID
                        JOIN People PE
                            ON PE.PersonID = AP.ApplicantPersonID
                        LEFT JOIN TestAppointments
                            ON TestAppointments.LocalDrivingLicenseApplicationID
                                        = LD.LocalDrivingLicenseApplicationID
                        LEFT JOIN Tests
                            ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                        WHERE ApplicationStatus = @STATUS
                        GROUP BY 
                            LD.LocalDrivingLicenseApplicationID,
                            LD.LicenseClassID, 
                            LC.ClassName, 
                            PE.FirstName + ' ' + PE.LastName,
                            PE.NationalNo,
                            AP.ApplicationDate,
                            AP.ApplicationStatus;";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@STATUS", (int)status);
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
