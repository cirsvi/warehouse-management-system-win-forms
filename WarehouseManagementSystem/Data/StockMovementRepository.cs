using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Data
{
    internal class StockMovementRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;

        public List<StockMovement> GetAll()
        {
            string query = "SELECT StockMovements.movementID, StockMovements.productID, Products.productName, " +
                           "StockMovements.supplierID, Suppliers.supplierName, StockMovements.quantity, " +
                           "StockMovements.movementType, StockMovements.movementDate, StockMovements.note, StockMovements.isActive " +
                           "FROM StockMovements " +
                           "INNER JOIN Products ON Products.productID = StockMovements.productID " +
                           "LEFT JOIN Suppliers ON StockMovements.supplierID = Suppliers.supplierID " +
                           "ORDER BY StockMovements.movementDate DESC";

            List<StockMovement> movements = new List<StockMovement>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StockMovement movement = new StockMovement(reader.GetInt32(0), reader.GetInt32(1),
                                                                       reader[2].ToString(), reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
                                                                       reader[4].ToString(), reader.GetInt32(5),
                                                                       (MovementType)Enum.Parse(typeof(MovementType), reader[6].ToString()),
                                                                       reader.GetDateTime(7), reader[8].ToString(), reader.GetBoolean(9));
                            movements.Add(movement);
                        }
                    }
                }
            }
            return movements;
        }

        public void ReceiveStock(StockMovement movement, int userId)
        {
            string query = "INSERT INTO StockMovements (productID, supplierID, " +
                           "movementType, quantity, movementDate, note, createdByID) " +
                           "VALUES (@prodId, @supId, @movementType, @quantity, @date, @note, @userId)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@prodId", movement.ProductId);
                    cmd.Parameters.AddWithValue("@supId", movement.SupplierId);
                    cmd.Parameters.AddWithValue("@movementType", movement.Type.ToString());
                    cmd.Parameters.AddWithValue("@quantity", movement.Quantity);
                    cmd.Parameters.AddWithValue("@date", movement.MovementDate);
                    cmd.Parameters.AddWithValue("@note", movement.Note);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ShipStock(StockMovement movement, int userId)
        {
            string query = "INSERT INTO StockMovements (productID, movementType, " +
                           "quantity, movementDate, note, createdByID) " +
                           "VALUES (@prodId, @movementType, @quantity, @date, @note, @userId)";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@prodId", movement.ProductId);
                    cmd.Parameters.AddWithValue("@movementType", movement.Type.ToString());
                    cmd.Parameters.AddWithValue("@quantity", movement.Quantity);
                    cmd.Parameters.AddWithValue("@date", movement.MovementDate);
                    cmd.Parameters.AddWithValue("@note", movement.Note);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int movementId, int altId)
        {
            string query = "UPDATE StockMovements SET isActive = 0, alteredLastByID = @userId, alteredLastOn = GETDATE() " +
                           "WHERE movementID = @movementId";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@userId", altId);
                    cmd.Parameters.AddWithValue("@movementId", movementId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
