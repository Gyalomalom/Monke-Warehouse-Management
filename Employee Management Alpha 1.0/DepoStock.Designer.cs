﻿namespace Employee_Management_Alpha_1._0
{
    partial class DepoStock
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
            this.lbDepoStock = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNewItemName = new System.Windows.Forms.TextBox();
            this.tbNewCategory = new System.Windows.Forms.TextBox();
            this.tbNewQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbNewPricePerUnit = new System.Windows.Forms.NumericUpDown();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPricePerUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDepoStock
            // 
            this.lbDepoStock.FormattingEnabled = true;
            this.lbDepoStock.ItemHeight = 16;
            this.lbDepoStock.Location = new System.Drawing.Point(61, 244);
            this.lbDepoStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbDepoStock.Name = "lbDepoStock";
            this.lbDepoStock.Size = new System.Drawing.Size(719, 228);
            this.lbDepoStock.TabIndex = 66;
            this.lbDepoStock.Click += new System.EventHandler(this.LbDepoStock_Click);
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
            this.btnClose.TabIndex = 65;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(61, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(389, 175);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details:";
            // 
            // tbNewItemName
            // 
            this.tbNewItemName.Location = new System.Drawing.Point(172, 33);
            this.tbNewItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewItemName.Name = "tbNewItemName";
            this.tbNewItemName.Size = new System.Drawing.Size(159, 22);
            this.tbNewItemName.TabIndex = 56;
            // 
            // tbNewCategory
            // 
            this.tbNewCategory.Location = new System.Drawing.Point(172, 130);
            this.tbNewCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewCategory.Name = "tbNewCategory";
            this.tbNewCategory.Size = new System.Drawing.Size(159, 22);
            this.tbNewCategory.TabIndex = 63;
            // 
            // tbNewQuantity
            // 
            this.tbNewQuantity.Location = new System.Drawing.Point(172, 65);
            this.tbNewQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewQuantity.Name = "tbNewQuantity";
            this.tbNewQuantity.Size = new System.Drawing.Size(160, 22);
            this.tbNewQuantity.TabIndex = 57;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Location = new System.Drawing.Point(43, 130);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 18);
            this.lblCategory.TabIndex = 59;
            this.lblCategory.Text = "Category";
            // 
            // tbNewPricePerUnit
            // 
            this.tbNewPricePerUnit.DecimalPlaces = 2;
            this.tbNewPricePerUnit.Location = new System.Drawing.Point(172, 97);
            this.tbNewPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewPricePerUnit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbNewPricePerUnit.Name = "tbNewPricePerUnit";
            this.tbNewPricePerUnit.Size = new System.Drawing.Size(160, 22);
            this.tbNewPricePerUnit.TabIndex = 58;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemName.Location = new System.Drawing.Point(43, 34);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 18);
            this.lblItemName.TabIndex = 60;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPricePerUnit.Location = new System.Drawing.Point(43, 97);
            this.lblPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(98, 18);
            this.lblPricePerUnit.TabIndex = 61;
            this.lblPricePerUnit.Text = "Price per unit:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(44, 65);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 18);
            this.Label4.TabIndex = 62;
            this.Label4.Text = "Quantity:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(637, 189);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(141, 22);
            this.tbID.TabIndex = 68;
            this.tbID.TextChanged += new System.EventHandler(this.TbID_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Silver;
            this.btnUpdate.Location = new System.Drawing.Point(635, 101);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 73);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // DepoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(821, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbDepoStock);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DepoStock";
            this.Text = "DepoStock";
            this.Load += new System.EventHandler(this.DepoStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPricePerUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbDepoStock;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNewItemName;
        private System.Windows.Forms.TextBox tbNewCategory;
        private System.Windows.Forms.NumericUpDown tbNewQuantity;
        internal System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.NumericUpDown tbNewPricePerUnit;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.Label lblPricePerUnit;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox tbID;
        internal System.Windows.Forms.Button btnUpdate;
    }
}