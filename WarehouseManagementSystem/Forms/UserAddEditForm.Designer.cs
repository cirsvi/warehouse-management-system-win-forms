namespace WarehouseManagementSystem
{
    partial class UserAddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titltePan = new System.Windows.Forms.Panel();
            this.userWindowTitle = new System.Windows.Forms.Label();
            this.usernamePan = new System.Windows.Forms.Panel();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.rolePan = new System.Windows.Forms.Panel();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLbl = new System.Windows.Forms.Label();
            this.buttonsPan = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.passwordPan = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordRepeatPan = new System.Windows.Forms.Panel();
            this.repPasswordInput = new System.Windows.Forms.TextBox();
            this.repPasswordLbl = new System.Windows.Forms.Label();
            this.titltePan.SuspendLayout();
            this.usernamePan.SuspendLayout();
            this.rolePan.SuspendLayout();
            this.buttonsPan.SuspendLayout();
            this.passwordPan.SuspendLayout();
            this.passwordRepeatPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // titltePan
            // 
            this.titltePan.Controls.Add(this.userWindowTitle);
            this.titltePan.Dock = System.Windows.Forms.DockStyle.Top;
            this.titltePan.Location = new System.Drawing.Point(0, 0);
            this.titltePan.Name = "titltePan";
            this.titltePan.Size = new System.Drawing.Size(582, 60);
            this.titltePan.TabIndex = 0;
            // 
            // userWindowTitle
            // 
            this.userWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userWindowTitle.AutoSize = true;
            this.userWindowTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWindowTitle.Location = new System.Drawing.Point(12, 13);
            this.userWindowTitle.Name = "userWindowTitle";
            this.userWindowTitle.Size = new System.Drawing.Size(62, 31);
            this.userWindowTitle.TabIndex = 0;
            this.userWindowTitle.Text = "User";
            // 
            // usernamePan
            // 
            this.usernamePan.Controls.Add(this.usernameInput);
            this.usernamePan.Controls.Add(this.usernameLbl);
            this.usernamePan.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernamePan.Location = new System.Drawing.Point(0, 60);
            this.usernamePan.Name = "usernamePan";
            this.usernamePan.Size = new System.Drawing.Size(582, 80);
            this.usernamePan.TabIndex = 1;
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.Location = new System.Drawing.Point(18, 39);
            this.usernameInput.MaxLength = 100;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(539, 30);
            this.usernameInput.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(14, 13);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(91, 23);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username:";
            // 
            // rolePan
            // 
            this.rolePan.Controls.Add(this.roleComboBox);
            this.rolePan.Controls.Add(this.roleLbl);
            this.rolePan.Dock = System.Windows.Forms.DockStyle.Top;
            this.rolePan.Location = new System.Drawing.Point(0, 300);
            this.rolePan.Name = "rolePan";
            this.rolePan.Size = new System.Drawing.Size(582, 80);
            this.rolePan.TabIndex = 2;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(18, 39);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(539, 31);
            this.roleComboBox.TabIndex = 2;
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(14, 11);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(47, 23);
            this.roleLbl.TabIndex = 1;
            this.roleLbl.Text = "Role:";
            // 
            // buttonsPan
            // 
            this.buttonsPan.Controls.Add(this.saveBtn);
            this.buttonsPan.Controls.Add(this.cancelBtn);
            this.buttonsPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPan.Location = new System.Drawing.Point(0, 380);
            this.buttonsPan.Name = "buttonsPan";
            this.buttonsPan.Size = new System.Drawing.Size(582, 80);
            this.buttonsPan.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(495, 27);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 35);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelBtn.BackColor = System.Drawing.Color.DarkGray;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(414, 27);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 35);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // passwordPan
            // 
            this.passwordPan.Controls.Add(this.passwordInput);
            this.passwordPan.Controls.Add(this.passwordLbl);
            this.passwordPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordPan.Location = new System.Drawing.Point(0, 140);
            this.passwordPan.Name = "passwordPan";
            this.passwordPan.Size = new System.Drawing.Size(582, 80);
            this.passwordPan.TabIndex = 4;
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Location = new System.Drawing.Point(18, 39);
            this.passwordInput.MaxLength = 100;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(539, 30);
            this.passwordInput.TabIndex = 1;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(14, 13);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(84, 23);
            this.passwordLbl.TabIndex = 0;
            this.passwordLbl.Text = "Password:";
            // 
            // passwordRepeatPan
            // 
            this.passwordRepeatPan.Controls.Add(this.repPasswordInput);
            this.passwordRepeatPan.Controls.Add(this.repPasswordLbl);
            this.passwordRepeatPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordRepeatPan.Location = new System.Drawing.Point(0, 220);
            this.passwordRepeatPan.Name = "passwordRepeatPan";
            this.passwordRepeatPan.Size = new System.Drawing.Size(582, 80);
            this.passwordRepeatPan.TabIndex = 5;
            // 
            // repPasswordInput
            // 
            this.repPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repPasswordInput.Location = new System.Drawing.Point(18, 39);
            this.repPasswordInput.MaxLength = 100;
            this.repPasswordInput.Name = "repPasswordInput";
            this.repPasswordInput.PasswordChar = '*';
            this.repPasswordInput.Size = new System.Drawing.Size(539, 30);
            this.repPasswordInput.TabIndex = 1;
            // 
            // repPasswordLbl
            // 
            this.repPasswordLbl.AutoSize = true;
            this.repPasswordLbl.Location = new System.Drawing.Point(14, 13);
            this.repPasswordLbl.Name = "repPasswordLbl";
            this.repPasswordLbl.Size = new System.Drawing.Size(142, 23);
            this.repPasswordLbl.TabIndex = 0;
            this.repPasswordLbl.Text = "Repeat Password:";
            // 
            // UserAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 457);
            this.Controls.Add(this.buttonsPan);
            this.Controls.Add(this.rolePan);
            this.Controls.Add(this.passwordRepeatPan);
            this.Controls.Add(this.passwordPan);
            this.Controls.Add(this.usernamePan);
            this.Controls.Add(this.titltePan);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "UserAddEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User";
            this.titltePan.ResumeLayout(false);
            this.titltePan.PerformLayout();
            this.usernamePan.ResumeLayout(false);
            this.usernamePan.PerformLayout();
            this.rolePan.ResumeLayout(false);
            this.rolePan.PerformLayout();
            this.buttonsPan.ResumeLayout(false);
            this.passwordPan.ResumeLayout(false);
            this.passwordPan.PerformLayout();
            this.passwordRepeatPan.ResumeLayout(false);
            this.passwordRepeatPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titltePan;
        private System.Windows.Forms.Label userWindowTitle;
        private System.Windows.Forms.Panel usernamePan;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Panel rolePan;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Panel buttonsPan;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel passwordPan;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Panel passwordRepeatPan;
        private System.Windows.Forms.TextBox repPasswordInput;
        private System.Windows.Forms.Label repPasswordLbl;
    }
}