using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Session;

namespace WarehouseManagementSystem
{
    public partial class MainForm : Form
    {
        public bool logoutRequested = false;
        public MainForm()
        {
            InitializeComponent();

            if (SessionManager.RoleName != "Admin")
            {
                usersBtn.Hide();
            }

            userMenuButton.Text = SessionManager.Username;
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var view = new CategoriesView();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var view = new ProductsView();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var view = new UsersView();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logoutRequested = true;
            SessionManager.Clear();
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var view = new SuppliersView();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }

        private void stockMoveBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var view = new StockMovementView();
            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);
        }
    }
}
