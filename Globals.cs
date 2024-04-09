using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassVault
{
    public static class Globals
    {
        public static string username = string.Empty;
        public static string password = string.Empty;
        public static string Access_Level = string.Empty;
        public static int userid = 0;

        // *** DB connect parameters
        public static string dsnName = "xPVS";
        public static string connectionString = $"DSN={dsnName};";
    }
}
