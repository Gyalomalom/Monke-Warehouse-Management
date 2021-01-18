namespace Employee_Management_Alpha_1._0
{
    partial class UpdateInformation
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
            this.tbNewItemName = new System.Windows.Forms.TextBox();
            this.tbNewQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbNewPricePerUnit = new System.Windows.Forms.NumericUpDown();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.btnNewUpdate = new System.Windows.Forms.Button();
            this.lblCurrentItemInfo = new System.Windows.Forms.Label();
            this.tbNewCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPricePerUnit)).BeginInit();
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
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbNewItemName
            // 
            this.tbNewItemName.Location = new System.Drawing.Point(168, 47);
            this.tbNewItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewItemName.Name = "tbNewItemName";
            this.tbNewItemName.Size = new System.Drawing.Size(159, 22);
            this.tbNewItemName.TabIndex = 4;
            // 
            // tbNewQuantity
            // 
            this.tbNewQuantity.Location = new System.Drawing.Point(168, 79);
            this.tbNewQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewQuantity.Name = "tbNewQuantity";
            this.tbNewQuantity.Size = new System.Drawing.Size(160, 22);
            this.tbNewQuantity.TabIndex = 46;
            // 
            // tbNewPricePerUnit
            // 
            this.tbNewPricePerUnit.DecimalPlaces = 2;
            this.tbNewPricePerUnit.Location = new System.Drawing.Point(168, 111);
            this.tbNewPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewPricePerUnit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbNewPricePerUnit.Name = "tbNewPricePerUnit";
            this.tbNewPricePerUnit.Size = new System.Drawing.Size(160, 22);
            this.tbNewPricePerUnit.TabIndex = 47;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Location = new System.Drawing.Point(39, 144);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(68, 18);
            this.lblCategory.TabIndex = 49;
            this.lblCategory.Text = "Category";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblItemName.Location = new System.Drawing.Point(39, 48);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 18);
            this.lblItemName.TabIndex = 50;
            this.lblItemName.Text = "Item Name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(40, 79);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 18);
            this.Label4.TabIndex = 52;
            this.Label4.Text = "Quantity:";
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPricePerUnit.Location = new System.Drawing.Point(39, 111);
            this.lblPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(98, 18);
            this.lblPricePerUnit.TabIndex = 51;
            this.lblPricePerUnit.Text = "Price per unit:";
            // 
            // btnNewUpdate
            // 
            this.btnNewUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnNewUpdate.FlatAppearance.BorderSize = 0;
            this.btnNewUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUpdate.ForeColor = System.Drawing.Color.Silver;
            this.btnNewUpdate.Location = new System.Drawing.Point(398, 44);
            this.btnNewUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewUpdate.Name = "btnNewUpdate";
            this.btnNewUpdate.Size = new System.Drawing.Size(140, 57);
            this.btnNewUpdate.TabIndex = 53;
            this.btnNewUpdate.Text = "Update";
            this.btnNewUpdate.UseVisualStyleBackColor = false;
            this.btnNewUpdate.Click += new System.EventHandler(this.BtnNewUpdate_Click);
            // 
            // lblCurrentItemInfo
            // 
            this.lblCurrentItemInfo.AutoSize = true;
            this.lblCurrentItemInfo.Location = new System.Drawing.Point(33, 201);
            this.lblCurrentItemInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentItemInfo.Name = "lblCurrentItemInfo";
            this.lblCurrentItemInfo.Size = new System.Drawing.Size(116, 17);
            this.lblCurrentItemInfo.TabIndex = 54;
            this.lblCurrentItemInfo.Text = "Current item info:";
            // 
            // tbNewCategory
            // 
            this.tbNewCategory.Location = new System.Drawing.Point(168, 144);
            this.tbNewCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewCategory.Name = "tbNewCategory";
            this.tbNewCategory.Size = new System.Drawing.Size(159, 22);
            this.tbNewCategory.TabIndex = 55;
            // 
            // UpdateInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(580, 249);
            this.Controls.Add(this.tbNewCategory);
            this.Controls.Add(this.lblCurrentItemInfo);
            this.Controls.Add(this.btnNewUpdate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblPricePerUnit);
            this.Controls.Add(this.tbNewPricePerUnit);
            this.Controls.Add(this.tbNewQuantity);
            this.Controls.Add(this.tbNewItemName);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateInformation";
            this.Text = "UpdateInformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateInformation_FormClosing);
            this.Load += new System.EventHandler(this.UpdateInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbNewQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPricePerUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbNewItemName;
        private System.Windows.Forms.NumericUpDown tbNewQuantity;
        private System.Windows.Forms.NumericUpDown tbNewPricePerUnit;
        internal System.Windows.Forms.Label lblCategory;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblPricePerUnit;
        internal System.Windows.Forms.Button btnNewUpdate;
        public System.Windows.Forms.Label lblCurrentItemInfo;
        private System.Windows.Forms.TextBox tbNewCategory;
    }
}