﻿namespace Employee_Management_Alpha_1._0
{
    partial class RemoveStock
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
            this.btnRemoveStockItem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.FormattingEnabled = true;
            this.lbStockInfo.Location = new System.Drawing.Point(9, 172);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(597, 212);
            this.lbStockInfo.TabIndex = 44;
            this.lbStockInfo.Click += new System.EventHandler(this.LbStockInfo_Click);
            // 
            // btnRemoveStockItem
            // 
            this.btnRemoveStockItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRemoveStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStockItem.ForeColor = System.Drawing.Color.Silver;
            this.btnRemoveStockItem.Location = new System.Drawing.Point(484, 63);
            this.btnRemoveStockItem.Name = "btnRemoveStockItem";
            this.btnRemoveStockItem.Size = new System.Drawing.Size(107, 59);
            this.btnRemoveStockItem.TabIndex = 45;
            this.btnRemoveStockItem.Text = "Remove";
            this.btnRemoveStockItem.UseVisualStyleBackColor = false;
            this.btnRemoveStockItem.Click += new System.EventHandler(this.BtnRemoveStockItem_Click);
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
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(484, 129);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(107, 20);
            this.tbID.TabIndex = 46;
            this.tbID.TextChanged += new System.EventHandler(this.TbID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // RemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnRemoveStockItem);
            this.Controls.Add(this.lbStockInfo);
            this.Controls.Add(this.btnClose);
            this.Name = "RemoveStock";
            this.Text = "RemoveStock";
            this.Load += new System.EventHandler(this.RemoveStock_Load);
            this.Shown += new System.EventHandler(this.RemoveStock_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbStockInfo;
        internal System.Windows.Forms.Button btnRemoveStockItem;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
    }
}