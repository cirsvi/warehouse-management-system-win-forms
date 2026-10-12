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
            this.homeBtn = new System.Windows.Forms.Button();
            this.stockMoveBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.accountTollStrip = new System.Windows.Forms.ToolStrip();
            this.userMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.titlePanel.SuspendLayout();
            this.accountTollStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.titlePanel.Controls.Add(this.homeBtn);
            this.titlePanel.Controls.Add(this.stockMoveBtn);
            this.titlePanel.Controls.Add(this.usersBtn);
            this.titlePanel.Controls.Add(this.accountTollStrip);
            this.titlePanel.Controls.Add(this.categoriesBtn);
            this.titlePanel.Controls.Add(this.suppliersBtn);
            this.titlePanel.Controls.Add(this.productsBtn);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1332, 96);
            this.titlePanel.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(149, 10);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(123, 55);
            this.homeBtn.TabIndex = 8;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // stockMoveBtn
            // 
            this.stockMoveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stockMoveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.stockMoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockMoveBtn.FlatAppearance.BorderSize = 0;
            this.stockMoveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.stockMoveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stockMoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockMoveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockMoveBtn.ForeColor = System.Drawing.Color.Black;
            this.stockMoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("stockMoveBtn.Image")));
            this.stockMoveBtn.Location = new System.Drawing.Point(786, 8);
            this.stockMoveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockMoveBtn.Name = "stockMoveBtn";
            this.stockMoveBtn.Size = new System.Drawing.Size(234, 55);
            this.stockMoveBtn.TabIndex = 7;
            this.stockMoveBtn.Text = "Stock Movement";
            this.stockMoveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockMoveBtn.UseVisualStyleBackColor = false;
            this.stockMoveBtn.Click += new System.EventHandler(this.stockMoveBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.SystemColors.Control;
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.usersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.ForeColor = System.Drawing.Color.Black;
            this.usersBtn.Image = ((System.Drawing.Image)(resources.GetObject("usersBtn.Image")));
            this.usersBtn.Location = new System.Drawing.Point(1025, 9);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(124, 55);
            this.usersBtn.TabIndex = 6;
            this.usersBtn.Text = "Users";
            this.usersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersBtn.UseVisualStyleBackColor = false;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // accountTollStrip
            // 
            this.accountTollStrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accountTollStrip.CanOverflow = false;
            this.accountTollStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.accountTollStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.accountTollStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.accountTollStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuButton});
            this.accountTollStrip.Location = new System.Drawing.Point(9, 9);
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
            // categoriesBtn
            // 
            this.categoriesBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoriesBtn.BackColor = System.Drawing.SystemColors.Control;
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.FlatAppearance.BorderSize = 0;
            this.categoriesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.categoriesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesBtn.ForeColor = System.Drawing.Color.Black;
            this.categoriesBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.Image")));
            this.categoriesBtn.Location = new System.Drawing.Point(615, 8);
            this.categoriesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(165, 55);
            this.categoriesBtn.TabIndex = 1;
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.categoriesBtn.UseVisualStyleBackColor = false;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.suppliersBtn.BackColor = System.Drawing.SystemColors.Control;
            this.suppliersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliersBtn.FlatAppearance.BorderSize = 0;
            this.suppliersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.suppliersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.suppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersBtn.ForeColor = System.Drawing.Color.Black;
            this.suppliersBtn.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBtn.Image")));
            this.suppliersBtn.Location = new System.Drawing.Point(444, 8);
            this.suppliersBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(165, 55);
            this.suppliersBtn.TabIndex = 2;
            this.suppliersBtn.Text = "Suppliers";
            this.suppliersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suppliersBtn.UseVisualStyleBackColor = false;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.productsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ForeColor = System.Drawing.Color.Black;
            this.productsBtn.Image = ((System.Drawing.Image)(resources.GetObject("productsBtn.Image")));
            this.productsBtn.Location = new System.Drawing.Point(278, 9);
            this.productsBtn.Margin = new System.Windows.Forms.Padding(10, 10, 10, 100);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(160, 55);
            this.productsBtn.TabIndex = 0;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsBtn.UseVisualStyleBackColor = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 96);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1332, 762);
            this.contentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 858);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.accountTollStrip.ResumeLayout(false);
            this.accountTollStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.ToolStrip accountTollStrip;
        private System.Windows.Forms.ToolStripDropDownButton userMenuButton;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button stockMoveBtn;
        private System.Windows.Forms.Button homeBtn;
    }
}