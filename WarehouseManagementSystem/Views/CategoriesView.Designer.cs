namespace WarehouseManagementSystem
{
    partial class CategoriesView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.exportBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usersLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.prodGrid = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.suppliersLbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.prodCountVarLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.catNameLbl = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchIcon);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.exportBtn);
            this.panel2.Controls.Add(this.reloadBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.editBtn);
            this.panel2.Controls.Add(this.newBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 46);
            this.panel2.TabIndex = 1;
            // 
            // searchIcon
            // 
            this.searchIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchIcon.InitialImage")));
            this.searchIcon.Location = new System.Drawing.Point(669, 8);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(29, 31);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 6;
            this.searchIcon.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(703, 10);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(485, 31);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.exportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
            this.exportBtn.Location = new System.Drawing.Point(390, 5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(95, 35);
            this.exportBtn.TabIndex = 4;
            this.exportBtn.Text = "Export";
            this.exportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.reloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.ForeColor = System.Drawing.Color.White;
            this.reloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("reloadBtn.Image")));
            this.reloadBtn.Location = new System.Drawing.Point(286, 5);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(98, 35);
            this.reloadBtn.TabIndex = 3;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.Location = new System.Drawing.Point(171, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(92, 35);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.Location = new System.Drawing.Point(90, 5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 35);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.newBtn.FlatAppearance.BorderSize = 0;
            this.newBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.newBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.White;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.Location = new System.Drawing.Point(9, 5);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 35);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New";
            this.newBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // gridCategories
            // 
            this.gridCategories.AllowUserToAddRows = false;
            this.gridCategories.AllowUserToDeleteRows = false;
            this.gridCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategories.BackgroundColor = System.Drawing.Color.White;
            this.gridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryName,
            this.ProductCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCategories.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategories.Location = new System.Drawing.Point(3, 3);
            this.gridCategories.MultiSelect = false;
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.ReadOnly = true;
            this.gridCategories.RowHeadersVisible = false;
            this.gridCategories.RowHeadersWidth = 51;
            this.gridCategories.RowTemplate.Height = 24;
            this.gridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCategories.Size = new System.Drawing.Size(774, 404);
            this.gridCategories.TabIndex = 2;
            this.gridCategories.SelectionChanged += new System.EventHandler(this.gridCategories_SelectionChanged);
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // ProductCount
            // 
            this.ProductCount.DataPropertyName = "ProductCount";
            this.ProductCount.HeaderText = "Product Count";
            this.ProductCount.MinimumWidth = 6;
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // usersLabel
            // 
            this.usersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.Location = new System.Drawing.Point(2, 3);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(155, 38);
            this.usersLabel.TabIndex = 0;
            this.usersLabel.Text = "Categories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usersLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 44);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridCategories, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 410);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(783, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 404);
            this.panel3.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.prodGrid);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(414, 302);
            this.panel9.TabIndex = 7;
            // 
            // prodGrid
            // 
            this.prodGrid.AllowUserToAddRows = false;
            this.prodGrid.AllowUserToDeleteRows = false;
            this.prodGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodGrid.BackgroundColor = System.Drawing.Color.White;
            this.prodGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.prodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.CurrentStock});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.prodGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodGrid.Location = new System.Drawing.Point(0, 0);
            this.prodGrid.MultiSelect = false;
            this.prodGrid.Name = "prodGrid";
            this.prodGrid.ReadOnly = true;
            this.prodGrid.RowHeadersVisible = false;
            this.prodGrid.RowHeadersWidth = 51;
            this.prodGrid.RowTemplate.Height = 24;
            this.prodGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodGrid.Size = new System.Drawing.Size(414, 302);
            this.prodGrid.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.suppliersLbl);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 68);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(414, 34);
            this.panel7.TabIndex = 5;
            // 
            // suppliersLbl
            // 
            this.suppliersLbl.AutoSize = true;
            this.suppliersLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.suppliersLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersLbl.Location = new System.Drawing.Point(0, 0);
            this.suppliersLbl.Name = "suppliersLbl";
            this.suppliersLbl.Size = new System.Drawing.Size(100, 28);
            this.suppliersLbl.TabIndex = 1;
            this.suppliersLbl.Text = "Products:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.prodCountVarLbl);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(414, 34);
            this.panel5.TabIndex = 3;
            // 
            // prodCountVarLbl
            // 
            this.prodCountVarLbl.AutoSize = true;
            this.prodCountVarLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.prodCountVarLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodCountVarLbl.Location = new System.Drawing.Point(157, 0);
            this.prodCountVarLbl.Name = "prodCountVarLbl";
            this.prodCountVarLbl.Size = new System.Drawing.Size(167, 28);
            this.prodCountVarLbl.TabIndex = 2;
            this.prodCountVarLbl.Text = "actual prod count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product count: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.catNameLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 34);
            this.panel4.TabIndex = 2;
            // 
            // catNameLbl
            // 
            this.catNameLbl.AutoSize = true;
            this.catNameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.catNameLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catNameLbl.Location = new System.Drawing.Point(0, 0);
            this.catNameLbl.Name = "catNameLbl";
            this.catNameLbl.Size = new System.Drawing.Size(180, 31);
            this.catNameLbl.TabIndex = 1;
            this.catNameLbl.Text = "Category Name";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // CurrentStock
            // 
            this.CurrentStock.DataPropertyName = "CurrentStock";
            this.CurrentStock.HeaderText = "Current Stock";
            this.CurrentStock.MinimumWidth = 6;
            this.CurrentStock.Name = "CurrentStock";
            this.CurrentStock.ReadOnly = true;
            // 
            // CategoriesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoriesView";
            this.Size = new System.Drawing.Size(1200, 500);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView gridCategories;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView prodGrid;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label suppliersLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label prodCountVarLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label catNameLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStock;
    }
}
