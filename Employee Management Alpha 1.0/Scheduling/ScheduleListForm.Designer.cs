namespace Employee_Management_Alpha_1._0
{
    partial class ScheduleListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleListForm));
            this.lbAssignedEmp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.lbAvailableEmployees = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblIndicatorDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAssignedEmp
            // 
            this.lbAssignedEmp.FormattingEnabled = true;
            this.lbAssignedEmp.ItemHeight = 16;
            this.lbAssignedEmp.Location = new System.Drawing.Point(13, 141);
            this.lbAssignedEmp.Name = "lbAssignedEmp";
            this.lbAssignedEmp.Size = new System.Drawing.Size(294, 356);
            this.lbAssignedEmp.TabIndex = 0;
            this.lbAssignedEmp.Click += new System.EventHandler(this.lbAssignedEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assigned employees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(333, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available employees:";
            // 
            // btnUnassign
            // 
            this.btnUnassign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnUnassign.FlatAppearance.BorderSize = 0;
            this.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnassign.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUnassign.Location = new System.Drawing.Point(12, 503);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(142, 36);
            this.btnUnassign.TabIndex = 3;
            this.btnUnassign.Text = "Unassign";
            this.btnUnassign.UseVisualStyleBackColor = false;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // lbAvailableEmployees
            // 
            this.lbAvailableEmployees.FormattingEnabled = true;
            this.lbAvailableEmployees.ItemHeight = 16;
            this.lbAvailableEmployees.Location = new System.Drawing.Point(336, 141);
            this.lbAvailableEmployees.Name = "lbAvailableEmployees";
            this.lbAvailableEmployees.Size = new System.Drawing.Size(294, 356);
            this.lbAvailableEmployees.TabIndex = 4;
            this.lbAvailableEmployees.Click += new System.EventHandler(this.lbEmployees_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAssign.Location = new System.Drawing.Point(336, 503);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(138, 36);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblIndicatorDate
            // 
            this.lblIndicatorDate.AutoSize = true;
            this.lblIndicatorDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblIndicatorDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIndicatorDate.Location = new System.Drawing.Point(15, 13);
            this.lblIndicatorDate.Name = "lblIndicatorDate";
            this.lblIndicatorDate.Size = new System.Drawing.Size(30, 26);
            this.lblIndicatorDate.TabIndex = 6;
            this.lblIndicatorDate.Text = "///";
            // 
            // ScheduleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(670, 567);
            this.Controls.Add(this.lblIndicatorDate);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lbAvailableEmployees);
            this.Controls.Add(this.btnUnassign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAssignedEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleListForm";
            this.Text = "Shift overview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScheduleListForm_FormClosing);
            this.Load += new System.EventHandler(this.ScheduleListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAssignedEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.ListBox lbAvailableEmployees;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblIndicatorDate;
    }
}