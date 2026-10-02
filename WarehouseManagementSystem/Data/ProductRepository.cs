using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Models;

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
                           "GROUP BY Products.productID, Products.productName, Categories.categoryID, Categories.categoryName " +
                           "ORDER BY productName";

            List<Product> products = new List<Product>();

            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return products;
        }

        public void Insert(Product product)
        {
            string query = "INSERT INTO Products (productName, categoryID, createdByID) " +
                           "VALUES (@productName, @categoryId, @createdById)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productName", product.ProductName);
                        cmd.Parameters.AddWithValue("@categoryId", product.ProductCategoryId);
                        cmd.Parameters.AddWithValue("@createdById", 1); // CHANGE LATER!

                        cmd.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
        }

        public void Update(int id, Product product)
        {
            string query = "UPDATE Products SET productName = @productName, categoryID = @categoryId, alteredLastByID = @userId " +
                           "WHERE productID = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@productName", product.ProductName);
                        cmd.Parameters.AddWithValue("@categoryId", product.ProductCategoryId);
                        cmd.Parameters.AddWithValue("@userId", 1); // CHANGE LATER!
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Product GetById(int id) 
        {
            string query = "SELECT productName, categoryId FROM Products WHERE Products.productID=@id";
            Product product =  new Product();

            try
            {
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return product;
        }
    }
}
