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

namespace WarehouseManagementSystem
{
    public partial class ProductsView : UserControl
    {
        private List<Product> products = new List<Product>();

        public ProductsView()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductRepository repository = new ProductRepository();

            try
            {
                products = repository.GetAll();
                gridProducts.AutoGenerateColumns = false;
                gridProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ProductAddEditForm productAddEditForm = new ProductAddEditForm();
            if (productAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (gridProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            Product selected = (Product)gridProducts.CurrentRow.DataBoundItem;

            ProductAddEditForm productAddEditForm = new ProductAddEditForm(selected.ProductId);
            if (productAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (gridProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Product selected = (Product)gridProducts.CurrentRow.DataBoundItem;
            DialogResult choice = MessageBox.Show($"Are you sure you want to delete '{selected.ProductName}'?",
                                                   "Delete product", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    ProductRepository repository = new ProductRepository();
                    repository.DeleteById(selected.ProductId);
                    LoadProducts();
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
            LoadProducts();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if(products == null || products.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files | *.csv";
                sfd.FileName = "products.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.WriteLine("ProductName,Category,CurrentStock");

                        foreach (DataGridViewRow row in gridProducts.Rows)
                        {
                            if(row.DataBoundItem is Product product)
                            {
                                string line = EscapeCsv(product.ProductName) + "," +
                                              EscapeCsv(product.ProductCategoryName) + "," +
                                              product.CurrentStock.ToString(CultureInfo.InvariantCulture);
                                writer.WriteLine(line);
                            }
                        }
                    }

                    MessageBox.Show("Data saved succesfully.");

                } catch (Exception ex)
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

            List<Product> searchedProducts = products.Where(p => p.ProductName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 || 
                                                            p.ProductCategoryName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            gridProducts.DataSource = searchedProducts;
        }
    }
}
