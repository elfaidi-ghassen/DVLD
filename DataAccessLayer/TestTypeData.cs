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
    public class TestTypeData
    {

        public static bool Update(TestType type)
        {

            int affectedRows = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        UPDATE [dbo].[TestTypes]
                           SET [TestTypeTitle] = @TestTypeTitle
                              ,[TestTypeDescription] = @TestTypeDescription
                              ,[TestTypeFees] = @TestTypeFees
                         WHERE TestTypeId = @TestTypeId";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@TestTypeTitle", type.TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", type.TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", type.TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeId", type.TestTypeID);


            try
            {
                connection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                return false;
            }
            finally
            {
                connection.Close();
            }

            return affectedRows > 0;
        }

        public static DataRow GetTestTypeById(int id)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT * 
                     FROM TestTypes
                     WHERE TestTypeId = @TestTypeId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@TestTypeId", id);

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
        public static DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT  *
                            FROM [dbo].[TestTypes]";
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
