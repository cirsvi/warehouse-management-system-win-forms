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
    public partial class SupplierAddEditForm : Form
    {
        private int supplierId = 0;

        public SupplierAddEditForm()
        {
            InitializeComponent();
            supWindowTitle.Text = "New supplier";
        }

        public SupplierAddEditForm(int supplierId)
        {
            InitializeComponent();
            supWindowTitle.Text = "Update supplier";

            try
            {
                this.supplierId = supplierId;

                SupplierRepository repository = new SupplierRepository();
                Supplier supplier = repository.GetById(supplierId);

                supplierNameInput.Text = supplier.SupplierName;
                contPerInput.Text = supplier.ContactPerson;
                phoneInput.Text = supplier.Phone;
                emailInput.Text = supplier.Email;
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(supplierNameInput.TextLength == 0 || contPerInput.TextLength == 0)
            {
                MessageBox.Show("Supplier name and contact person cannot be empty.");
                return;
            }

            try
            {
                SupplierRepository repository = new SupplierRepository();

                if (repository.IsNameTaken(supplierNameInput.Text, supplierId))
                {
                    MessageBox.Show("Supplier with this name already exists.");
                    return;
                }

                Supplier supplier = new Supplier(supplierNameInput.Text, contPerInput.Text, phoneInput.Text, emailInput.Text);

                if (supplierId == 0)
                {
                    int inactiveId = repository.FindInactiveByName(supplierNameInput.Text);
                    if (inactiveId > 0)
                    {
                        DialogResult choice = MessageBox.Show("A supplier with this name was previously deleted. Restore it?",
                                                              "Restore supplier", MessageBoxButtons.YesNo);

                        if (choice == DialogResult.Yes)
                        {
                            repository.Reactivate(inactiveId, SessionManager.UserId);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                    repository.Insert(supplier, SessionManager.UserId);
                }
                else
                {
                    repository.Update(supplierId, supplier, SessionManager.UserId);
                }
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }
    }
}
