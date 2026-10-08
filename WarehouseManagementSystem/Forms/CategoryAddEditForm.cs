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
    public partial class CategoryAddEditForm : Form
    {
        private int categoryId = 0;

        public CategoryAddEditForm()
        {
            InitializeComponent();
            productWindowTitle.Text = "New category";
        }

        public CategoryAddEditForm(int categoryId)
        {
            InitializeComponent();
            productWindowTitle.Text = "Update category";

            try
            {
                this.categoryId = categoryId;

                CategoryRepository repository = new CategoryRepository();
                Category category = repository.GetById(categoryId);

                categoryNameInput.Text = category.CategoryName;
            } catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(categoryNameInput.TextLength == 0)
            {
                MessageBox.Show("Input field cannot be empty.");
                return;
            }

            try
            {
                CategoryRepository repository = new CategoryRepository();

                if (repository.IsNameTaken(categoryNameInput.Text, categoryId))
                {
                    MessageBox.Show("Category with this name already exists.");
                    return;
                }

                Category category = new Category(categoryNameInput.Text);

                if (categoryId == 0)
                {
                    int inactiveId = repository.FindInactiveByName(categoryNameInput.Text);
                    if (inactiveId > 0)
                    {
                        DialogResult choice = MessageBox.Show("A category with this name was previously deleted. Restore it?",
                                                              "Restore product", MessageBoxButtons.YesNo);

                        if (choice == DialogResult.Yes)
                        {
                            repository.Reactivate(inactiveId, SessionManager.UserId);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                    }
                    repository.Insert(category, SessionManager.UserId);
                }
                else
                {
                    repository.Update(categoryId, category, SessionManager.UserId);
                }
                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }
    }
}
