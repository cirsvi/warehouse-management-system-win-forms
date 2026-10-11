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
    public partial class SuppliersView : UserControl
    {
        private List<Supplier> suppliers = new List<Supplier>();

        public SuppliersView()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            SupplierRepository repository = new SupplierRepository();

            try
            {
                suppliers = repository.GetAll();
                gridSuppliers.AutoGenerateColumns = false;
                gridSuppliers.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            SupplierAddEditForm supplierAddEditForm = new SupplierAddEditForm();
            if (supplierAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (gridSuppliers.CurrentRow == null)
            {
                MessageBox.Show("Please select a supplier to edit.");
                return;
            }

            Supplier selected = (Supplier)gridSuppliers.CurrentRow.DataBoundItem;

            SupplierAddEditForm supplierAddEditForm = new SupplierAddEditForm(selected.SupplierId);
            if (supplierAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadSuppliers();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (gridSuppliers.CurrentRow == null)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            Supplier selected = (Supplier)gridSuppliers.CurrentRow.DataBoundItem;
            DialogResult choice = MessageBox.Show($"Are you sure you want to delete '{selected.SupplierName}'?",
                                                   "Delete supplier", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    SupplierRepository repository = new SupplierRepository();
                    repository.DeleteById(selected.SupplierId, SessionManager.UserId);
                    LoadSuppliers();
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
            LoadSuppliers();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (suppliers == null || suppliers.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files | *.csv";
                sfd.FileName = "suppliers.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.WriteLine("SupplierName,ContactPerson,Phone,Email");

                        foreach (DataGridViewRow row in gridSuppliers.Rows)
                        {
                            if (row.DataBoundItem is Supplier supplier)
                            {
                                string line = EscapeCsv(supplier.SupplierName) + "," +
                                              EscapeCsv(supplier.ContactPerson) + "," +
                                              EscapeCsv(supplier.Phone) + "," +
                                              EscapeCsv(supplier.Email);
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

            List<Supplier> searchedSuppliers = suppliers.Where(s => s.SupplierName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    s.ContactPerson.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    s.Email.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    s.Phone.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            gridSuppliers.DataSource = searchedSuppliers;
        }

        private void gridProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSuppliers.CurrentRow == null)
            {
                supNameLbl.Text = "Please, select a supplier.";
                contPersVarLbl.Text = "-";
                phoneVarLbl.Text = "-";
                emailVarLbl.Text = "-";
                prodSupGrid.DataSource = null;

                addProdBtn.Enabled = false;
                remProdBtn.Enabled = false;

                return;
            }

            Supplier selected = (Supplier)gridSuppliers.CurrentRow.DataBoundItem;

            supNameLbl.Text = selected.SupplierName;
            contPersVarLbl.Text = selected.ContactPerson;
            phoneVarLbl.Text = (selected.Phone.Length == 0) ? "-" : selected.Phone;
            emailVarLbl.Text = (selected.Email.Length == 0) ? "-" : selected.Email;

            addProdBtn.Enabled = true;
            remProdBtn.Enabled = true;

            PopulateProduct(selected.SupplierId);
        }

        private void PopulateProduct(int supplierId)
        {
            SupplierProductRepository repository = new SupplierProductRepository();
            List<ProductForSupplier> products = new List<ProductForSupplier>();

            try
            {
                products = repository.GetProductsBySupplierId(supplierId);    
                prodSupGrid.AutoGenerateColumns = false;
                prodSupGrid.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            Supplier selected = (Supplier)gridSuppliers.CurrentRow.DataBoundItem;
            ProductForSupplierAddEditForm form = new ProductForSupplierAddEditForm(selected.SupplierId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                PopulateProduct(selected.SupplierId);
            }
        }

        private void editProdBtn_Click(object sender, EventArgs e)
        {
            if (prodSupGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            Supplier selectedSup = (Supplier)gridSuppliers.CurrentRow.DataBoundItem;
            ProductForSupplier selectedProd = (ProductForSupplier)prodSupGrid.CurrentRow.DataBoundItem;
            ProductForSupplierAddEditForm form = new ProductForSupplierAddEditForm(selectedSup.SupplierId, selectedProd.ProductId, 
                                                                                    selectedProd.ProductName, selectedProd.PricePerUnit);

            if (form.ShowDialog() == DialogResult.OK)
            {
                PopulateProduct(selectedSup.SupplierId);
            }
        }

        private void remProdBtn_Click(object sender, EventArgs e)
        {
            if (prodSupGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Supplier selectedSup = (Supplier)gridSuppliers.CurrentRow.DataBoundItem;
            ProductForSupplier selectedProd = (ProductForSupplier)prodSupGrid.CurrentRow.DataBoundItem;
            DialogResult choice = MessageBox.Show($"Are you sure you want to delete '{selectedProd.ProductName}'?",
                                                    "Delete product", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    SupplierProductRepository repository = new SupplierProductRepository();
                    repository.Delete(selectedProd.ProductId, selectedSup.SupplierId);
                    PopulateProduct(selectedSup.SupplierId);
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
