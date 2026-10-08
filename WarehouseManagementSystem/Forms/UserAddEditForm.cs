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
    public partial class UserAddEditForm : Form
    {
        private int userId = 0;


        public UserAddEditForm()
        {
            InitializeComponent();
            userWindowTitle.Text = "New user";

            try
            {
                PopulateRoles();
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        public UserAddEditForm(int userId)
        {
            InitializeComponent();
            userWindowTitle.Text = "Update user";

            passwordPan.Hide();
            passwordRepeatPan.Hide();

            try
            {
                PopulateRoles();

                this.userId = userId;
                UserRepository repository = new UserRepository();
                User user = repository.GetById(this.userId);

                usernameInput.Text = user.Username;
                roleComboBox.SelectedValue = user.RoleId;
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (usernameInput.TextLength == 0 || roleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Input fields cannot be empty and role has to be chosen.");
                return;
            }

            try
            {
                UserRepository repository = new UserRepository();

                if (repository.IsUsernameTaken(usernameInput.Text, userId))
                {
                    MessageBox.Show("User with this username already exists. Username should be unique.");
                    return;
                }

                if (userId == 0)
                {
                    if (passwordInput.TextLength == 0 || repPasswordInput.TextLength == 0)
                    {
                        MessageBox.Show("Input fields cannot be empty and role has to be chosen.");
                        return;
                    }

                    if (passwordInput.Text != repPasswordInput.Text)
                    {
                        MessageBox.Show("Passwords do not match, please try again.");
                        return;
                    }

                    int inactiveId = repository.FindInactiveByUsername(usernameInput.Text);
                    if (inactiveId > 0)
                    {
                        DialogResult choice = MessageBox.Show("A user with this username was previously deleted. Restore it?",
                                                           "Restore user", MessageBoxButtons.YesNo);

                        if (choice == DialogResult.Yes)
                        {
                            repository.Reactivate(inactiveId, SessionManager.UserId);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                    repository.Insert(new User(usernameInput.Text, passwordInput.Text, (int)roleComboBox.SelectedValue));
                }
                else
                {


                    repository.Update(new User(userId, usernameInput.Text, (int)roleComboBox.SelectedValue), SessionManager.UserId);
                }
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        public void PopulateRoles()
        {
            RolesRepository repository = new RolesRepository();
            List<Role> roles = repository.GetAll();

            roleComboBox.DisplayMember = "RoleName";
            roleComboBox.ValueMember = "RoleID";
            roleComboBox.DataSource = roles;
        }
    }
}
