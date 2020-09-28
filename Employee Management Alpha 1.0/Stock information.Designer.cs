namespace Employee_Management_Alpha_1._0
{
    partial class Stock_information
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnRemoveStockItem = new System.Windows.Forms.Button();
            this.btnAddStockItem = new System.Windows.Forms.Button();
            this.lbStockInfo = new System.Windows.Forms.ListBox();
            this.tbPricePerUnit = new System.Windows.Forms.NumericUpDown();
            this.tbQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbPricePerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Employee_Management_Alpha_1._0.Properties.Resources.icons8_back_24;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(139, 92);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(244, 22);
            this.tbName.TabIndex = 17;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemName.Location = new System.Drawing.Point(21, 94);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 18);
            this.lblItemName.TabIndex = 18;
            this.lblItemName.Text = "Item Name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(21, 129);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 18);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Quantity:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPricePerUnit.Location = new System.Drawing.Point(21, 170);
            this.lblPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(98, 18);
            this.lblPricePerUnit.TabIndex = 22;
            this.lblPricePerUnit.Text = "Price per unit:";
            // 
            // btnRemoveStockItem
            // 
            this.btnRemoveStockItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRemoveStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStockItem.ForeColor = System.Drawing.Color.Silver;
            this.btnRemoveStockItem.Location = new System.Drawing.Point(599, 124);
            this.btnRemoveStockItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveStockItem.Name = "btnRemoveStockItem";
            this.btnRemoveStockItem.Size = new System.Drawing.Size(111, 36);
            this.btnRemoveStockItem.TabIndex = 30;
            this.btnRemoveStockItem.Text = "Remove";
            this.btnRemoveStockItem.UseVisualStyleBackColor = false;
            this.btnRemoveStockItem.Click += new System.EventHandler(this.BtnRemoveStockItem_Click);
            // 
            // btnAddStockItem
            // 
            this.btnAddStockItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStockItem.ForeColor = System.Drawing.Color.Silver;
            this.btnAddStockItem.Location = new System.Drawing.Point(599, 81);
            this.btnAddStockItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStockItem.Name = "btnAddStockItem";
            this.btnAddStockItem.Size = new System.Drawing.Size(111, 36);
            this.btnAddStockItem.TabIndex = 28;
            this.btnAddStockItem.Text = "Add";
            this.btnAddStockItem.UseVisualStyleBackColor = false;
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.FormattingEnabled = true;
            this.lbStockInfo.ItemHeight = 16;
            this.lbStockInfo.Location = new System.Drawing.Point(13, 274);
            this.lbStockInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(795, 164);
            this.lbStockInfo.TabIndex = 32;
            // 
            // tbPricePerUnit
            // 
            this.tbPricePerUnit.DecimalPlaces = 2;
            this.tbPricePerUnit.Location = new System.Drawing.Point(139, 170);
            this.tbPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPricePerUnit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbPricePerUnit.Name = "tbPricePerUnit";
            this.tbPricePerUnit.Size = new System.Drawing.Size(160, 22);
            this.tbPricePerUnit.TabIndex = 33;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(139, 130);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(160, 22);
            this.tbQuantity.TabIndex = 34;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Silver;
            this.btnUpdate.Location = new System.Drawing.Point(599, 167);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 36);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 139);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Stock_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(821, 487);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPricePerUnit);
            this.Controls.Add(this.lbStockInfo);
            this.Controls.Add(this.btnRemoveStockItem);
            this.Controls.Add(this.btnAddStockItem);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblPricePerUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Stock_information";
            this.Text = "Stock_information";
            ((System.ComponentModel.ISupportInitialize)(this.tbPricePerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblPricePerUnit;
        internal System.Windows.Forms.Button btnRemoveStockItem;
        internal System.Windows.Forms.Button btnAddStockItem;
        private System.Windows.Forms.ListBox lbStockInfo;
        private System.Windows.Forms.NumericUpDown tbPricePerUnit;
        private System.Windows.Forms.NumericUpDown tbQuantity;
        internal System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}