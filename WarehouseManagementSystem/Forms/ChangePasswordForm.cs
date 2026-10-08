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

                if (currentPas != currentPasInput.Text)
                {
                    MessageBox.Show("Current password does not match.");
                    return;
                } 

                if(currentPas == newPasInput.Text)
                {
                    MessageBox.Show("New password can not be the same as the old.");
                    return;
                }
                repository.UpdatePassword(userId, newPasInput.Text, SessionManager.UserId);

                this.DialogResult = DialogResult.OK;
            } catch (Exception ex) 
            {
                MessageBox.Show($"Something went wrong. Try again!\nError: {ex.Message}");
            }
        }
    }
}
