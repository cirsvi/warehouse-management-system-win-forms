namespace WarehouseManagementSystem
{
    partial class StockMovementShipForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productWindowTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notesInput = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.quantityInput = new System.Windows.Forms.NumericUpDown();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.curStockVarLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productWindowTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 60);
            this.panel1.TabIndex = 0;
            // 
            // productWindowTitle
            // 
            this.productWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.productWindowTitle.AutoSize = true;
            this.productWindowTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productWindowTitle.Location = new System.Drawing.Point(12, 13);
            this.productWindowTitle.Name = "productWindowTitle";
            this.productWindowTitle.Size = new System.Drawing.Size(132, 31);
            this.productWindowTitle.TabIndex = 0;
            this.productWindowTitle.Text = "Ship stock:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.notesInput);
            this.panel2.Controls.Add(this.notesLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 160);
            this.panel2.TabIndex = 1;
            // 
            // notesInput
            // 
            this.notesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesInput.Location = new System.Drawing.Point(18, 39);
            this.notesInput.MaxLength = 255;
            this.notesInput.Multiline = true;
            this.notesInput.Name = "notesInput";
            this.notesInput.Size = new System.Drawing.Size(539, 110);
            this.notesInput.TabIndex = 1;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(14, 13);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(59, 23);
            this.notesLbl.TabIndex = 0;
            this.notesLbl.Text = "Notes:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.productComboBox);
            this.panel3.Controls.Add(this.productLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 80);
            this.panel3.TabIndex = 2;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(18, 39);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(539, 31);
            this.productComboBox.TabIndex = 2;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(14, 11);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(74, 23);
            this.productLbl.TabIndex = 1;
            this.productLbl.Text = "Product:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.saveBtn);
            this.panel4.Controls.Add(this.cancelBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 80);
            this.panel4.TabIndex = 3;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.curStockVarLbl);
            this.panel6.Controls.Add(this.quantityInput);
            this.panel6.Controls.Add(this.quantityLbl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(582, 80);
            this.panel6.TabIndex = 5;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(18, 38);
            this.quantityInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(539, 30);
            this.quantityInput.TabIndex = 2;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(14, 11);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(80, 23);
            this.quantityLbl.TabIndex = 1;
            this.quantityLbl.Text = "Quantity:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.datePicker);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 220);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(582, 80);
            this.panel7.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(18, 37);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(539, 30);
            this.datePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // curStockVarLbl
            // 
            this.curStockVarLbl.AutoSize = true;
            this.curStockVarLbl.ForeColor = System.Drawing.Color.Maroon;
            this.curStockVarLbl.Location = new System.Drawing.Point(100, 12);
            this.curStockVarLbl.Name = "curStockVarLbl";
            this.curStockVarLbl.Size = new System.Drawing.Size(155, 23);
            this.curStockVarLbl.TabIndex = 3;
            this.curStockVarLbl.Text = "(Current quantity: )";
            // 
            // StockMovementShsipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockMovementShsipForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityInput)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label productWindowTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox notesInput;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.NumericUpDown quantityInput;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label curStockVarLbl;
    }
}