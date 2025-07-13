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
            return UserData.AddUserGetId(personId, username, password, isActive);
        }
    
        public static bool VerifyUser(string username, string password)
        {
            return UserData.GetUserId(username, password) != null;
        }

        public static int? GetUserId(string username, string password)
        {
            return UserData.GetUserId(username, password);
        }
        public static bool IsActive(string username, string password)
        {
            return UserData.IsActive(username, password);

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
            return new User(
                        (int)row["UserID"],
                        (int)row["PersonID"],
                        (string)row["UserName"],
                        (string)row["Password"],
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
