namespace Employee_Management_Alpha_1._0
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
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStockInfo
            // 
            this.lbStockInfo.FormattingEnabled = true;
            this.lbStockInfo.ItemHeight = 16;
            this.lbStockInfo.Location = new System.Drawing.Point(12, 212);
            this.lbStockInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStockInfo.Name = "lbStockInfo";
            this.lbStockInfo.Size = new System.Drawing.Size(795, 260);
            this.lbStockInfo.TabIndex = 44;
            this.lbStockInfo.Click += new System.EventHandler(this.LbStockInfo_Click);
            // 
            // btnRemoveStockItem
            // 
            this.btnRemoveStockItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRemoveStockItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveStockItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStockItem.ForeColor = System.Drawing.Color.Silver;
            this.btnRemoveStockItem.Location = new System.Drawing.Point(666, 90);
            this.btnRemoveStockItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveStockItem.Name = "btnRemoveStockItem";
            this.btnRemoveStockItem.Size = new System.Drawing.Size(143, 73);
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
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(666, 171);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(141, 22);
            this.tbID.TabIndex = 46;
            this.tbID.TextChanged += new System.EventHandler(this.TbID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(104, 167);
            this.tbSearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(181, 22);
            this.tbSearchBar.TabIndex = 48;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Search Bar";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(293, 162);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 31);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // RemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(821, 487);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnRemoveStockItem);
            this.Controls.Add(this.lbStockInfo);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnSearch;
    }
}