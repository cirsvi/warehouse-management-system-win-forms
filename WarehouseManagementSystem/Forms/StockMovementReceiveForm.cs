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
    public partial class StockMovementReceiveForm : Form
    {
        private void PopulateProducts()
        {
            try
            {
                ProductRepository repository = new ProductRepository();
                List<Product> products = repository.GetAll();

                productComboBox.DisplayMember = "ProductName";
                productComboBox.ValueMember = "ProductId";
                productComboBox.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        public StockMovementReceiveForm()
        {
            InitializeComponent();
            PopulateProducts();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(productComboBox.SelectedIndex == -1 || supplierComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please, choose product and supplier.");
                return;
            }

            if (quantityInput.Value <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.");
                return;
            }

            try
            {
                StockMovementRepository repository = new StockMovementRepository();
                StockMovement movementIn = new StockMovement((int)productComboBox.SelectedValue, (int)supplierComboBox.SelectedValue, 
                                                             (int)quantityInput.Value, MovementType.IN,
                                                             datePicker.Value, notesInput.Text);
                repository.ReceiveStock(movementIn, SessionManager.UserId);
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupplierProductRepository repository = new SupplierProductRepository();
            List<SupplierForProduct> suppliers = repository.GetSuppliersByProductId((int)productComboBox.SelectedValue);

            if(suppliers.Count == 0)
            {
                supplierComboBox.DataSource = null;
                saveBtn.Enabled = false;
                MessageBox.Show("This product has no suppliers. Add one on the Products screen first.");
                return;
            }

            saveBtn.Enabled = true;
            supplierComboBox.DisplayMember = "SupplierName";
            supplierComboBox.ValueMember = "SupplierId";
            supplierComboBox.DataSource = suppliers;
        }
    }
}
