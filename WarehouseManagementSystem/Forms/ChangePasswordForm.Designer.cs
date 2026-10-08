namespace WarehouseManagementSystem
{
    partial class ChangePasswordForm
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
            this.currentPasInput = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.buttonsPan = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.passwordPan = new System.Windows.Forms.Panel();
            this.newPasInput = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordRepeatPan = new System.Windows.Forms.Panel();
            this.repPasInput = new System.Windows.Forms.TextBox();
            this.repPasswordLbl = new System.Windows.Forms.Label();
            this.titltePan.SuspendLayout();
            this.usernamePan.SuspendLayout();
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
            this.userWindowTitle.Size = new System.Drawing.Size(201, 31);
            this.userWindowTitle.TabIndex = 0;
            this.userWindowTitle.Text = "Change password";
            // 
            // usernamePan
            // 
            this.usernamePan.Controls.Add(this.currentPasInput);
            this.usernamePan.Controls.Add(this.usernameLbl);
            this.usernamePan.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernamePan.Location = new System.Drawing.Point(0, 60);
            this.usernamePan.Name = "usernamePan";
            this.usernamePan.Size = new System.Drawing.Size(582, 80);
            this.usernamePan.TabIndex = 1;
            // 
            // currentPasInput
            // 
            this.currentPasInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPasInput.Location = new System.Drawing.Point(18, 39);
            this.currentPasInput.MaxLength = 100;
            this.currentPasInput.Name = "currentPasInput";
            this.currentPasInput.PasswordChar = '*';
            this.currentPasInput.Size = new System.Drawing.Size(539, 30);
            this.currentPasInput.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(14, 13);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(148, 23);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Current password:";
            // 
            // buttonsPan
            // 
            this.buttonsPan.Controls.Add(this.saveBtn);
            this.buttonsPan.Controls.Add(this.cancelBtn);
            this.buttonsPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPan.Location = new System.Drawing.Point(0, 300);
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
            this.passwordPan.Controls.Add(this.newPasInput);
            this.passwordPan.Controls.Add(this.passwordLbl);
            this.passwordPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordPan.Location = new System.Drawing.Point(0, 140);
            this.passwordPan.Name = "passwordPan";
            this.passwordPan.Size = new System.Drawing.Size(582, 80);
            this.passwordPan.TabIndex = 4;
            // 
            // newPasInput
            // 
            this.newPasInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasInput.Location = new System.Drawing.Point(18, 39);
            this.newPasInput.MaxLength = 100;
            this.newPasInput.Name = "newPasInput";
            this.newPasInput.PasswordChar = '*';
            this.newPasInput.Size = new System.Drawing.Size(539, 30);
            this.newPasInput.TabIndex = 1;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(14, 13);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(124, 23);
            this.passwordLbl.TabIndex = 0;
            this.passwordLbl.Text = "New password:";
            // 
            // passwordRepeatPan
            // 
            this.passwordRepeatPan.Controls.Add(this.repPasInput);
            this.passwordRepeatPan.Controls.Add(this.repPasswordLbl);
            this.passwordRepeatPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordRepeatPan.Location = new System.Drawing.Point(0, 220);
            this.passwordRepeatPan.Name = "passwordRepeatPan";
            this.passwordRepeatPan.Size = new System.Drawing.Size(582, 80);
            this.passwordRepeatPan.TabIndex = 5;
            // 
            // repPasInput
            // 
            this.repPasInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repPasInput.Location = new System.Drawing.Point(18, 39);
            this.repPasInput.MaxLength = 100;
            this.repPasInput.Name = "repPasInput";
            this.repPasInput.PasswordChar = '*';
            this.repPasInput.Size = new System.Drawing.Size(539, 30);
            this.repPasInput.TabIndex = 1;
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
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 382);
            this.Controls.Add(this.buttonsPan);
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
            this.Name = "ChangePasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User";
            this.titltePan.ResumeLayout(false);
            this.titltePan.PerformLayout();
            this.usernamePan.ResumeLayout(false);
            this.usernamePan.PerformLayout();
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
        private System.Windows.Forms.TextBox currentPasInput;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Panel buttonsPan;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel passwordPan;
        private System.Windows.Forms.TextBox newPasInput;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Panel passwordRepeatPan;
        private System.Windows.Forms.TextBox repPasInput;
        private System.Windows.Forms.Label repPasswordLbl;
    }
}