using Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataAccessLayer
{

    public class ApplicationTypesData 
    {
        public static bool Update(ApplicationType type)
        {

            int affectedRows = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                    UPDATE [dbo].[ApplicationTypes]
                         SET [ApplicationTypeTitle] = @ApplicationTypeTitle
                               ,[ApplicationFees] = @ApplicationFees
                         WHERE ApplicationTypeId = @ApplicationTypeId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", type.ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", type.ApplicationFees);

            command.Parameters.AddWithValue("@ApplicationTypeId", type.ApplicationTypeID);


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

        public static DataRow GetApplicationTypeById(int id)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT * 
                     FROM ApplicationTypes
                     WHERE ApplicationTypeId = @ApplicationTypeId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@ApplicationTypeId", id);

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
            } else
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
                            FROM [dbo].[ApplicationTypes]";
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
