using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Data
{
    internal class SupplierProductRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;

        public List<SupplierForProduct> GetSuppliersByProductId(int prodId)
        {
            string query = "SELECT SupplierProduct.supplierID, Suppliers.supplierName, SupplierProduct.pricePerUnit " +
                           "FROM SupplierProduct " +
                           "INNER JOIN Suppliers ON Suppliers.supplierID = SupplierProduct.supplierID " +
                           "WHERE SupplierProduct.productID = @prodId " +
                           "ORDER BY Suppliers.supplierName";
            List<SupplierForProduct> suppliersForId = new List<SupplierForProduct>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@prodId", prodId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SupplierForProduct supProd = new SupplierForProduct(reader.GetInt32(0), 
                                                                          reader[1].ToString(), reader.GetDecimal(2));
                            suppliersForId.Add(supProd);
                        }
                    }
                }
            }
            return suppliersForId;
        }

        public List<ProductForSupplier> GetProductsBySupplierId(int supId)
        {
            string query = "SELECT SupplierProduct.productID, Products.productName, SupplierProduct.pricePerUnit " +
                           "FROM SupplierProduct " +
                           "INNER JOIN Products ON Products.productID = SupplierProduct.productID " +
                           "WHERE SupplierProduct.supplierID = @supId " +
                           "ORDER BY Products.productName";
            List<ProductForSupplier> productForId = new List<ProductForSupplier>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@supId", supId);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductForSupplier prodSup = new ProductForSupplier(reader.GetInt32(0), reader[1].ToString(), reader.GetDecimal(2));
                            productForId.Add(prodSup);
                        }
                    }
                }
            }
            return productForId;
        }

        public void Add(int productId, int supplierId, decimal price, int userId)
        {
            string query = "INSERT INTO SupplierProduct(supplierID, productID, pricePerUnit, createdByID) " +
                           "VALUES (@supId, @prodId, @price, @userId)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@supId", supplierId);
                    cmd.Parameters.AddWithValue("@prodId", productId);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(int productId, int supplierId, decimal price, int altId)
        {
            string query = "UPDATE SupplierProduct SET pricePerUnit = @price, alteredLastByID = @altId, alteredLastOn = GETDATE() " +
                           "WHERE productID = @prodId AND supplierID = @supId";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@altId", altId);
                    cmd.Parameters.AddWithValue("@prodId", productId);
                    cmd.Parameters.AddWithValue("@supId", supplierId);

                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void Delete(int productId, int supplierId)
        {
            string query = "DELETE FROM SupplierProduct WHERE productID = @prodId AND supplierID = @supId";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@prodId", productId);
                    cmd.Parameters.AddWithValue("@supId", supplierId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
