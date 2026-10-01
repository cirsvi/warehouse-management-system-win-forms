using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {

        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var view = new ProductsView();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }
    }
}
