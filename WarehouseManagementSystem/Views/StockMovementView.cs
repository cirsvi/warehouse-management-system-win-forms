using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Session;

namespace WarehouseManagementSystem
{
    public partial class StockMovementView : UserControl
    {
        private List<StockMovement> allMovements = new List<StockMovement>();
        private List<StockMovement> currentFilteredMovements = new List<StockMovement>();

        public StockMovementView()
        {
            InitializeComponent();
            filterOption.SelectedIndex = 0;
            LoadMovements();

            if (SessionManager.RoleName == "Accountant")
            {
                shipBtn.Hide();
                receiveBtn.Hide();
                deleteBtn.Hide();
            }
        }

        private void LoadMovements()
        {
            StockMovementRepository repository = new StockMovementRepository();

            try
            {
                allMovements = repository.GetAll();
                gridMovements.AutoGenerateColumns = false;
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void receiveBtn_Click(object sender, EventArgs e)
        {
            StockMovementReceiveForm form = new StockMovementReceiveForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMovements();
            }
        }
        private void shipBtn_Click(object sender, EventArgs e)
        {
            StockMovementShipForm form = new StockMovementShipForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMovements();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (gridMovements.CurrentRow == null)
            {
                MessageBox.Show("Please, select a row to delete.");
                return;
            }

            StockMovement movement = (StockMovement)gridMovements.CurrentRow.DataBoundItem;
            DialogResult choice = MessageBox.Show("Are you sure you want to delete this record?",
                                                  "Delete record", MessageBoxButtons.YesNo);

            if (choice == DialogResult.Yes)
            {
                try
                {
                    StockMovementRepository repository = new StockMovementRepository();
                    repository.Delete(movement.MovementId, SessionManager.UserId);
                    LoadMovements();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
                    return;
                }
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadMovements();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (allMovements == null || allMovements.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files | *.csv";
                sfd.FileName = "stockMovements.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.WriteLine("Product,Supplier,MovementType,Quantity,MovementDate,Note");

                        foreach (DataGridViewRow row in gridMovements.Rows)
                        {
                            if (row.DataBoundItem is StockMovement movement)
                            {
                                string line = EscapeCsv(movement.ProductName) + "," +
                                              EscapeCsv(movement.SupplierName) + "," +
                                              movement.Type.ToString() + "," +
                                              movement.Quantity.ToString(CultureInfo.InvariantCulture) + "," +
                                              movement.MovementDate.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) + "," +
                                              EscapeCsv(movement.Note);
                                writer.WriteLine(line);
                            }
                        }
                    }

                    MessageBox.Show("Data saved successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed. \nError: {ex.Message}");
                }
            }
        }

        private string EscapeCsv(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }

            return value;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchBox.Text;

            List<StockMovement> searchedMovements = currentFilteredMovements.Where(m => m.ProductName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                            (m.SupplierName != null && m.SupplierName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) || 
                                                                            m.MovementDate.ToString().IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                            m.Quantity.ToString().IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                            (m.Note != null && m.Note.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
            gridMovements.DataSource = searchedMovements;
        }

        private void ApplyFilter()
        {
            List<StockMovement> filteredMovements = new List<StockMovement>();
            gridMovements.BackgroundColor = Color.White;

            if (filterOption.SelectedIndex == 0)
            {
                filteredMovements = allMovements.Where(m => m.IsActive).ToList();
            }
            else if (filterOption.SelectedIndex == 1)
            {
                filteredMovements = allMovements.Where(m => m.IsActive && m.Type == MovementType.IN).ToList();
            }
            else if (filterOption.SelectedIndex == 2) 
            {
                filteredMovements = allMovements.Where(m => m.IsActive && m.Type == MovementType.OUT).ToList();
            } else
            {
                gridMovements.BackgroundColor = Color.LightGray;
                filteredMovements = allMovements.Where(m => !m.IsActive).ToList();
            }

            currentFilteredMovements = filteredMovements;

            gridMovements.AutoGenerateColumns = false;
            gridMovements.DataSource = filteredMovements;
        }

        private void filterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
