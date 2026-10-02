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
    public partial class ProductsView : UserControl
    {
        public ProductsView()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductRepository repository = new ProductRepository();
            List<Product> products = repository.GetAll();

            gridProducts.AutoGenerateColumns = false;
            gridProducts.DataSource = products;
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
            Product selected = (Product)gridProducts.CurrentRow.DataBoundItem;

            ProductAddEditForm productAddEditForm = new ProductAddEditForm(selected.ProductId);
            if (productAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }
    }
}
