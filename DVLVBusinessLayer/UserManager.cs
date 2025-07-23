using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Util;

namespace DVLVBusinessLayer
{
    public class UserManager
    {

        public static bool DeleteUser(int UserId)
        {
            return UserData.DeleteUser(UserId);
        }
        public static bool UpdateUser(User user)
        {
            return UserData.UpdateUser(user);
        }
        public static int? AddUserGetId(int personId, string username, string password, bool isActive)
        {
            (byte[], byte[]) passwordSaltPair = PasswordHasher.HashPassword(password);
            string passwordHash = Convert.ToBase64String(passwordSaltPair.Item1);
            string salt = Convert.ToBase64String(passwordSaltPair.Item2);
            return UserData.AddUserGetId(personId, username, passwordHash, salt, isActive);
        }
    
        public static User GetUserByUsername(string username)
        {
            DataRow row = UserData.GetUserByUsername(username);
            if (row == null) { return null; }

            return DataRowToUser(row);
        }
        public static bool VerifyUser(string username, string password)
        {
            User user = GetUserByUsername(username);
            if (user == null) { return false; }

            return PasswordHasher.VerifyPassword(password,
                                    Convert.FromBase64String(user.Salt), 
                                    Convert.FromBase64String(user.PasswordHash));
        }

        public static int? GetUserId(string username)
        {
            return UserData.GetUserId(username);
        }
        public static bool IsActive(string username)
        {
            return UserData.IsActive(username);

        }
        public static User GetUserById(int userId)
        {
            return DataRowToUser(UserData.GetUserRowById(userId));
        }
        public static List<User> GetUsersByActiveStatus(bool isActive)
        {
            List<User> users = new List<User>();
            foreach (DataRow row in UserData.GetUsersByActiveStatus(isActive).Rows)
            {
                users.Add(DataRowToUser(row));
            }
            return users;
        }

        private static User DataRowToUser(DataRow row)
        {
            string salt = null;
            if (row["Salt"] != DBNull.Value)
            {
                salt = (string)row["Salt"];
            }
            return new User(
                        (int)row["UserID"],
                        (int)row["PersonID"],
                        (string)row["UserName"],
                        (string)row["PasswordHash"],
                        salt,
                        (bool)row["IsActive"]
                    );
        }
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            foreach (DataRow row in UserData.GetUsersDataTable().Rows)
            {
                users.Add(DataRowToUser(row));
            }
            return users;
        }


    }
}
