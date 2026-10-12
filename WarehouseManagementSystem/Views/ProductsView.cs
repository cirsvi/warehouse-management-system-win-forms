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
    public partial class ProductsView : UserControl
    {
        private List<Product> products = new List<Product>();

        public ProductsView()
        {
            InitializeComponent();
            LoadProducts();

            if (SessionManager.RoleName == "Accountant")
            {
                newBtn.Hide();
                editBtn.Hide();
                deleteBtn.Hide();

                addSupBtn.Hide();
                editSupBtn.Hide();
                remSupBtn.Hide();
            }
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

        private void gridProducts_SelectionChanged(object sender, EventArgs e)
        {
            if(gridProducts.CurrentRow == null)
            {
                prodNameLbl.Text = "Please, select a product.";
                curStockVarLbl.Text = "-";
                catNameVarLbl.Text = "-";

                addSupBtn.Enabled = false;
                editSupBtn.Enabled = false;
                remSupBtn.Enabled = false;

                return;
            }

            Product selected = (Product)gridProducts.CurrentRow.DataBoundItem;

            prodNameLbl.Text = selected.ProductName;
            curStockVarLbl.Text = selected.CurrentStock.ToString();
            catNameVarLbl.Text = selected.ProductCategoryName;

            PopulateSupplierGrid(selected.ProductId);

            addSupBtn.Enabled = true;
            editSupBtn.Enabled = true;
            remSupBtn.Enabled = true;

        }

        private void PopulateSupplierGrid(int productId)
        {
            SupplierProductRepository repository = new SupplierProductRepository();
            List<SupplierForProduct> suppliersByProdId = new List<SupplierForProduct>();

            try
            {
                suppliersByProdId = repository.GetSuppliersByProductId(productId);
                supplierProdGrid.AutoGenerateColumns = false;
                supplierProdGrid.DataSource = suppliersByProdId;

            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void addSupBtn_Click(object sender, EventArgs e)
        {
            Product selected = (Product)gridProducts.CurrentRow.DataBoundItem;
            SupplierForProductAddEditForm form = new SupplierForProductAddEditForm(selected.ProductId);
            
            if(form.ShowDialog() == DialogResult.OK)
            {
                PopulateSupplierGrid(selected.ProductId);
            }
        }

        private void editSupBtn_Click(object sender, EventArgs e)
        {
            if (supplierProdGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a supplier to edit.");
                return;
            }

            Product selectedProd = (Product)gridProducts.CurrentRow.DataBoundItem;
            SupplierForProduct selectedSupplier = (SupplierForProduct)supplierProdGrid.CurrentRow.DataBoundItem;
            SupplierForProductAddEditForm form = new SupplierForProductAddEditForm(selectedProd.ProductId, selectedSupplier.SupplierId, 
                                                                                   selectedSupplier.SupplierName, selectedSupplier.PricePerUnit);
            if (form.ShowDialog() == DialogResult.OK)
            {
                PopulateSupplierGrid(selectedProd.ProductId);
            }
        }

        private void remSupBtn_Click(object sender, EventArgs e)
        {
            if (supplierProdGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            Product selectedProd = (Product)gridProducts.CurrentRow.DataBoundItem;
            SupplierForProduct selectedSup = (SupplierForProduct)supplierProdGrid.CurrentRow.DataBoundItem;
            DialogResult choice = MessageBox.Show($"Are you sure you want to delete '{selectedSup.SupplierName}'?",
                                                   "Delete supplier", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    SupplierProductRepository repository = new SupplierProductRepository();
                    repository.Delete(selectedProd.ProductId, selectedSup.SupplierId);
                    PopulateSupplierGrid(selectedProd.ProductId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
                    return;
                }
            }
        }
    }
}
