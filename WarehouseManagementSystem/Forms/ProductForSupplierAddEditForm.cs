using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Session;

namespace WarehouseManagementSystem
{
    public partial class ProductForSupplierAddEditForm : Form
    {
        private int productId = 0;
        private int supplierId = 0;

        private void PopulateSuppliers()
        {
            try
            {
                ProductRepository repository = new ProductRepository();
                List<Product> allProducts = repository.GetAll();

                SupplierProductRepository supProdRepository = new SupplierProductRepository();
                List<ProductForSupplier> prodSuppliers = supProdRepository.GetProductsBySupplierId(supplierId);

                List<int> linkedIds = prodSuppliers.Select(sp => sp.ProductId).ToList();
                List<Product> products = allProducts.Where(p => !linkedIds.Contains(p.ProductId)).ToList();

                if (products.Count == 0)
                {
                    MessageBox.Show("All available products are already linked to this supplier.");
                    saveBtn.Enabled = false;
                    return;
                }

                productsComboBox.DisplayMember = "ProductName";
                productsComboBox.ValueMember = "ProductId";
                productsComboBox.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        public ProductForSupplierAddEditForm(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
            prodSupWindowTitle.Text = "Add new product";
            prodVarLbl.Hide();
            PopulateSuppliers();
        }

        public ProductForSupplierAddEditForm(int supplierId, int productId,
                                             string prodName, decimal price)
        {
            InitializeComponent();
            prodSupWindowTitle.Text = "Update product";

            this.productId = productId;
            this.supplierId = supplierId;

            try
            {
                prodVarLbl.Text = prodName;
                productsComboBox.Hide();
                priceInput.Value = price;
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierProductRepository repository = new SupplierProductRepository();

                if (productId == 0)
                {
                    if (productsComboBox.SelectedIndex == -1 || priceInput.Value <= 0)
                    {
                        MessageBox.Show("Price has to be greater than 0 and product option has to be chosen.");
                        return;
                    }
                    repository.Add((int)productsComboBox.SelectedValue, supplierId, priceInput.Value, SessionManager.UserId);
                }
                else
                {
                    if (priceInput.Value <= 0)
                    {
                        MessageBox.Show("Price has to be greater than 0");
                        return;
                    }

                    repository.Update(productId, supplierId, priceInput.Value, SessionManager.UserId);
                }
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }
    }
}
