using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Session
{
    internal static class SessionManager
    {
        public static int UserId;
        public static string Username;
        public static int RoleId;
        public static string RoleName;

        public static void Clear()
        {
            SessionManager.UserId = 0;
            SessionManager.Username = null;
            SessionManager.RoleId = 0;
            SessionManager.RoleName = null;
        }
    }
}
