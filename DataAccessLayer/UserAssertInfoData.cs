using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataAccessLayer
{
    public class UserAssertInfoData
    {
        public static bool Add(int userId, string message, string feedback)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                    INSERT INTO [dbo].[ServiceErrorLog]
                        ([UserId]
                        ,[ErrorMessage]
                        ,[Feedback])
                    VALUES
                        (@userId
                        ,@message
                        ,@feedback)";
            
            
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@feedback", feedback);



            try
            {

                connection.Open();
                command.ExecuteScalar();
                
            }
            catch (Exception e)
            {
                // ---
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

    }
}
