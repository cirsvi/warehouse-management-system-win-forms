namespace WarehouseManagementSystem
{
    partial class SuppliersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersView));
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.prodSupGrid = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.suppliersLbl = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.emailVarLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.editProdBtn = new System.Windows.Forms.Button();
            this.remProdBtn = new System.Windows.Forms.Button();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.phoneVarLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contPersVarLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.supNameLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodSupGrid)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1541, 46);
            this.panel2.TabIndex = 1;
            // 
            // searchIcon
            // 
            this.searchIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("searchIcon.InitialImage")));
            this.searchIcon.Location = new System.Drawing.Point(1010, 8);
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
            this.searchBox.Location = new System.Drawing.Point(1044, 10);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // productsLabel
            // 
            this.productsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(2, 3);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(138, 38);
            this.productsLabel.TabIndex = 0;
            this.productsLabel.Text = "Suppliers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productsLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 44);
            this.panel1.TabIndex = 0;
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.AllowUserToAddRows = false;
            this.gridSuppliers.AllowUserToDeleteRows = false;
            this.gridSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.gridSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierName,
            this.ContactPerson,
            this.Email,
            this.PhoneNr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSuppliers.Location = new System.Drawing.Point(3, 3);
            this.gridSuppliers.MultiSelect = false;
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.ReadOnly = true;
            this.gridSuppliers.RowHeadersVisible = false;
            this.gridSuppliers.RowHeadersWidth = 51;
            this.gridSuppliers.RowTemplate.Height = 24;
            this.gridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSuppliers.Size = new System.Drawing.Size(995, 609);
            this.gridSuppliers.TabIndex = 2;
            this.gridSuppliers.SelectionChanged += new System.EventHandler(this.gridProducts_SelectionChanged);
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // ContactPerson
            // 
            this.ContactPerson.DataPropertyName = "ContactPerson";
            this.ContactPerson.HeaderText = "Contact Person";
            this.ContactPerson.MinimumWidth = 6;
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // PhoneNr
            // 
            this.PhoneNr.DataPropertyName = "Phone";
            this.PhoneNr.HeaderText = "Phone Nr.";
            this.PhoneNr.MinimumWidth = 6;
            this.PhoneNr.Name = "PhoneNr";
            this.PhoneNr.ReadOnly = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.Controls.Add(this.gridSuppliers, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1541, 615);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1004, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 609);
            this.panel3.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.prodSupGrid);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 170);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(534, 385);
            this.panel9.TabIndex = 7;
            // 
            // prodSupGrid
            // 
            this.prodSupGrid.AllowUserToAddRows = false;
            this.prodSupGrid.AllowUserToDeleteRows = false;
            this.prodSupGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodSupGrid.BackgroundColor = System.Drawing.Color.White;
            this.prodSupGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodSupGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.prodSupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodSupGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.PricePerUnit});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodSupGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.prodSupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodSupGrid.Location = new System.Drawing.Point(0, 0);
            this.prodSupGrid.MultiSelect = false;
            this.prodSupGrid.Name = "prodSupGrid";
            this.prodSupGrid.ReadOnly = true;
            this.prodSupGrid.RowHeadersVisible = false;
            this.prodSupGrid.RowHeadersWidth = 51;
            this.prodSupGrid.RowTemplate.Height = 24;
            this.prodSupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodSupGrid.Size = new System.Drawing.Size(534, 385);
            this.prodSupGrid.TabIndex = 3;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.DataPropertyName = "PricePerUnit";
            this.PricePerUnit.HeaderText = "Price Per Unit";
            this.PricePerUnit.MinimumWidth = 6;
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.suppliersLbl);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 136);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 34);
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
            // panel10
            // 
            this.panel10.Controls.Add(this.emailVarLbl);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 102);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(534, 34);
            this.panel10.TabIndex = 5;
            // 
            // emailVarLbl
            // 
            this.emailVarLbl.AutoSize = true;
            this.emailVarLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.emailVarLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailVarLbl.Location = new System.Drawing.Point(69, 0);
            this.emailVarLbl.Name = "emailVarLbl";
            this.emailVarLbl.Size = new System.Drawing.Size(119, 28);
            this.emailVarLbl.TabIndex = 2;
            this.emailVarLbl.Text = "Actual email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.editProdBtn);
            this.panel8.Controls.Add(this.remProdBtn);
            this.panel8.Controls.Add(this.addProdBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 555);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(534, 54);
            this.panel8.TabIndex = 6;
            // 
            // editProdBtn
            // 
            this.editProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.editProdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.editProdBtn.FlatAppearance.BorderSize = 0;
            this.editProdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.editProdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.editProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProdBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProdBtn.ForeColor = System.Drawing.Color.White;
            this.editProdBtn.Image = ((System.Drawing.Image)(resources.GetObject("editProdBtn.Image")));
            this.editProdBtn.Location = new System.Drawing.Point(203, 10);
            this.editProdBtn.Name = "editProdBtn";
            this.editProdBtn.Size = new System.Drawing.Size(144, 35);
            this.editProdBtn.TabIndex = 4;
            this.editProdBtn.Text = "Edit Product";
            this.editProdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editProdBtn.UseVisualStyleBackColor = false;
            this.editProdBtn.Click += new System.EventHandler(this.editProdBtn_Click);
            // 
            // remProdBtn
            // 
            this.remProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remProdBtn.BackColor = System.Drawing.Color.Red;
            this.remProdBtn.FlatAppearance.BorderSize = 0;
            this.remProdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.remProdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.remProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remProdBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remProdBtn.ForeColor = System.Drawing.Color.White;
            this.remProdBtn.Image = ((System.Drawing.Image)(resources.GetObject("remProdBtn.Image")));
            this.remProdBtn.Location = new System.Drawing.Point(353, 10);
            this.remProdBtn.Name = "remProdBtn";
            this.remProdBtn.Size = new System.Drawing.Size(172, 35);
            this.remProdBtn.TabIndex = 3;
            this.remProdBtn.Text = "Remove Product";
            this.remProdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.remProdBtn.UseVisualStyleBackColor = false;
            this.remProdBtn.Click += new System.EventHandler(this.remProdBtn_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addProdBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addProdBtn.FlatAppearance.BorderSize = 0;
            this.addProdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.addProdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.addProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProdBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdBtn.ForeColor = System.Drawing.Color.White;
            this.addProdBtn.Image = ((System.Drawing.Image)(resources.GetObject("addProdBtn.Image")));
            this.addProdBtn.Location = new System.Drawing.Point(53, 10);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(144, 35);
            this.addProdBtn.TabIndex = 1;
            this.addProdBtn.Text = "Add Product";
            this.addProdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProdBtn.UseVisualStyleBackColor = false;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.phoneVarLbl);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 34);
            this.panel6.TabIndex = 4;
            // 
            // phoneVarLbl
            // 
            this.phoneVarLbl.AutoSize = true;
            this.phoneVarLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.phoneVarLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneVarLbl.Location = new System.Drawing.Point(76, 0);
            this.phoneVarLbl.Name = "phoneVarLbl";
            this.phoneVarLbl.Size = new System.Drawing.Size(155, 28);
            this.phoneVarLbl.TabIndex = 2;
            this.phoneVarLbl.Text = "Actual phone Nr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.contPersVarLbl);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 34);
            this.panel5.TabIndex = 3;
            // 
            // contPersVarLbl
            // 
            this.contPersVarLbl.AutoSize = true;
            this.contPersVarLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.contPersVarLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contPersVarLbl.Location = new System.Drawing.Point(160, 0);
            this.contPersVarLbl.Name = "contPersVarLbl";
            this.contPersVarLbl.Size = new System.Drawing.Size(132, 28);
            this.contPersVarLbl.TabIndex = 2;
            this.contPersVarLbl.Text = "Actual person";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact person:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.supNameLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 34);
            this.panel4.TabIndex = 2;
            // 
            // supNameLbl
            // 
            this.supNameLbl.AutoSize = true;
            this.supNameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.supNameLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameLbl.Location = new System.Drawing.Point(0, 0);
            this.supNameLbl.Name = "supNameLbl";
            this.supNameLbl.Size = new System.Drawing.Size(173, 31);
            this.supNameLbl.TabIndex = 1;
            this.supNameLbl.Text = "Supplier Name";
            // 
            // SuppliersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SuppliersView";
            this.Size = new System.Drawing.Size(1541, 705);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodSupGrid)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.DataGridView gridSuppliers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label supNameLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button remProdBtn;
        private System.Windows.Forms.Button addProdBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label suppliersLbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label phoneVarLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label contPersVarLbl;
        private System.Windows.Forms.DataGridView prodSupGrid;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label emailVarLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.Button editProdBtn;
    }
}
