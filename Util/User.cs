using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class User
    {
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public bool IsActive { get; set; }

        // Constructor
        public User(int userId, int personId, string userName, string password, string salt, bool isActive)
        {
            UserId = userId;
            PersonId = personId;
            UserName = userName;
            PasswordHash = password;
            IsActive = isActive;
            Salt = salt;
        }

    }
}
