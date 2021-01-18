namespace Employee_Management_Alpha_1._0
{
    partial class StockRequest
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
            this.lbLowQuantityItems = new System.Windows.Forms.ListBox();
            this.btnRequestStock = new System.Windows.Forms.Button();
            this.lbRequests = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAmountBuy = new System.Windows.Forms.Label();
            this.numUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLowQuantityItems
            // 
            this.lbLowQuantityItems.FormattingEnabled = true;
            this.lbLowQuantityItems.ItemHeight = 16;
            this.lbLowQuantityItems.Location = new System.Drawing.Point(12, 185);
            this.lbLowQuantityItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLowQuantityItems.Name = "lbLowQuantityItems";
            this.lbLowQuantityItems.Size = new System.Drawing.Size(532, 276);
            this.lbLowQuantityItems.TabIndex = 59;
            this.lbLowQuantityItems.Click += new System.EventHandler(this.LbLowQuantityItems_Click);
            // 
            // btnRequestStock
            // 
            this.btnRequestStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRequestStock.FlatAppearance.BorderSize = 0;
            this.btnRequestStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRequestStock.Location = new System.Drawing.Point(619, 31);
            this.btnRequestStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequestStock.Name = "btnRequestStock";
            this.btnRequestStock.Size = new System.Drawing.Size(185, 70);
            this.btnRequestStock.TabIndex = 60;
            this.btnRequestStock.Text = "Send Stock request";
            this.btnRequestStock.UseVisualStyleBackColor = false;
            this.btnRequestStock.Click += new System.EventHandler(this.BtnBuyStock_Click);
            // 
            // lbRequests
            // 
            this.lbRequests.FormattingEnabled = true;
            this.lbRequests.ItemHeight = 16;
            this.lbRequests.Location = new System.Drawing.Point(573, 185);
            this.lbRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.Size = new System.Drawing.Size(231, 276);
            this.lbRequests.TabIndex = 62;
            this.lbRequests.SelectedIndexChanged += new System.EventHandler(this.LbRequests_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(570, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Pending requests:";
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
            this.btnClose.TabIndex = 58;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.Controls.Add(this.lblAmountBuy);
            this.groupBox1.Controls.Add(this.numUpDownAmount);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(77, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(232, 112);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details:";
            // 
            // lblAmountBuy
            // 
            this.lblAmountBuy.AutoSize = true;
            this.lblAmountBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lblAmountBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmountBuy.Location = new System.Drawing.Point(20, 36);
            this.lblAmountBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountBuy.Name = "lblAmountBuy";
            this.lblAmountBuy.Size = new System.Drawing.Size(60, 17);
            this.lblAmountBuy.TabIndex = 54;
            this.lblAmountBuy.Text = "Amount:";
            // 
            // numUpDownAmount
            // 
            this.numUpDownAmount.Location = new System.Drawing.Point(89, 33);
            this.numUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownAmount.Name = "numUpDownAmount";
            this.numUpDownAmount.Size = new System.Drawing.Size(124, 22);
            this.numUpDownAmount.TabIndex = 53;
            this.numUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(89, 65);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(123, 22);
            this.tbID.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(292, 148);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 33);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Search items";
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(101, 153);
            this.tbSearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(181, 22);
            this.tbSearchBar.TabIndex = 71;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.TbSearchBar_TextChanged);
            // 
            // StockRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(821, 487);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRequests);
            this.Controls.Add(this.btnRequestStock);
            this.Controls.Add(this.lbLowQuantityItems);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockRequest";
            this.Text = "StockRequest";
            this.Load += new System.EventHandler(this.StockRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbLowQuantityItems;
        private System.Windows.Forms.Button btnRequestStock;
        private System.Windows.Forms.ListBox lbRequests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAmountBuy;
        private System.Windows.Forms.NumericUpDown numUpDownAmount;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSearchBar;
    }
}