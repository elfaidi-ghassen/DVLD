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
    }
}
