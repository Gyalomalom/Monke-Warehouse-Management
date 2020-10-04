namespace Employee_Management_Alpha_1._0
{
    partial class RemoveDepartment
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
            this.btnRemoveDep = new System.Windows.Forms.Button();
            this.lbDepartmentInfo = new System.Windows.Forms.ListBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemoveDep
            // 
            this.btnRemoveDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnRemoveDep.FlatAppearance.BorderSize = 0;
            this.btnRemoveDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveDep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveDep.Location = new System.Drawing.Point(510, 80);
            this.btnRemoveDep.Name = "btnRemoveDep";
            this.btnRemoveDep.Size = new System.Drawing.Size(202, 48);
            this.btnRemoveDep.TabIndex = 0;
            this.btnRemoveDep.Text = "Remove";
            this.btnRemoveDep.UseVisualStyleBackColor = false;
            this.btnRemoveDep.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbDepartmentInfo
            // 
            this.lbDepartmentInfo.FormattingEnabled = true;
            this.lbDepartmentInfo.ItemHeight = 16;
            this.lbDepartmentInfo.Location = new System.Drawing.Point(101, 80);
            this.lbDepartmentInfo.Name = "lbDepartmentInfo";
            this.lbDepartmentInfo.Size = new System.Drawing.Size(349, 356);
            this.lbDepartmentInfo.TabIndex = 1;
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartments.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDepartments.Location = new System.Drawing.Point(97, 37);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(106, 20);
            this.lblDepartments.TabIndex = 2;
            this.lblDepartments.Text = "Departments";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Employee_Management_Alpha_1._0.Properties.Resources.icons8_back_24;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // RemoveDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(822, 488);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDepartments);
            this.Controls.Add(this.lbDepartmentInfo);
            this.Controls.Add(this.btnRemoveDep);
            this.Name = "RemoveDepartment";
            this.Text = "RemoveDepartment";
            this.Load += new System.EventHandler(this.RemoveDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveDep;
        private System.Windows.Forms.ListBox lbDepartmentInfo;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Button btnClose;
    }
}