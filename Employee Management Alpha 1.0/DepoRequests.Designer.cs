namespace ClockinApp
{
    partial class DepoRequests
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
            this.lbRequests = new System.Windows.Forms.ListBox();
            this.btnAcceptRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRequests
            // 
            this.lbRequests.FormattingEnabled = true;
            this.lbRequests.Location = new System.Drawing.Point(11, 151);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.Size = new System.Drawing.Size(582, 225);
            this.lbRequests.TabIndex = 67;
            this.lbRequests.Click += new System.EventHandler(this.LbRequests_Click);
            // 
            // btnAcceptRequest
            // 
            this.btnAcceptRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAcceptRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcceptRequest.Location = new System.Drawing.Point(454, 44);
            this.btnAcceptRequest.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptRequest.Name = "btnAcceptRequest";
            this.btnAcceptRequest.Size = new System.Drawing.Size(139, 57);
            this.btnAcceptRequest.TabIndex = 68;
            this.btnAcceptRequest.Text = "Accept Request";
            this.btnAcceptRequest.UseVisualStyleBackColor = false;
            this.btnAcceptRequest.Click += new System.EventHandler(this.BtnAcceptRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Pending requests:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Amount:";
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
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(67, 53);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(93, 20);
            this.tbID.TabIndex = 55;
            this.tbID.TextChanged += new System.EventHandler(this.TbID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(40, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numUpDownAmount);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(77, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(174, 91);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item details:";
            // 
            // DepoRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRequests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceptRequest);
            this.Name = "DepoRequests";
            this.Text = "q";
            this.Load += new System.EventHandler(this.DepoRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRequests;
        private System.Windows.Forms.Button btnAcceptRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownAmount;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}