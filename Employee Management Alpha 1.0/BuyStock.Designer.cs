namespace Employee_Management_Alpha_1._0
{
    partial class BuyStock
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
            this.lblAmountBuy = new System.Windows.Forms.Label();
            this.numUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.btnBuyStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbStockSalesInfo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.FormattingEnabled = true;
            this.lbStockInfo.Location = new System.Drawing.Point(9, 172);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(597, 212);
            this.lbStockInfo.TabIndex = 45;
            this.lbStockInfo.Click += new System.EventHandler(this.LbStockInfo_Click);
            // 
            // lblAmountBuy
            // 
            this.lblAmountBuy.AutoSize = true;
            this.lblAmountBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblAmountBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmountBuy.Location = new System.Drawing.Point(15, 29);
            this.lblAmountBuy.Name = "lblAmountBuy";
            this.lblAmountBuy.Size = new System.Drawing.Size(46, 13);
            this.lblAmountBuy.TabIndex = 54;
            this.lblAmountBuy.Text = "Amount:";
            // 
            // numUpDownAmount
            // 
            this.numUpDownAmount.Location = new System.Drawing.Point(67, 27);
            this.numUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownAmount.Name = "numUpDownAmount";
            this.numUpDownAmount.Size = new System.Drawing.Size(93, 20);
            this.numUpDownAmount.TabIndex = 53;
            this.numUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuyStock
            // 
            this.btnBuyStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnBuyStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuyStock.Location = new System.Drawing.Point(57, 117);
            this.btnBuyStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuyStock.Name = "btnBuyStock";
            this.btnBuyStock.Size = new System.Drawing.Size(174, 41);
            this.btnBuyStock.TabIndex = 52;
            this.btnBuyStock.Text = "Buy";
            this.btnBuyStock.UseVisualStyleBackColor = false;
            this.btnBuyStock.Click += new System.EventHandler(this.BtnBuyStock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(67, 53);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(93, 20);
            this.tbID.TabIndex = 55;
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
            this.btnClose.TabIndex = 57;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbStockSalesInfo
            // 
            this.lbStockSalesInfo.FormattingEnabled = true;
            this.lbStockSalesInfo.Location = new System.Drawing.Point(430, 15);
            this.lbStockSalesInfo.Name = "lbStockSalesInfo";
            this.lbStockSalesInfo.Size = new System.Drawing.Size(176, 134);
            this.lbStockSalesInfo.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(364, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Top Selling";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.Controls.Add(this.lblAmountBuy);
            this.groupBox1.Controls.Add(this.numUpDownAmount);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(57, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(174, 91);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details:";
            // 
            // BuyStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStockSalesInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBuyStock);
            this.Controls.Add(this.lbStockInfo);
            this.Name = "BuyStock";
            this.Text = "BuyStock";
            this.Load += new System.EventHandler(this.BuyStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStockInfo;
        private System.Windows.Forms.Label lblAmountBuy;
        private System.Windows.Forms.NumericUpDown numUpDownAmount;
        private System.Windows.Forms.Button btnBuyStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbStockSalesInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}