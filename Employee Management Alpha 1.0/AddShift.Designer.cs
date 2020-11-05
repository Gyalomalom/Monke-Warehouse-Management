namespace Employee_Management_Alpha_1._0
{
    partial class AddShift
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
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.dtpShift = new System.Windows.Forms.DateTimePicker();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lbShifts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Employee_Management_Alpha_1._0.Properties.Resources.icons8_back_24;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 16;
            this.lbEmployees.Location = new System.Drawing.Point(318, 2);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(225, 436);
            this.lbEmployees.TabIndex = 30;
            this.lbEmployees.Click += new System.EventHandler(this.lbEmployees_Click);
            // 
            // dtpShift
            // 
            this.dtpShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShift.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShift.Location = new System.Drawing.Point(84, 46);
            this.dtpShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpShift.Name = "dtpShift";
            this.dtpShift.Size = new System.Drawing.Size(179, 22);
            this.dtpShift.TabIndex = 29;
            this.dtpShift.Value = new System.DateTime(2020, 6, 5, 0, 0, 0, 0);
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAddShift.FlatAppearance.BorderSize = 0;
            this.btnAddShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAddShift.ForeColor = System.Drawing.Color.Silver;
            this.btnAddShift.Location = new System.Drawing.Point(84, 221);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(179, 54);
            this.btnAddShift.TabIndex = 28;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDOB.Location = new System.Drawing.Point(81, 26);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(88, 17);
            this.lblDOB.TabIndex = 26;
            this.lblDOB.Text = "Date of shift:";
            // 
            // lbShifts
            // 
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.ItemHeight = 16;
            this.lbShifts.Location = new System.Drawing.Point(549, 1);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(225, 436);
            this.lbShifts.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Time of day:";
            // 
            // cbtod
            // 
            this.cbtod.DisplayMember = "Morning";
            this.cbtod.FormattingEnabled = true;
            this.cbtod.Items.AddRange(new object[] {
            "Morning",
            "Noon",
            "Evening"});
            this.cbtod.Location = new System.Drawing.Point(84, 106);
            this.cbtod.Name = "cbtod";
            this.cbtod.Size = new System.Drawing.Size(128, 24);
            this.cbtod.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(83, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Assigned employee ID:";
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(84, 176);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(128, 22);
            this.tbEmpID.TabIndex = 35;
            // 
            // AddShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbtod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbShifts);
            this.Controls.Add(this.lbEmployees);
            this.Controls.Add(this.dtpShift);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.btnClose);
            this.Name = "AddShift";
            this.Text = "AddShift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.DateTimePicker dtpShift;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ListBox lbShifts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmpID;
    }
}