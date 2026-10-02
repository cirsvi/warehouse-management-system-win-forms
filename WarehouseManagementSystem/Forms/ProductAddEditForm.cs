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

            CategoryRepository repository = new CategoryRepository();
            List<Category> categories = repository.GetAll();

            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "CategoryID";
            categoryComboBox.DataSource = categories;
        }

        public ProductAddEditForm(int productId)
        {
            InitializeComponent();

            productWindowTitle.Text = "Update product";

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
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(productNameInput.TextLength == 0 || categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Product name cannot be empty and category has to be chosen.");
                return;
            }

            Product product = new Product(productNameInput.Text, (int)categoryComboBox.SelectedValue);
            ProductRepository repository = new ProductRepository();

            if (productId == 0)
            {
                repository.Insert(product);
            }
            else
            {
                repository.Update(productId, product);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
