namespace Employee_Management_Alpha_1._0
{
    partial class AddStock
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
            this.tbQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbPricePerUnit = new System.Windows.Forms.NumericUpDown();
            this.lbStockInfo = new System.Windows.Forms.ListBox();
            this.btnAddStockItem = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPricePerUnit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(175, 123);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(160, 22);
            this.tbQuantity.TabIndex = 45;
            // 
            // tbPricePerUnit
            // 
            this.tbPricePerUnit.DecimalPlaces = 2;
            this.tbPricePerUnit.Location = new System.Drawing.Point(175, 162);
            this.tbPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPricePerUnit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbPricePerUnit.Name = "tbPricePerUnit";
            this.tbPricePerUnit.Size = new System.Drawing.Size(160, 22);
            this.tbPricePerUnit.TabIndex = 44;
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.FormattingEnabled = true;
            this.lbStockInfo.ItemHeight = 16;
            this.lbStockInfo.Location = new System.Drawing.Point(49, 308);
            this.lbStockInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(735, 164);
            this.lbStockInfo.TabIndex = 43;
            // 
            // btnAddStockItem
            // 
            this.btnAddStockItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddStockItem.FlatAppearance.BorderSize = 0;
            this.btnAddStockItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStockItem.ForeColor = System.Drawing.Color.Silver;
            this.btnAddStockItem.Location = new System.Drawing.Point(632, 57);
            this.btnAddStockItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStockItem.Name = "btnAddStockItem";
            this.btnAddStockItem.Size = new System.Drawing.Size(152, 78);
            this.btnAddStockItem.TabIndex = 41;
            this.btnAddStockItem.Text = "Add";
            this.btnAddStockItem.UseVisualStyleBackColor = false;
            this.btnAddStockItem.Click += new System.EventHandler(this.BtnAddStockItem_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(175, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(244, 22);
            this.tbName.TabIndex = 37;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemName.Location = new System.Drawing.Point(57, 86);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 18);
            this.lblItemName.TabIndex = 38;
            this.lblItemName.Text = "Item Name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(57, 122);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 18);
            this.Label4.TabIndex = 40;
            this.Label4.Text = "Quantity:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPricePerUnit.Location = new System.Drawing.Point(57, 162);
            this.lblPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(98, 18);
            this.lblPricePerUnit.TabIndex = 39;
            this.lblPricePerUnit.Text = "Price per unit:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(49, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(389, 175);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(125, 142);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 24);
            this.cbCategory.TabIndex = 38;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Location = new System.Drawing.Point(8, 142);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 18);
            this.lblCategory.TabIndex = 37;
            this.lblCategory.Text = "Category";
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
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(821, 487);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPricePerUnit);
            this.Controls.Add(this.lbStockInfo);
            this.Controls.Add(this.btnAddStockItem);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblPricePerUnit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.Shown += new System.EventHandler(this.AddStock_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPricePerUnit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown tbQuantity;
        private System.Windows.Forms.NumericUpDown tbPricePerUnit;
        private System.Windows.Forms.ListBox lbStockInfo;
        internal System.Windows.Forms.Button btnAddStockItem;
        internal System.Windows.Forms.TextBox tbName;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label lblCategory;
        public System.Windows.Forms.ComboBox cbCategory;
    }
}