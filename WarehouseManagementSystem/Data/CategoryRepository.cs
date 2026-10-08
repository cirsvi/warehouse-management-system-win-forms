using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Data
{
    internal class CategoryRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;

        public List<Category> GetAll()
        {
            string query = "SELECT Categories.categoryID, Categories.categoryName, COUNT(Products.categoryID) as productCount " +
                           "FROM Categories " +
                           "LEFT JOIN Products ON Products.categoryID = Categories.categoryID AND Products.isActive = 1 " +
                           "WHERE Categories.isActive = 1 " +
                           "GROUP BY Categories.categoryID, Categories.categoryName " +
                           "ORDER BY Categories.categoryName";
            List<Category> categories = new List<Category>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category category = new Category(reader.GetInt32(0), reader[1].ToString(), reader.GetInt32(2));
                        categories.Add(category);
                    }
                }
            }
            return categories;
        }

        public Category GetById(int id)
        {
            string query = "SELECT categoryName FROM Categories WHERE categoryID = @id AND isActive = 1";
            Category category = new Category();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            category.CategoryID = id;
                            category.CategoryName = reader[0].ToString();
                        }
                    }
                }

                return category;
            }
        }

        public bool IsNameTaken(string name, int id)
        {
            string query = "SELECT COUNT(*) FROM Categories WHERE categoryName = @name AND isActive = 1 AND categoryID <> @id";
            int count = 0;

            using(SqlConnection conn = new SqlConnection(connection))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);

                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count > 0;
        }

        public int FindInactiveByName(string name)
        {
            string query = "SELECT categoryID FROM Categories WHERE categoryName = @name AND isActive = 0";
            int id = -1;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", name);
                    object result = cmd.ExecuteScalar();
                    id = (result == null || result == DBNull.Value) ? -1 : (int)result;
                }
            }
            return id;
        }

        public void Reactivate(int id, int altid)
        {
            string query = "UPDATE Categories SET isActive = 1, alteredLastByID = @altid, alteredLastOn = GETDATE() " +
                           "WHERE categoryID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@altid", altid);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Insert(Category category, int id)
        {
            string query = "INSERT INTO Categories (categoryName, createdByID) VALUES (@name, @id)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", category.CategoryName);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void Update(int id, Category category, int altid)
        {
            string query = "UPDATE Categories SET categoryName = @name, alteredLastByID = @altid, alteredLastOn = GETDATE() " +
                           "WHERE categoryID = @id";

            using(SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", category.CategoryName);
                    cmd.Parameters.AddWithValue("@altid", altid);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsCrossreferenced(int id)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE Products.categoryID = @id";
            int count = 0;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count > 0;
        }

        public void DeleteById(int id, int altid)
        {
            string querySoft = "UPDATE Categories SET isActive = 0, alteredLastByID = @altid, alteredLastOn = GETDATE() " +
                               "WHERE categoryID = @id";
            string queryHard = "DELETE FROM Categories WHERE categoryID = @id";

            using( SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                if (IsCrossreferenced(id))
                {
                    using (SqlCommand cmd = new SqlCommand(querySoft, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@altid", altid);

                        cmd.ExecuteNonQuery();
                    }
                } else
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
