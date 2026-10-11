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
    public partial class SupplierForProductAddEditForm : Form
    {
        private int productId = 0;
        private int supplierId = 0;

        private void PopulateSuppliers()
        {
            try
            {
                SupplierRepository repository = new SupplierRepository();
                List<Supplier> allSuppliers = repository.GetAll();

                SupplierProductRepository supProdRepository = new SupplierProductRepository();
                List<SupplierForProduct> prodSuppliers = supProdRepository.GetSuppliersByProductId(productId);

                List<int> linkedIds = prodSuppliers.Select(sp => sp.SupplierId).ToList();
                List<Supplier> suppliers = allSuppliers.Where(s => !linkedIds.Contains(s.SupplierId)).ToList();

                if (suppliers.Count == 0)
                {
                    MessageBox.Show("All available suppliers are already linked to this product.");
                    saveBtn.Enabled = false;
                    return;
                }

                suppliersComboBox.DisplayMember = "SupplierName";
                suppliersComboBox.ValueMember = "SupplierID";
                suppliersComboBox.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        public SupplierForProductAddEditForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            supProdWindowTitle.Text = "Add new supplier";
            supVarLbl.Hide();
            PopulateSuppliers();
        }

        public SupplierForProductAddEditForm(int productId, int supplierId, 
                                             string supplierName, decimal price)
        {
            InitializeComponent();
            supProdWindowTitle.Text = "Update supplier";

            this.productId = productId;
            this.supplierId = supplierId;

            try
            {
                supVarLbl.Text = supplierName;
                suppliersComboBox.Hide();
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

                if (supplierId == 0)
                {
                    if (suppliersComboBox.SelectedIndex == -1 || priceInput.Value <= 0)
                    {
                        MessageBox.Show("Price has to be greater than 0 and supplier option has to be chosen.");
                        return;
                    }
                    repository.Add(productId, (int)suppliersComboBox.SelectedValue, priceInput.Value, SessionManager.UserId);
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
