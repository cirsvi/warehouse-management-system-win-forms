namespace WarehouseManagementSystem
{
    partial class StockMovementView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMovementView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterPicBox = new System.Windows.Forms.PictureBox();
            this.filterOption = new System.Windows.Forms.ComboBox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.exportBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.shipBtn = new System.Windows.Forms.Button();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.gridMovements = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stockMovLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovements)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.filterPicBox);
            this.panel2.Controls.Add(this.filterOption);
            this.panel2.Controls.Add(this.searchIcon);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.exportBtn);
            this.panel2.Controls.Add(this.reloadBtn);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.shipBtn);
            this.panel2.Controls.Add(this.receiveBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1541, 46);
            this.panel2.TabIndex = 1;
            // 
            // filterPicBox
            // 
            this.filterPicBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterPicBox.Image = ((System.Drawing.Image)(resources.GetObject("filterPicBox.Image")));
            this.filterPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("filterPicBox.InitialImage")));
            this.filterPicBox.Location = new System.Drawing.Point(859, 9);
            this.filterPicBox.Name = "filterPicBox";
            this.filterPicBox.Size = new System.Drawing.Size(29, 31);
            this.filterPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filterPicBox.TabIndex = 9;
            this.filterPicBox.TabStop = false;
            // 
            // filterOption
            // 
            this.filterOption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filterOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterOption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOption.FormattingEnabled = true;
            this.filterOption.Items.AddRange(new object[] {
            "All",
            "In",
            "Out",
            "Deleted"});
            this.filterOption.Location = new System.Drawing.Point(894, 7);
            this.filterOption.Name = "filterOption";
            this.filterOption.Size = new System.Drawing.Size(90, 36);
            this.filterOption.TabIndex = 8;
            this.filterOption.SelectedIndexChanged += new System.EventHandler(this.filterOption_SelectedIndexChanged);
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
            this.exportBtn.Location = new System.Drawing.Point(485, 5);
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
            this.reloadBtn.Location = new System.Drawing.Point(381, 5);
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
            this.deleteBtn.Location = new System.Drawing.Point(229, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(92, 35);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // shipBtn
            // 
            this.shipBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.shipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.shipBtn.FlatAppearance.BorderSize = 0;
            this.shipBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.shipBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.shipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shipBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipBtn.ForeColor = System.Drawing.Color.White;
            this.shipBtn.Image = ((System.Drawing.Image)(resources.GetObject("shipBtn.Image")));
            this.shipBtn.Location = new System.Drawing.Point(128, 5);
            this.shipBtn.Name = "shipBtn";
            this.shipBtn.Size = new System.Drawing.Size(95, 35);
            this.shipBtn.TabIndex = 1;
            this.shipBtn.Text = "Ship";
            this.shipBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shipBtn.UseVisualStyleBackColor = false;
            this.shipBtn.Click += new System.EventHandler(this.shipBtn_Click);
            // 
            // receiveBtn
            // 
            this.receiveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.receiveBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.receiveBtn.FlatAppearance.BorderSize = 0;
            this.receiveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.receiveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.receiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiveBtn.ForeColor = System.Drawing.Color.White;
            this.receiveBtn.Image = ((System.Drawing.Image)(resources.GetObject("receiveBtn.Image")));
            this.receiveBtn.Location = new System.Drawing.Point(9, 5);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(113, 35);
            this.receiveBtn.TabIndex = 0;
            this.receiveBtn.Text = "Receive";
            this.receiveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.receiveBtn.UseVisualStyleBackColor = false;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // gridMovements
            // 
            this.gridMovements.AllowUserToAddRows = false;
            this.gridMovements.AllowUserToDeleteRows = false;
            this.gridMovements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMovements.BackgroundColor = System.Drawing.Color.White;
            this.gridMovements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.SupplierName,
            this.colMovementType,
            this.Quantity,
            this.MovementDate,
            this.Note});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMovements.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMovements.Location = new System.Drawing.Point(0, 90);
            this.gridMovements.MultiSelect = false;
            this.gridMovements.Name = "gridMovements";
            this.gridMovements.ReadOnly = true;
            this.gridMovements.RowHeadersVisible = false;
            this.gridMovements.RowHeadersWidth = 51;
            this.gridMovements.RowTemplate.Height = 24;
            this.gridMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMovements.Size = new System.Drawing.Size(1541, 587);
            this.gridMovements.TabIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // colMovementType
            // 
            this.colMovementType.DataPropertyName = "Type";
            this.colMovementType.HeaderText = "Movement Type";
            this.colMovementType.MinimumWidth = 6;
            this.colMovementType.Name = "colMovementType";
            this.colMovementType.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // MovementDate
            // 
            this.MovementDate.DataPropertyName = "MovementDate";
            this.MovementDate.HeaderText = "Movement Date";
            this.MovementDate.MinimumWidth = 6;
            this.MovementDate.Name = "MovementDate";
            this.MovementDate.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // stockMovLabel
            // 
            this.stockMovLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.stockMovLabel.AutoSize = true;
            this.stockMovLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockMovLabel.Location = new System.Drawing.Point(2, 3);
            this.stockMovLabel.Name = "stockMovLabel";
            this.stockMovLabel.Size = new System.Drawing.Size(240, 38);
            this.stockMovLabel.TabIndex = 0;
            this.stockMovLabel.Text = "Stock Movement";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stockMovLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 44);
            this.panel1.TabIndex = 0;
            // 
            // StockMovementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gridMovements);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StockMovementView";
            this.Size = new System.Drawing.Size(1541, 677);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovements)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.Button shipBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView gridMovements;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label stockMovLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.ComboBox filterOption;
        private System.Windows.Forms.PictureBox filterPicBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}
