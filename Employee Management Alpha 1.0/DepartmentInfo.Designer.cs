namespace Employee_Management_Alpha_1._0
{
    partial class DepartmentInfo
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
            this.lbDepartmentInfo = new System.Windows.Forms.ListBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbEmployeeInfo = new System.Windows.Forms.ListBox();
            this.btnAssignEmp = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.btnViewAllEmployees = new System.Windows.Forms.Button();
            this.btnViewEmployeesinDepartment = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDepartmentInfo
            // 
            this.lbDepartmentInfo.FormattingEnabled = true;
            this.lbDepartmentInfo.ItemHeight = 16;
            this.lbDepartmentInfo.Location = new System.Drawing.Point(70, 73);
            this.lbDepartmentInfo.Name = "lbDepartmentInfo";
            this.lbDepartmentInfo.Size = new System.Drawing.Size(346, 260);
            this.lbDepartmentInfo.TabIndex = 1;
            this.lbDepartmentInfo.Click += new System.EventHandler(this.lbDepartmentInfo_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateStatus.Location = new System.Drawing.Point(70, 339);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(161, 48);
            this.btnUpdateStatus.TabIndex = 2;
            this.btnUpdateStatus.Text = "Activate";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.BtnUpdateStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departments";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Employee_Management_Alpha_1._0.Properties.Resources.icons8_back_24;
            this.btnClose.Location = new System.Drawing.Point(12, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(255, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mark Inactive";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbEmployeeInfo
            // 
            this.lbEmployeeInfo.FormattingEnabled = true;
            this.lbEmployeeInfo.ItemHeight = 16;
            this.lbEmployeeInfo.Location = new System.Drawing.Point(454, 73);
            this.lbEmployeeInfo.Name = "lbEmployeeInfo";
            this.lbEmployeeInfo.Size = new System.Drawing.Size(341, 260);
            this.lbEmployeeInfo.TabIndex = 6;
            this.lbEmployeeInfo.SelectedIndexChanged += new System.EventHandler(this.LbEmployees_SelectedIndexChanged);
            // 
            // btnAssignEmp
            // 
            this.btnAssignEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAssignEmp.FlatAppearance.BorderSize = 0;
            this.btnAssignEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAssignEmp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAssignEmp.Location = new System.Drawing.Point(454, 412);
            this.btnAssignEmp.Name = "btnAssignEmp";
            this.btnAssignEmp.Size = new System.Drawing.Size(161, 48);
            this.btnAssignEmp.TabIndex = 8;
            this.btnAssignEmp.Text = "Assign";
            this.btnAssignEmp.UseVisualStyleBackColor = false;
            this.btnAssignEmp.Click += new System.EventHandler(this.BtnAssignEmp_Click);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmployees.Location = new System.Drawing.Point(450, 30);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(91, 20);
            this.lblEmployees.TabIndex = 10;
            this.lblEmployees.Text = "Employees";
            // 
            // btnViewAllEmployees
            // 
            this.btnViewAllEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnViewAllEmployees.FlatAppearance.BorderSize = 0;
            this.btnViewAllEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnViewAllEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewAllEmployees.Location = new System.Drawing.Point(634, 339);
            this.btnViewAllEmployees.Name = "btnViewAllEmployees";
            this.btnViewAllEmployees.Size = new System.Drawing.Size(161, 67);
            this.btnViewAllEmployees.TabIndex = 11;
            this.btnViewAllEmployees.Text = "View all employees";
            this.btnViewAllEmployees.UseVisualStyleBackColor = false;
            this.btnViewAllEmployees.Click += new System.EventHandler(this.btnViewAllEmployees_Click);
            // 
            // btnViewEmployeesinDepartment
            // 
            this.btnViewEmployeesinDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnViewEmployeesinDepartment.FlatAppearance.BorderSize = 0;
            this.btnViewEmployeesinDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployeesinDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnViewEmployeesinDepartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewEmployeesinDepartment.Location = new System.Drawing.Point(454, 339);
            this.btnViewEmployeesinDepartment.Name = "btnViewEmployeesinDepartment";
            this.btnViewEmployeesinDepartment.Size = new System.Drawing.Size(161, 67);
            this.btnViewEmployeesinDepartment.TabIndex = 12;
            this.btnViewEmployeesinDepartment.Text = "View employees in selected dep.";
            this.btnViewEmployeesinDepartment.UseVisualStyleBackColor = false;
            this.btnViewEmployeesinDepartment.Click += new System.EventHandler(this.btnViewEmployeesinDepartment_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUnassign.FlatAppearance.BorderSize = 0;
            this.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnassign.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUnassign.Location = new System.Drawing.Point(634, 412);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(161, 48);
            this.btnUnassign.TabIndex = 13;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = false;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // DepartmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(822, 488);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.btnViewEmployeesinDepartment);
            this.Controls.Add(this.btnViewAllEmployees);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.btnAssignEmp);
            this.Controls.Add(this.lbEmployeeInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.lbDepartmentInfo);
            this.Name = "DepartmentInfo";
            this.Text = "DepartmentInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbDepartmentInfo;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbEmployeeInfo;
        private System.Windows.Forms.Button btnAssignEmp;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button btnViewAllEmployees;
        private System.Windows.Forms.Button btnViewEmployeesinDepartment;
        private System.Windows.Forms.Button btnUnassign;
    }
}