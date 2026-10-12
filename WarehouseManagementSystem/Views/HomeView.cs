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
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                ProductRepository prodRepository = new ProductRepository();
                List<Product> product = prodRepository.GetAll();

                prodCountVarLbl.Text = product.Count.ToString();

                List<Product> lowStockProducts = product.Where(p => p.CurrentStock <= 5).ToList();
                stockVarLbl.Text = lowStockProducts.Count.ToString();
                gridLowStock.AutoGenerateColumns = false;
                gridLowStock.DataSource = lowStockProducts;

                SupplierRepository supRepository = new SupplierRepository();
                List <Supplier> suppliers = supRepository.GetAll();
                supCountVarLbl.Text = suppliers.Count.ToString();

                StockMovementRepository movRepository = new StockMovementRepository();
                List<StockMovement> movements = movRepository.GetAll();
                List<StockMovement> recentMovs = movements.Take(15).ToList();
                gridRecentMovs.AutoGenerateColumns = false;
                gridRecentMovs.DataSource = recentMovs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }
    }
}
