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
    internal class CategoryRepository
    {
        private string connection = System.Configuration.ConfigurationManager.ConnectionStrings["WarehouseDB"].ConnectionString;

        public List<Category> GetAll()
        {
            string query = "SELECT categoryID, categoryName FROM Categories ORDER BY categoryName";
            List<Category> categories = new List<Category>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    SqlCommand command = new SqlCommand(query, conn);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Category category = new Category(reader.GetInt32(0), reader[1].ToString());
                            categories.Add(category);
                        }
                    }
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);

            }
            return categories;
        }
    }
}
