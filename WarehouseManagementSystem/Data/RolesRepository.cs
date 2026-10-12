using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Data
{
    internal class RolesRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;


        public List<Role> GetAll()
        {
            string query = "SELECT roleID, roleName FROM Roles ORDER BY rolename";
            List<Role> roles = new List<Role>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Role role = new Role(reader.GetInt32(0), reader[1].ToString());
                            roles.Add(role);
                        }
                    }
                }
            }

            return roles;
        }

    }
}
