﻿namespace Employee_Management_Alpha_1._0
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
            this.lbStockInfo = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNewCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.tbNewPricePerUnit = new System.Windows.Forms.NumericUpDown();
            this.tbNewQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbNewItemName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPricePerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.FormattingEnabled = true;
            this.lbStockInfo.Location = new System.Drawing.Point(9, 172);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(597, 212);
            this.lbStockInfo.TabIndex = 32;
            this.lbStockInfo.Click += new System.EventHandler(this.LbStockInfo_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Silver;
            this.btnUpdate.Location = new System.Drawing.Point(484, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 59);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
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
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(484, 129);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(107, 20);
            this.tbID.TabIndex = 36;
            this.tbID.TextChanged += new System.EventHandler(this.TbID_TextChanged);
            // 
            // tbNewCategory
            // 
            this.tbNewCategory.Location = new System.Drawing.Point(129, 106);
            this.tbNewCategory.Name = "tbNewCategory";
            this.tbNewCategory.Size = new System.Drawing.Size(120, 20);
            this.tbNewCategory.TabIndex = 63;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Location = new System.Drawing.Point(32, 106);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 59;
            this.lblCategory.Text = "Category";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemName.Location = new System.Drawing.Point(32, 28);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(71, 15);
            this.lblItemName.TabIndex = 60;
            this.lblItemName.Text = "Item Name:";
            this.lblItemName.Click += new System.EventHandler(this.LblItemName_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(33, 53);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 15);
            this.Label4.TabIndex = 62;
            this.Label4.Text = "Quantity:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPricePerUnit.Location = new System.Drawing.Point(32, 79);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(82, 15);
            this.lblPricePerUnit.TabIndex = 61;
            this.lblPricePerUnit.Text = "Price per unit:";
            // 
            // tbNewPricePerUnit
            // 
            this.tbNewPricePerUnit.DecimalPlaces = 2;
            this.tbNewPricePerUnit.Location = new System.Drawing.Point(129, 79);
            this.tbNewPricePerUnit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbNewPricePerUnit.Name = "tbNewPricePerUnit";
            this.tbNewPricePerUnit.Size = new System.Drawing.Size(120, 20);
            this.tbNewPricePerUnit.TabIndex = 58;
            // 
            // tbNewQuantity
            // 
            this.tbNewQuantity.Location = new System.Drawing.Point(129, 53);
            this.tbNewQuantity.Name = "tbNewQuantity";
            this.tbNewQuantity.Size = new System.Drawing.Size(120, 20);
            this.tbNewQuantity.TabIndex = 57;
            // 
            // tbNewItemName
            // 
            this.tbNewItemName.Location = new System.Drawing.Point(129, 27);
            this.tbNewItemName.Name = "tbNewItemName";
            this.tbNewItemName.Size = new System.Drawing.Size(120, 20);
            this.tbNewItemName.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.Controls.Add(this.tbNewItemName);
            this.groupBox1.Controls.Add(this.tbNewCategory);
            this.groupBox1.Controls.Add(this.tbNewQuantity);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.tbNewPricePerUnit);
            this.groupBox1.Controls.Add(this.lblItemName);
            this.groupBox1.Controls.Add(this.lblPricePerUnit);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(60, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(292, 142);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details:";
            // 
            // Stock_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbStockInfo);
            this.Controls.Add(this.btnClose);
            this.Name = "Stock_information";
            this.Text = "Stock_information";
            this.Load += new System.EventHandler(this.Stock_information_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPricePerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbStockInfo;
        internal System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNewCategory;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.NumericUpDown tbNewPricePerUnit;
        private System.Windows.Forms.NumericUpDown tbNewQuantity;
        private System.Windows.Forms.TextBox tbNewItemName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}