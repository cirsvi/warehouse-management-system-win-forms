using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Data
{
    internal class UserRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;

        public List<User> GetAll()
        {
            string query = "SELECT Users.userID, Users.username, Roles.roleID, Roles.roleName, Users.createdOn " +
                           "FROM Users " +
                           "INNER JOIN Roles ON Users.roleID=Roles.roleID " +
                           "WHERE Users.isActive = 1 " +
                           "ORDER BY Users.username";
            List<User> users = new List<User>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(reader.GetInt32(0), reader[1].ToString(), reader.GetInt32(2), reader[3].ToString(), reader[4].ToString());
                            users.Add(user);
                        }
                    }
                }
            }
            return users;
        }

        public void Insert(User user)
        {
            string query = "INSERT INTO Users (username, passwordHash, roleID) " +
                           "VALUES (@username, @password, @roleId)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@roleId", user.RoleId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(User user, int altId)
        {
            string query = "UPDATE Users SET username = @username, roleID = @roleId, " +
                           "alteredLastByID = @altid, alteredLastOn = GETDATE() WHERE userID = @id";

            using(SqlConnection conn = new SqlConnection(connection))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@altid", altId);
                    cmd.Parameters.AddWithValue("@id", user.UserId);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@roleId", user.RoleId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePassword(int id, string password, int altId)
        {
            string query = "UPDATE Users SET passwordHash = @password, alteredLastByID = @altid, alteredLastOn = GETDATE() " +
                           "WHERE userID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@altid", altId);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User GetById(int id)
        {
            string query = "SELECT username, roleID FROM Users WHERE Users.userID = @id AND Users.isActive = 1";
            User user = new User();


            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            user.UserId = id;
                            user.Username = reader[0].ToString();
                            user.RoleId = reader.GetInt32(1);
                        }
                    }
                }
            }
            return user;
        }

        public string GetPasswordById(int id)
        {
            string query = "SELECT passwordHash FROM Users WHERE userID = @id AND Users.isActive = 1";
            string password = null;

            using(SqlConnection conn = new SqlConnection(connection))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            password = reader[0].ToString();
                        }
                    }
                }
            }
            return password;
        }

        public User GetByUsername(string username)
        {
            string query = "SELECT Users.userID, Users.username, Users.passwordHash, Roles.roleID, Roles.roleName " +
                           "FROM Users " +
                           "INNER JOIN Roles ON Users.roleID = Roles.roleID " +
                           "WHERE Users.username = @username AND Users.isActive = 1";
            User user = null;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@username", username);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            user = new User(reader.GetInt32(0), reader[1].ToString(), 
                                            reader[2].ToString(), reader.GetInt32(3), reader[4].ToString());
                        }
                    }
                }
            }

            return user;
        }

        public bool IsUsernameTaken(string username, int id)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE username = @username AND isActive = 1 AND userID <> @id";
            int count = 0;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@id", id);

                    count = (int)cmd.ExecuteScalar();
                }
            }

            return count > 0;

        }

        public int FindInactiveByUsername(string username)
        {
            string query = "SELECT userID FROM Users WHERE username = @username AND isActive = 0";
            int id = -1;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();
                    id = (result == null || result == DBNull.Value) ? -1 : Convert.ToInt32(result);
                }
            }
            return id;
        }

        public bool IsCrossreferenced(int id)
        {
            string query = "SELECT " +
                           "(SELECT COUNT(*) FROM Categories WHERE createdByID = @id OR alteredLastByID = @id) + " +
                           "(SELECT COUNT(*) FROM Products WHERE createdByID = @id OR alteredLastByID = @id) + " +
                           "(SELECT COUNT(*) FROM Suppliers WHERE createdByID = @id OR alteredLastByID = @id) + " +
                           "(SELECT COUNT(*) FROM SupplierProduct WHERE createdByID = @id OR alteredLastByID = @id) + " +
                           "(SELECT COUNT(*) FROM StockMovements WHERE createdByID = @id OR alteredLastByID = @id)";
            int count = 0;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count > 0;
        }

        public void Reactivate(int id, int altId)
        {
            string query = "UPDATE Users SET isActive = 1, alteredLastByID = @altid, alteredLastOn = GETDATE() " +
                           "WHERE userID = @id";

            using(SqlConnection conn = new SqlConnection(connection))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@altid", altId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteById(int id, int altId)
        {
            string querySoft = "UPDATE Users SET isActive = 0, alteredLastByID = @altid, alteredLastOn = GETDATE() " +
                                "WHERE userID = @id";
            string queryHard = "DELETE FROM Users WHERE userID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                if (IsCrossreferenced(id))
                {
                    using (SqlCommand cmd = new SqlCommand(querySoft, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@altid", altId);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand(queryHard, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
