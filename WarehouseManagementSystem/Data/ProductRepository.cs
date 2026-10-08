using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Session;

namespace WarehouseManagementSystem.Data
{
    internal class ProductRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;

        public List<Product> GetAll()
        {
            string query = "SELECT Products.productID, Products.productName, Categories.categoryID, Categories.categoryName, " +
                           "ISNULL(SUM(CASE WHEN StockMovements.movementType = 'IN' " +
                                           "THEN StockMovements.quantity " +
                                           "ELSE -StockMovements.quantity END), 0) AS currentStock " +
                           "FROM Products " +
                           "INNER JOIN Categories ON Products.categoryID=Categories.categoryID " +
                           "LEFT JOIN StockMovements ON StockMovements.productID=Products.productID " +
                           "WHERE Products.isActive = 1 " +
                           "GROUP BY Products.productID, Products.productName, Categories.categoryID, Categories.categoryName " +
                           "ORDER BY productName";

            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product(reader.GetInt32(0), reader[1].ToString(), 
                                reader.GetInt32(2), reader[3].ToString(), reader.GetInt32(4));
                            products.Add(product);
                        }
                    }
                }

            }

            return products;
        }

        public void Insert(Product product)
        {
            string query = "INSERT INTO Products (productName, categoryID, createdByID) " +
                           "VALUES (@productName, @categoryId, @createdById)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productName", product.ProductName);
                    cmd.Parameters.AddWithValue("@categoryId", product.ProductCategoryId);
                    cmd.Parameters.AddWithValue("@createdById", SessionManager.UserId);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void Update(int id, Product product)
        {
            string query = "UPDATE Products SET productName = @productName, categoryID = @categoryId, alteredLastByID = @userId, alteredLastOn = GETDATE() " +
                           "WHERE productID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productName", product.ProductName);
                    cmd.Parameters.AddWithValue("@categoryId", product.ProductCategoryId);
                    cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Reactivate(int id)
        {
            string query = "UPDATE Products SET isActive = 1, alteredLastByID = @userId, alteredLastOn = GETDATE() " +
                           "WHERE productID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

            }
        }
        
        public bool IsNameTaken(string name, int id)
        {
            string query = "SELECT COUNT(*) FROM Products " +
                           "WHERE productName = @name AND isActive = 1 AND productID <> @id";
            int count = 0;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
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
            string query = "SELECT productID FROM Products " +
                           "WHERE productName = @name AND isActive = 0";
            int id = -1;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", name);

                    object result = cmd.ExecuteScalar();
                    id = (result == null || result == DBNull.Value) ? -1 : Convert.ToInt32(result);
                }
            }

            return id;
        }

        public Product GetById(int id) 
        {
            string query = "SELECT productName, categoryId FROM Products " +
                           "WHERE Products.productID=@id";
            Product product =  new Product();

            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product.ProductId = id;
                            product.ProductName = reader[0].ToString();
                            product.ProductCategoryId = reader.GetInt32(1);
                        }
                    }
                }
            }

            return product;
        }

        public bool IsCrossreferenced (int id)
        {
            string query = "SELECT " +
                                "(SELECT COUNT(*) FROM StockMovements WHERE productID = @id) + " +
                                "(SELECT COUNT(*) FROM SupplierProduct WHERE productID = @id)";
            int count = 0;

            using (SqlConnection  conn = new SqlConnection(connection))
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

        public void DeleteById(int id)
        {
            string querySoft = "UPDATE Products SET isActive = 0, alteredLastByID = @userId, alteredLastOn = GETDATE() " +
                               "WHERE productID = @id";
            string queryHard = "DELETE FROM Products WHERE productID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                if (IsCrossreferenced(id))
                {
                    using (SqlCommand cmd = new SqlCommand(querySoft, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", SessionManager.UserId);
                        cmd.Parameters.AddWithValue("@id", id);
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
