using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Session;

namespace WarehouseManagementSystem.Data
{
    internal class SupplierRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;

        public List<Supplier> GetAll()
        {
            string query = "SELECT supplierID, supplierName, contactPerson, phone, email " +
                           "FROM Suppliers " +
                           "WHERE isActive = 1 " +
                           "ORDER BY supplierName";
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Supplier supplier = new Supplier(reader.GetInt32(0), reader[1].ToString(), 
                                                             reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                            suppliers.Add(supplier);
                        }
                    }
                }
            }
            return suppliers;
        }

        public Supplier GetById(int id)
        {
            string query = "SELECT supplierName, contactPerson, phone, email FROM Suppliers WHERE supplierID = @id";
            Supplier supplier = new Supplier();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            supplier.SupplierId = id;
                            supplier.SupplierName = reader[0].ToString();
                            supplier.ContactPerson = reader[1].ToString();
                            supplier.Phone = reader[2].ToString();
                            supplier.Email = reader[3].ToString();
                        }
                    }
                }
            }
             return supplier;
        }

        public void Insert(Supplier supplier, int userId)
        {
            string query = "INSERT INTO Suppliers(supplierName, contactPerson, phone, email, createdByID) " +
                           "VALUES (@supplierName, @contactPerson, @phone, @email, @userId)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@supplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@contactPerson", supplier.ContactPerson);
                    cmd.Parameters.AddWithValue("@phone", supplier.Phone);
                    cmd.Parameters.AddWithValue("@email", supplier.Email);
                    cmd.Parameters.AddWithValue("userId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(int supplierId, Supplier supplier, int userId)
        {
            string query = "UPDATE Suppliers SET supplierName = @supplierName, contactPerson = @contactPerson, " +
                           "phone = @phone, email = @email, alteredLastByID = @altID, alteredLastOn = GETDATE() " +
                           "WHERE supplierID = @supplierId";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@supplierId", supplierId);
                    cmd.Parameters.AddWithValue("@supplierName", supplier.SupplierName);
                    cmd.Parameters.AddWithValue("@contactPerson", supplier.ContactPerson);
                    cmd.Parameters.AddWithValue("@phone", supplier.Phone);
                    cmd.Parameters.AddWithValue("@email", supplier.Email);
                    cmd.Parameters.AddWithValue("@altID", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsNameTaken(string supplierName, int id)
        {
            string query = "SELECT COUNT(*) FROM Suppliers WHERE supplierName = @supplierName AND isActive = 1 AND supplierID <> @id";
            int count = 0;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@supplierName", supplierName);
                    cmd.Parameters.AddWithValue("@id", id);

                    count = (int)cmd.ExecuteScalar();
                }
            }

            return count > 0;
        }

        public int FindInactiveByName(string supplierName)
        {
            string query = "SELECT supplierID FROM Suppliers WHERE supplierName = @supplierName AND isActive = 0";
            int id = -1;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@supplierName", supplierName);

                    object result = cmd.ExecuteScalar();
                    id = (result == null || result == DBNull.Value) ? -1 : (int)result;
                }
            }

            return id;
        }

        public void Reactivate(int id, int altid)
        {
            string query = "UPDATE Suppliers SET isActive = 1, alteredLastByID = @altID, alteredLastOn = GETDATE() " +
                           "WHERE supplierID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@altId", altid);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsCrossreferenced(int id)
        {
            string query = "SELECT " +
                                "(SELECT COUNT(*) FROM SupplierProduct WHERE supplierID = @id) + " +
                                "(SELECT COUNT(*) FROM StockMovements WHERE supplierID = @id)";
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
            string querySoft = "UPDATE Suppliers SET isActive = 0, alteredLastByID = @altId, alteredLastOn = GETDATE() " +
                               "WHERE supplierID = @id";
            string queryHard = "DELETE FROM Suppliers WHERE supplierID = @id";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                if (IsCrossreferenced(id))
                {
                    using (SqlCommand cmd = new SqlCommand(querySoft, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@altId", altid);
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
