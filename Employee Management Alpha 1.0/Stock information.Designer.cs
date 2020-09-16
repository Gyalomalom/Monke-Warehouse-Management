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
            ((System.ComponentModel.ISupportInitialize)(this.tbPricePerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Employee_Management_Alpha_1._0.Properties.Resources.icons8_back_24;
            this.btnClose.Location = new System.Drawing.Point(9, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(104, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(184, 20);
            this.tbName.TabIndex = 17;
            //this.tbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(16, 76);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(71, 15);
            this.lblItemName.TabIndex = 18;
            this.lblItemName.Text = "Item Name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 105);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 15);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Quantity:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.Location = new System.Drawing.Point(16, 138);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(82, 15);
            this.lblPricePerUnit.TabIndex = 22;
            this.lblPricePerUnit.Text = "Price per unit:";
            // 
            // btnRemoveStockItem
            // 
            this.btnRemoveStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStockItem.Location = new System.Drawing.Point(449, 101);
            this.btnRemoveStockItem.Name = "btnRemoveStockItem";
            this.btnRemoveStockItem.Size = new System.Drawing.Size(83, 29);
            this.btnRemoveStockItem.TabIndex = 30;
            this.btnRemoveStockItem.Text = "Remove";
            this.btnRemoveStockItem.UseVisualStyleBackColor = true;
            this.btnRemoveStockItem.Click += new System.EventHandler(this.BtnRemoveStockItem_Click);
            // 
            // btnAddStockItem
            // 
            this.btnAddStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStockItem.Location = new System.Drawing.Point(449, 66);
            this.btnAddStockItem.Name = "btnAddStockItem";
            this.btnAddStockItem.Size = new System.Drawing.Size(83, 29);
            this.btnAddStockItem.TabIndex = 28;
            this.btnAddStockItem.Text = "Add";
            this.btnAddStockItem.UseVisualStyleBackColor = true;
            //this.btnAddStockItem.Click += new System.EventHandler(this.BtnAddStockItem_Click);
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.FormattingEnabled = true;
            this.lbStockInfo.Location = new System.Drawing.Point(19, 223);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(575, 134);
            this.lbStockInfo.TabIndex = 32;
            // 
            // tbPricePerUnit
            // 
            this.tbPricePerUnit.DecimalPlaces = 2;
            this.tbPricePerUnit.Location = new System.Drawing.Point(104, 138);
            this.tbPricePerUnit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbPricePerUnit.Name = "tbPricePerUnit";
            this.tbPricePerUnit.Size = new System.Drawing.Size(120, 20);
            this.tbPricePerUnit.TabIndex = 33;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(104, 106);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(120, 20);
            this.tbQuantity.TabIndex = 34;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(449, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 29);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Stock_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(616, 396);
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
    }
}