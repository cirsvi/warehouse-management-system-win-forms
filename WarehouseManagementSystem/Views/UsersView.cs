using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Data;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Session;

namespace WarehouseManagementSystem
{
    public partial class UsersView : UserControl
    {
        private List<User> users = new List<User>();
        private List<Product> products = new List<Product>();

        public UsersView()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            UserRepository repository = new UserRepository();

            try
            {
                users = repository.GetAll();
                gridUsers.AutoGenerateColumns = false;
                gridUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            UserAddEditForm userAddEditForm = new UserAddEditForm();
            if (userAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (gridUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            User selected = (User)gridUsers.CurrentRow.DataBoundItem;

            UserAddEditForm userAddEditForm = new UserAddEditForm(selected.UserId);
            if (userAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (gridUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            User selected = (User)gridUsers.CurrentRow.DataBoundItem;

            if (selected.UserId == SessionManager.UserId)
            {
                MessageBox.Show("You cannot delete your own account");
                return;
            }

            DialogResult choice = MessageBox.Show($"Are you sure you want to delete '{selected.Username}'?",
                                                   "Delete user", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    UserRepository repository = new UserRepository();
                    repository.DeleteById(selected.UserId, SessionManager.UserId);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
                    return;
                }
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (users == null || users.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files | *.csv";
                sfd.FileName = "users.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.WriteLine("Username,RoleName");

                        foreach (DataGridViewRow row in gridUsers.Rows)
                        {
                            if (row.DataBoundItem is User user)
                            {
                                string line = EscapeCsv(user.Username) + "," +
                                              EscapeCsv(user.RoleName);
                                writer.WriteLine(line);
                            }
                        }
                    }

                    MessageBox.Show("Data saved succesfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Export failed. \nError: {ex.Message}");
                }
            }

        }

        private string EscapeCsv(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }

            return value;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchBox.Text;

            List<User> searchedUsers = users.Where(u => u.Username.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                            u.RoleName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            gridUsers.DataSource = searchedUsers;
        }
    }
}
