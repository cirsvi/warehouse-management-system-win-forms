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
using WarehouseManagementSystem.Helpers;
using WarehouseManagementSystem.Models;
using WarehouseManagementSystem.Session;

namespace WarehouseManagementSystem
{
    public partial class ChangePasswordForm : Form
    {
        private int userId = SessionManager.UserId;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (currentPasInput.TextLength == 0 || newPasInput.TextLength == 0 ||
                repPasInput.TextLength == 0)
            {
                MessageBox.Show("Input fields cannot be empty.");
                return;
            }

            if (newPasInput.Text != repPasInput.Text)
            {
                MessageBox.Show("New passwords do not match. Please, try again.");
                return;
            }

            try
            {
                UserRepository repository = new UserRepository();

                string currentPas = repository.GetPasswordById(userId);

                if (!PasswordHasher.Verify(currentPasInput.Text, currentPas))
                {
                    MessageBox.Show("Current password does not match.");
                    return;
                } 

                if(PasswordHasher.Verify(newPasInput.Text, currentPas))
                {
                    MessageBox.Show("New password can not be the same as the old.");
                    return;
                }
                string newHash = PasswordHasher.Hash(newPasInput.Text);
                repository.UpdatePassword(userId, newHash, SessionManager.UserId);

                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }
    }
}
