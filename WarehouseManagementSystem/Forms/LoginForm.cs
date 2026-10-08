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

namespace WarehouseManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usernameInput.TextLength == 0 || passwordInput.TextLength == 0)
            {
                MessageBox.Show("Please, fill in both input fields.");
                return;
            }

            try
            {
                UserRepository repository = new UserRepository();
                User user = repository.GetByUsername(usernameInput.Text);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }

                if (passwordInput.Text != user.PasswordHash)
                {
                    MessageBox.Show("Invalid username or password.");
                    return;
                }

                SessionManager.UserId = user.UserId;
                SessionManager.Username = user.Username;
                SessionManager.RoleId = user.RoleId;
                SessionManager.RoleName = user.RoleName;

                this.DialogResult = DialogResult.OK;

            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }

        }
    }
}
