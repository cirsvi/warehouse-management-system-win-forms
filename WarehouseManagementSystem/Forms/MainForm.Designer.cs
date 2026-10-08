namespace WarehouseManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.accountTollStrip = new System.Windows.Forms.ToolStrip();
            this.userMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.usersBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.btnDivider = new System.Windows.Forms.Panel();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.btnDivider2 = new System.Windows.Forms.Panel();
            this.productsBtn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.titlePanel.SuspendLayout();
            this.accountTollStrip.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.titlePanel.Controls.Add(this.accountTollStrip);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1332, 96);
            this.titlePanel.TabIndex = 0;
            // 
            // accountTollStrip
            // 
            this.accountTollStrip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.accountTollStrip.CanOverflow = false;
            this.accountTollStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.accountTollStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.accountTollStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.accountTollStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuButton});
            this.accountTollStrip.Location = new System.Drawing.Point(1191, 9);
            this.accountTollStrip.Name = "accountTollStrip";
            this.accountTollStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.accountTollStrip.Size = new System.Drawing.Size(132, 55);
            this.accountTollStrip.TabIndex = 0;
            this.accountTollStrip.Text = "toolStrip1";
            // 
            // userMenuButton
            // 
            this.userMenuButton.BackColor = System.Drawing.SystemColors.Control;
            this.userMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userMenuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("userMenuButton.Image")));
            this.userMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userMenuButton.Name = "userMenuButton";
            this.userMenuButton.Size = new System.Drawing.Size(129, 52);
            this.userMenuButton.Text = "admin";
            this.userMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(256, 32);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(256, 32);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.navigationPanel.Controls.Add(this.usersBtn);
            this.navigationPanel.Controls.Add(this.panel1);
            this.navigationPanel.Controls.Add(this.suppliersBtn);
            this.navigationPanel.Controls.Add(this.btnDivider);
            this.navigationPanel.Controls.Add(this.categoriesBtn);
            this.navigationPanel.Controls.Add(this.btnDivider2);
            this.navigationPanel.Controls.Add(this.productsBtn);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 96);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(225, 762);
            this.navigationPanel.TabIndex = 1;
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.usersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.usersBtn.Location = new System.Drawing.Point(0, 146);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(225, 45);
            this.usersBtn.TabIndex = 6;
            this.usersBtn.Text = "Users";
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 1);
            this.panel1.TabIndex = 5;
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.suppliersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.suppliersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.suppliersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.suppliersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.suppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.suppliersBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.suppliersBtn.Location = new System.Drawing.Point(0, 96);
            this.suppliersBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(225, 49);
            this.suppliersBtn.TabIndex = 2;
            this.suppliersBtn.Text = "Suppliers";
            this.suppliersBtn.UseVisualStyleBackColor = false;
            // 
            // btnDivider
            // 
            this.btnDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDivider.Location = new System.Drawing.Point(0, 95);
            this.btnDivider.Name = "btnDivider";
            this.btnDivider.Size = new System.Drawing.Size(225, 1);
            this.btnDivider.TabIndex = 3;
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.categoriesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.categoriesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.categoriesBtn.Location = new System.Drawing.Point(0, 46);
            this.categoriesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(225, 49);
            this.categoriesBtn.TabIndex = 1;
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.UseVisualStyleBackColor = false;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // btnDivider2
            // 
            this.btnDivider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDivider2.Location = new System.Drawing.Point(0, 45);
            this.btnDivider2.Name = "btnDivider2";
            this.btnDivider2.Size = new System.Drawing.Size(225, 1);
            this.btnDivider2.TabIndex = 4;
            // 
            // productsBtn
            // 
            this.productsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.productsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.productsBtn.Location = new System.Drawing.Point(0, 0);
            this.productsBtn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(225, 45);
            this.productsBtn.TabIndex = 0;
            this.productsBtn.Text = "Products";
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(225, 96);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1107, 762);
            this.contentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 858);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.accountTollStrip.ResumeLayout(false);
            this.accountTollStrip.PerformLayout();
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Panel btnDivider;
        private System.Windows.Forms.Panel btnDivider2;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip accountTollStrip;
        private System.Windows.Forms.ToolStripDropDownButton userMenuButton;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}