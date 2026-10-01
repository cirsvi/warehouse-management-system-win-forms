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
        public ProductAddEditForm()
        {
            InitializeComponent();

            CategoryRepository repository = new CategoryRepository();
            List<Category> categories = repository.GetAll();

            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "CategoryID";
            categoryComboBox.DataSource = categories;
        }

    }
}
