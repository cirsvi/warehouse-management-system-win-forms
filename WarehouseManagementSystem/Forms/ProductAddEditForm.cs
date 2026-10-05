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

namespace WarehouseManagementSystem
{
    public partial class ProductAddEditForm : Form
    {
        private int productId = 0;


        public ProductAddEditForm()
        {
            InitializeComponent();

            productWindowTitle.Text = "New product";

            try
            {
                CategoryRepository repository = new CategoryRepository();
                List<Category> categories = repository.GetAll();

                categoryComboBox.DisplayMember = "CategoryName";
                categoryComboBox.ValueMember = "CategoryID";
                categoryComboBox.DataSource = categories;
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
            
        }

        public ProductAddEditForm(int productId)
        {
            InitializeComponent();

            productWindowTitle.Text = "Update product";

            try
            {
                CategoryRepository catRepository = new CategoryRepository();
                List<Category> categories = catRepository.GetAll();

                categoryComboBox.DisplayMember = "CategoryName";
                categoryComboBox.ValueMember = "CategoryID";
                categoryComboBox.DataSource = categories;

                this.productId = productId;

                ProductRepository prodRepository = new ProductRepository();
                Product product = prodRepository.GetById(productId);

                productNameInput.Text = product.ProductName;
                categoryComboBox.SelectedValue = product.ProductCategoryId;
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(productNameInput.TextLength == 0 || categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Product name cannot be empty and category has to be chosen.");
                return;
            }

            try
            {
                ProductRepository repository = new ProductRepository();

                if (repository.IsNameTaken(productNameInput.Text, productId))
                {
                    MessageBox.Show("Product with this name already exists.");
                    return;
                }

                Product product = new Product(productNameInput.Text, (int)categoryComboBox.SelectedValue);

                if (productId == 0)
                {
                    int inactiveId = repository.FindInactiveByName(productNameInput.Text);
                    if (inactiveId > 0)
                    {
                        DialogResult choice = MessageBox.Show("A product with this name was previously deleted. Restore it?",
                                                           "Restore product", MessageBoxButtons.YesNo);

                        if (choice == DialogResult.Yes)
                        {
                            repository.Reactivate(inactiveId);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                    repository.Insert(product);
                }
                else
                {
                    repository.Update(productId, product);
                }
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }
    }
}
