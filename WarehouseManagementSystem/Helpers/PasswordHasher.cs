using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Helpers
{
    internal class PasswordHasher
    {
        public static string Hash(string plainPassword)
        {
            return BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }

        public static bool Verify(string plainPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, storedHash);
        }
    }
}
