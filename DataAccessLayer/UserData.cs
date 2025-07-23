using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DataAccessLayer
{
    public class UserData
    {


        public static bool DeleteUser(int UserId)
        {
            int affectedRows = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"DELETE FROM Users
                            WHERE UserId = @UserId";

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@UserId", UserId);
            try
            {
                connection.Open();
                affectedRows = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                // !!!
            }
            finally
            {
                connection.Close();
            }

            return affectedRows > 0;
        }

        public static bool UpdateUser(User user)
        {
            int affectedRows = 0;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
               UPDATE [dbo].[Users]
               SET [UserName] = @Username
                  ,[PasswordHash] = @PasswordHash
                  ,[Salt] = @Salt
                  ,[IsActive] = @IsActive
               WHERE UserId = @UserId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@Username", user.UserName);
            command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
            command.Parameters.AddWithValue("@Salt", user.Salt);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@UserId", user.UserId);


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
        public static int? AddUserGetId(int personId, string username, string passwordHash, string salt, bool isActive)
        {

            int? userId = null;
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        INSERT INTO [dbo].[Users]
                                    ([PersonID]
                                    ,[UserName]
                                    ,[PasswordHash]
                                    ,[Salt]
                                    ,[IsActive])
                                VALUES
                                    (@PersonId
                                    ,@UserName
                                    ,@PasswordHash
                                    ,@Salt
                                    ,@IsActive);
                        SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@PersonId", personId);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@PasswordHash", passwordHash);
            command.Parameters.AddWithValue("@Salt", salt);
            command.Parameters.AddWithValue("@IsActive", isActive);



            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    userId = insertedID;
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
            return userId;
        }
        public static DataRow GetUserRowById(int userId)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT  *
                            FROM [dbo].[Users]
                            WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@UserID", userId);
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
            return dataTable.Rows[0];
        }
        public static int? GetUserId(string username)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        SELECT [UserID]
                        FROM [DVLD].[dbo].[Users]
                        WHERE Username = @username";
            int? UserId = null;
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserId = Convert.ToInt32(reader["UserId"]);
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
            return UserId;
        }

        public static bool IsActive(string username)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                        SELECT 1
                        FROM [DVLD].[dbo].[Users]
                        WHERE Username = @username
                            AND IsActive = 1";
            bool isActive = false;

            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@username", username);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isActive = true;
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
            return isActive;
        }


        public static DataTable GetUsersByActiveStatus(bool isActive)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT  *
                            FROM [dbo].[Users]
                            WHERE IsActive = @IsActive";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@IsActive", isActive);
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
        public static DataRow GetUserByUsername(string username)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT  *
                            FROM [dbo].[Users]
                            WHERE Username = @username";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@username", username);
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
        public static DataTable GetUsersDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"
                            SELECT  *
                            FROM [dbo].[Users]";
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
