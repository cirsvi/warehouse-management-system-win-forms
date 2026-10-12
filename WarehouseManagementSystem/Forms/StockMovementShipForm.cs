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
    public partial class StockMovementShipForm : Form
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

        public StockMovementShipForm()
        {
            InitializeComponent();
            PopulateProducts();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(productComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please, choose product.");
                return;
            }

            if (quantityInput.Value <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.");
                return;
            }

            Product selected = (Product)productComboBox.SelectedItem;            

            if(selected.CurrentStock < quantityInput.Value)
            {
                MessageBox.Show($"Input quantity is greater than current stock of a product. Current stock is: {selected.CurrentStock}");
                return;
            }

            try
            {
                StockMovementRepository repository = new StockMovementRepository();
                StockMovement movementOut = new StockMovement((int)productComboBox.SelectedValue, (int)quantityInput.Value, 
                                                             MovementType.OUT, datePicker.Value, notesInput.Text);
                repository.ShipStock(movementOut, SessionManager.UserId);
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selected = (Product)productComboBox.SelectedItem;
            curStockVarLbl.Text = $"(Current quantity: {selected.CurrentStock})";
        }
    }
}
