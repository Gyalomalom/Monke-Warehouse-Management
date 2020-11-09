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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbLowQuantityItems = new System.Windows.Forms.ListBox();
            this.btnRequestStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRequests = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.btnClose.TabIndex = 58;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lbLowQuantityItems
            // 
            this.lbLowQuantityItems.FormattingEnabled = true;
            this.lbLowQuantityItems.Location = new System.Drawing.Point(32, 153);
            this.lbLowQuantityItems.Name = "lbLowQuantityItems";
            this.lbLowQuantityItems.Size = new System.Drawing.Size(286, 225);
            this.lbLowQuantityItems.TabIndex = 59;
            this.lbLowQuantityItems.Click += new System.EventHandler(this.LbLowQuantityItems_Click);
            // 
            // btnRequestStock
            // 
            this.btnRequestStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRequestStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRequestStock.Location = new System.Drawing.Point(179, 60);
            this.btnRequestStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequestStock.Name = "btnRequestStock";
            this.btnRequestStock.Size = new System.Drawing.Size(139, 57);
            this.btnRequestStock.TabIndex = 60;
            this.btnRequestStock.Text = "Send Stock request";
            this.btnRequestStock.UseVisualStyleBackColor = false;
            this.btnRequestStock.Click += new System.EventHandler(this.BtnBuyStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(32, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(143, 57);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(37, 18);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(93, 20);
            this.tbID.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID:";
            // 
            // lbRequests
            // 
            this.lbRequests.FormattingEnabled = true;
            this.lbRequests.Location = new System.Drawing.Point(334, 153);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.Size = new System.Drawing.Size(250, 225);
            this.lbRequests.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(331, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Stock requests:";
            // 
            // StockRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRequests);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRequestStock);
            this.Controls.Add(this.lbLowQuantityItems);
            this.Controls.Add(this.btnClose);
            this.Name = "StockRequest";
            this.Text = "StockRequest";
            this.Load += new System.EventHandler(this.StockRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbLowQuantityItems;
        private System.Windows.Forms.Button btnRequestStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRequests;
        private System.Windows.Forms.Label label3;
    }
}