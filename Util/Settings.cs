using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Settings
    {
        private const string SERVER = ".";
        private const string DATABASE = "DVLD";
        private const string PASSWORD = "sa123456";
        public const string IMAGES_PATH = @"E:\DVLV\images";
        public const string CACHE_PATH = @"E:\DVLV\cache\.last_login.txt";
        public static string ConnectionString
        {
            get
            {
                return $"Server={SERVER};Database={DATABASE};User ID=sa;Password={PASSWORD}";
            }
        }


    }
}
