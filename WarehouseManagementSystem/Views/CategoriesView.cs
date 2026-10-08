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
    public partial class CategoriesView : UserControl
    {
        private List<Category> categories = new List<Category>();

        public CategoriesView()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            CategoryRepository repository = new CategoryRepository();

            try
            {
                categories = repository.GetAll();
                gridCategories.AutoGenerateColumns = false;
                gridCategories.DataSource = categories;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CategoryAddEditForm categoryAddEditForm = new CategoryAddEditForm();
            if (categoryAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (gridCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category to edit.");
                return;
            }

            Category selected = (Category)gridCategories.CurrentRow.DataBoundItem;

            CategoryAddEditForm categoryAddEditForm = new CategoryAddEditForm(selected.CategoryID);
            if (categoryAddEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (gridCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            Category selected = (Category)gridCategories.CurrentRow.DataBoundItem;
            DialogResult choice = MessageBox.Show($"Are you sure you want to delete '{selected.CategoryName}'?",
                                                   "Delete category", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                try
                {
                    CategoryRepository repository = new CategoryRepository();
                    repository.DeleteById(selected.CategoryID, SessionManager.UserId);
                    LoadCategories();
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
            LoadCategories();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (categories == null || categories.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV Files | *.csv";
                sfd.FileName = "categories.csv";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.WriteLine("CategoryName,ProductCount");

                        foreach (DataGridViewRow row in gridCategories.Rows)
                        {
                            if (row.DataBoundItem is Category category)
                            {
                                string line = EscapeCsv(category.CategoryName) + "," +
                                              category.ProductCount.ToString(CultureInfo.InvariantCulture);
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

            List<Category> searchedCategories = categories.Where(u => u.CategoryName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            gridCategories.DataSource = searchedCategories;
        }
    }
}
