namespace Employee_Management_Alpha_1._0
{
    partial class Scheduler
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
            this.gbGeneralScheduler = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSunday = new System.Windows.Forms.GroupBox();
            this.lblDateSun = new System.Windows.Forms.Label();
            this.pnlEvenSunday = new System.Windows.Forms.Panel();
            this.pnlNoonSunday = new System.Windows.Forms.Panel();
            this.pnlMornSunday = new System.Windows.Forms.Panel();
            this.gbSaturday = new System.Windows.Forms.GroupBox();
            this.lblDateSat = new System.Windows.Forms.Label();
            this.pnlEvenSaturday = new System.Windows.Forms.Panel();
            this.pnlNoonSaturday = new System.Windows.Forms.Panel();
            this.pnlMornSaturday = new System.Windows.Forms.Panel();
            this.gbFriday = new System.Windows.Forms.GroupBox();
            this.lblDateFri = new System.Windows.Forms.Label();
            this.pnlEvenFriday = new System.Windows.Forms.Panel();
            this.pnlNoonFriday = new System.Windows.Forms.Panel();
            this.pnlMornFriday = new System.Windows.Forms.Panel();
            this.gbThursday = new System.Windows.Forms.GroupBox();
            this.lblDateThu = new System.Windows.Forms.Label();
            this.pnlEvenThursday = new System.Windows.Forms.Panel();
            this.pnlNoonThursday = new System.Windows.Forms.Panel();
            this.pnlMornThursday = new System.Windows.Forms.Panel();
            this.gbWednesday = new System.Windows.Forms.GroupBox();
            this.lblDateWed = new System.Windows.Forms.Label();
            this.pnlEvenWednesday = new System.Windows.Forms.Panel();
            this.pnlNoonWednesday = new System.Windows.Forms.Panel();
            this.pnlMornWednesday = new System.Windows.Forms.Panel();
            this.gbTuesday = new System.Windows.Forms.GroupBox();
            this.lblDateTue = new System.Windows.Forms.Label();
            this.pnlEvenTuesday = new System.Windows.Forms.Panel();
            this.pnlNoonTuesday = new System.Windows.Forms.Panel();
            this.pnlMornTuesday = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCalWeek = new System.Windows.Forms.ComboBox();
            this.gbMonday = new System.Windows.Forms.GroupBox();
            this.lblDateMon = new System.Windows.Forms.Label();
            this.pnlEvenMonday = new System.Windows.Forms.Panel();
            this.pnlNoonMonday = new System.Windows.Forms.Panel();
            this.pnlMornMonday = new System.Windows.Forms.Panel();
            this.pnlDates = new System.Windows.Forms.Panel();
            this.btnLoadSchedule = new System.Windows.Forms.Button();
            this.gbGeneralScheduler.SuspendLayout();
            this.gbSunday.SuspendLayout();
            this.gbSaturday.SuspendLayout();
            this.gbFriday.SuspendLayout();
            this.gbThursday.SuspendLayout();
            this.gbWednesday.SuspendLayout();
            this.gbTuesday.SuspendLayout();
            this.gbMonday.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGeneralScheduler
            // 
            this.gbGeneralScheduler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbGeneralScheduler.Controls.Add(this.btnLoadSchedule);
            this.gbGeneralScheduler.Controls.Add(this.label6);
            this.gbGeneralScheduler.Controls.Add(this.cbYear);
            this.gbGeneralScheduler.Controls.Add(this.cbDepartment);
            this.gbGeneralScheduler.Controls.Add(this.label5);
            this.gbGeneralScheduler.Controls.Add(this.label4);
            this.gbGeneralScheduler.Controls.Add(this.label3);
            this.gbGeneralScheduler.Controls.Add(this.label2);
            this.gbGeneralScheduler.Controls.Add(this.label1);
            this.gbGeneralScheduler.Controls.Add(this.cbCalWeek);
            this.gbGeneralScheduler.Controls.Add(this.pnlDates);
            this.gbGeneralScheduler.Location = new System.Drawing.Point(6, 16);
            this.gbGeneralScheduler.Name = "gbGeneralScheduler";
            this.gbGeneralScheduler.Size = new System.Drawing.Size(1366, 550);
            this.gbGeneralScheduler.TabIndex = 0;
            this.gbGeneralScheduler.TabStop = false;
            this.gbGeneralScheduler.Text = "Scheduler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Year:";
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbYear.Location = new System.Drawing.Point(191, 90);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(64, 24);
            this.cbYear.TabIndex = 12;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Depo",
            "HR",
            "Admin"});
            this.cbDepartment.Location = new System.Drawing.Point(162, 28);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(93, 24);
            this.cbDepartment.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Afternoon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Evening:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Morning:";
            // 
            // gbSunday
            // 
            this.gbSunday.BackColor = System.Drawing.SystemColors.Control;
            this.gbSunday.Controls.Add(this.lblDateSun);
            this.gbSunday.Controls.Add(this.pnlEvenSunday);
            this.gbSunday.Controls.Add(this.pnlNoonSunday);
            this.gbSunday.Controls.Add(this.pnlMornSunday);
            this.gbSunday.Location = new System.Drawing.Point(1118, 11);
            this.gbSunday.Name = "gbSunday";
            this.gbSunday.Size = new System.Drawing.Size(178, 390);
            this.gbSunday.TabIndex = 2;
            this.gbSunday.TabStop = false;
            this.gbSunday.Text = "Sunday";
            // 
            // lblDateSun
            // 
            this.lblDateSun.AutoSize = true;
            this.lblDateSun.Location = new System.Drawing.Point(6, 24);
            this.lblDateSun.Name = "lblDateSun";
            this.lblDateSun.Size = new System.Drawing.Size(54, 17);
            this.lblDateSun.TabIndex = 14;
            this.lblDateSun.Text = "label12";
            // 
            // pnlEvenSunday
            // 
            this.pnlEvenSunday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlEvenSunday.Location = new System.Drawing.Point(6, 259);
            this.pnlEvenSunday.Name = "pnlEvenSunday";
            this.pnlEvenSunday.Size = new System.Drawing.Size(164, 100);
            this.pnlEvenSunday.TabIndex = 1;
            this.pnlEvenSunday.Click += new System.EventHandler(this.pnlEvenSunday_Click);
            // 
            // pnlNoonSunday
            // 
            this.pnlNoonSunday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNoonSunday.Location = new System.Drawing.Point(6, 153);
            this.pnlNoonSunday.Name = "pnlNoonSunday";
            this.pnlNoonSunday.Size = new System.Drawing.Size(164, 100);
            this.pnlNoonSunday.TabIndex = 1;
            this.pnlNoonSunday.Click += new System.EventHandler(this.pnlNoonSunday_Click);
            // 
            // pnlMornSunday
            // 
            this.pnlMornSunday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMornSunday.Location = new System.Drawing.Point(7, 47);
            this.pnlMornSunday.Name = "pnlMornSunday";
            this.pnlMornSunday.Size = new System.Drawing.Size(163, 100);
            this.pnlMornSunday.TabIndex = 0;
            this.pnlMornSunday.Click += new System.EventHandler(this.pnlMornSunday_Click);
            // 
            // gbSaturday
            // 
            this.gbSaturday.BackColor = System.Drawing.SystemColors.Control;
            this.gbSaturday.Controls.Add(this.lblDateSat);
            this.gbSaturday.Controls.Add(this.pnlEvenSaturday);
            this.gbSaturday.Controls.Add(this.pnlNoonSaturday);
            this.gbSaturday.Controls.Add(this.pnlMornSaturday);
            this.gbSaturday.Location = new System.Drawing.Point(933, 11);
            this.gbSaturday.Name = "gbSaturday";
            this.gbSaturday.Size = new System.Drawing.Size(178, 390);
            this.gbSaturday.TabIndex = 2;
            this.gbSaturday.TabStop = false;
            this.gbSaturday.Text = "Saturday";
            // 
            // lblDateSat
            // 
            this.lblDateSat.AutoSize = true;
            this.lblDateSat.Location = new System.Drawing.Point(6, 24);
            this.lblDateSat.Name = "lblDateSat";
            this.lblDateSat.Size = new System.Drawing.Size(54, 17);
            this.lblDateSat.TabIndex = 13;
            this.lblDateSat.Text = "label11";
            // 
            // pnlEvenSaturday
            // 
            this.pnlEvenSaturday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlEvenSaturday.Location = new System.Drawing.Point(6, 259);
            this.pnlEvenSaturday.Name = "pnlEvenSaturday";
            this.pnlEvenSaturday.Size = new System.Drawing.Size(164, 100);
            this.pnlEvenSaturday.TabIndex = 1;
            this.pnlEvenSaturday.Click += new System.EventHandler(this.pnlEvenSaturday_Click);
            // 
            // pnlNoonSaturday
            // 
            this.pnlNoonSaturday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNoonSaturday.Location = new System.Drawing.Point(6, 153);
            this.pnlNoonSaturday.Name = "pnlNoonSaturday";
            this.pnlNoonSaturday.Size = new System.Drawing.Size(164, 100);
            this.pnlNoonSaturday.TabIndex = 1;
            this.pnlNoonSaturday.Click += new System.EventHandler(this.pnlNoonSaturday_Click);
            // 
            // pnlMornSaturday
            // 
            this.pnlMornSaturday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMornSaturday.Location = new System.Drawing.Point(7, 47);
            this.pnlMornSaturday.Name = "pnlMornSaturday";
            this.pnlMornSaturday.Size = new System.Drawing.Size(163, 100);
            this.pnlMornSaturday.TabIndex = 0;
            this.pnlMornSaturday.Click += new System.EventHandler(this.pnlMornSaturday_Click);
            // 
            // gbFriday
            // 
            this.gbFriday.BackColor = System.Drawing.SystemColors.Control;
            this.gbFriday.Controls.Add(this.lblDateFri);
            this.gbFriday.Controls.Add(this.pnlEvenFriday);
            this.gbFriday.Controls.Add(this.pnlNoonFriday);
            this.gbFriday.Controls.Add(this.pnlMornFriday);
            this.gbFriday.Location = new System.Drawing.Point(749, 11);
            this.gbFriday.Name = "gbFriday";
            this.gbFriday.Size = new System.Drawing.Size(178, 390);
            this.gbFriday.TabIndex = 6;
            this.gbFriday.TabStop = false;
            this.gbFriday.Text = "Friday";
            // 
            // lblDateFri
            // 
            this.lblDateFri.AutoSize = true;
            this.lblDateFri.Location = new System.Drawing.Point(6, 24);
            this.lblDateFri.Name = "lblDateFri";
            this.lblDateFri.Size = new System.Drawing.Size(54, 17);
            this.lblDateFri.TabIndex = 12;
            this.lblDateFri.Text = "label10";
            // 
            // pnlEvenFriday
            // 
            this.pnlEvenFriday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlEvenFriday.Location = new System.Drawing.Point(6, 259);
            this.pnlEvenFriday.Name = "pnlEvenFriday";
            this.pnlEvenFriday.Size = new System.Drawing.Size(164, 100);
            this.pnlEvenFriday.TabIndex = 1;
            this.pnlEvenFriday.Click += new System.EventHandler(this.pnlEvenFriday_Click);
            // 
            // pnlNoonFriday
            // 
            this.pnlNoonFriday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNoonFriday.Location = new System.Drawing.Point(6, 153);
            this.pnlNoonFriday.Name = "pnlNoonFriday";
            this.pnlNoonFriday.Size = new System.Drawing.Size(164, 100);
            this.pnlNoonFriday.TabIndex = 1;
            this.pnlNoonFriday.Click += new System.EventHandler(this.pnlNoonFriday_Click);
            // 
            // pnlMornFriday
            // 
            this.pnlMornFriday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMornFriday.Location = new System.Drawing.Point(7, 47);
            this.pnlMornFriday.Name = "pnlMornFriday";
            this.pnlMornFriday.Size = new System.Drawing.Size(163, 100);
            this.pnlMornFriday.TabIndex = 0;
            this.pnlMornFriday.Click += new System.EventHandler(this.pnlMornFriday_Click);
            // 
            // gbThursday
            // 
            this.gbThursday.BackColor = System.Drawing.SystemColors.Control;
            this.gbThursday.Controls.Add(this.lblDateThu);
            this.gbThursday.Controls.Add(this.pnlEvenThursday);
            this.gbThursday.Controls.Add(this.pnlNoonThursday);
            this.gbThursday.Controls.Add(this.pnlMornThursday);
            this.gbThursday.Location = new System.Drawing.Point(565, 11);
            this.gbThursday.Name = "gbThursday";
            this.gbThursday.Size = new System.Drawing.Size(178, 390);
            this.gbThursday.TabIndex = 5;
            this.gbThursday.TabStop = false;
            this.gbThursday.Text = "Thursday";
            // 
            // lblDateThu
            // 
            this.lblDateThu.AutoSize = true;
            this.lblDateThu.Location = new System.Drawing.Point(10, 27);
            this.lblDateThu.Name = "lblDateThu";
            this.lblDateThu.Size = new System.Drawing.Size(46, 17);
            this.lblDateThu.TabIndex = 12;
            this.lblDateThu.Text = "label9";
            // 
            // pnlEvenThursday
            // 
            this.pnlEvenThursday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlEvenThursday.Location = new System.Drawing.Point(6, 259);
            this.pnlEvenThursday.Name = "pnlEvenThursday";
            this.pnlEvenThursday.Size = new System.Drawing.Size(164, 100);
            this.pnlEvenThursday.TabIndex = 1;
            this.pnlEvenThursday.Click += new System.EventHandler(this.pnlEvenThursday_Click);
            // 
            // pnlNoonThursday
            // 
            this.pnlNoonThursday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNoonThursday.Location = new System.Drawing.Point(6, 153);
            this.pnlNoonThursday.Name = "pnlNoonThursday";
            this.pnlNoonThursday.Size = new System.Drawing.Size(164, 100);
            this.pnlNoonThursday.TabIndex = 1;
            this.pnlNoonThursday.Click += new System.EventHandler(this.pnlNoonThursday_Click);
            // 
            // pnlMornThursday
            // 
            this.pnlMornThursday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMornThursday.Location = new System.Drawing.Point(7, 47);
            this.pnlMornThursday.Name = "pnlMornThursday";
            this.pnlMornThursday.Size = new System.Drawing.Size(163, 100);
            this.pnlMornThursday.TabIndex = 0;
            this.pnlMornThursday.Click += new System.EventHandler(this.pnlMornThursday_Click);
            // 
            // gbWednesday
            // 
            this.gbWednesday.BackColor = System.Drawing.SystemColors.Control;
            this.gbWednesday.Controls.Add(this.lblDateWed);
            this.gbWednesday.Controls.Add(this.pnlEvenWednesday);
            this.gbWednesday.Controls.Add(this.pnlNoonWednesday);
            this.gbWednesday.Controls.Add(this.pnlMornWednesday);
            this.gbWednesday.Location = new System.Drawing.Point(381, 11);
            this.gbWednesday.Name = "gbWednesday";
            this.gbWednesday.Size = new System.Drawing.Size(178, 390);
            this.gbWednesday.TabIndex = 2;
            this.gbWednesday.TabStop = false;
            this.gbWednesday.Text = "Wednesday";
            // 
            // lblDateWed
            // 
            this.lblDateWed.AutoSize = true;
            this.lblDateWed.Location = new System.Drawing.Point(6, 27);
            this.lblDateWed.Name = "lblDateWed";
            this.lblDateWed.Size = new System.Drawing.Size(46, 17);
            this.lblDateWed.TabIndex = 4;
            this.lblDateWed.Text = "label8";
            // 
            // pnlEvenWednesday
            // 
            this.pnlEvenWednesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlEvenWednesday.Location = new System.Drawing.Point(6, 259);
            this.pnlEvenWednesday.Name = "pnlEvenWednesday";
            this.pnlEvenWednesday.Size = new System.Drawing.Size(164, 100);
            this.pnlEvenWednesday.TabIndex = 1;
            this.pnlEvenWednesday.Click += new System.EventHandler(this.pnlEvenWednesday_Click);
            // 
            // pnlNoonWednesday
            // 
            this.pnlNoonWednesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNoonWednesday.Location = new System.Drawing.Point(6, 153);
            this.pnlNoonWednesday.Name = "pnlNoonWednesday";
            this.pnlNoonWednesday.Size = new System.Drawing.Size(164, 100);
            this.pnlNoonWednesday.TabIndex = 1;
            this.pnlNoonWednesday.Click += new System.EventHandler(this.pnlNoonWednesday_Click);
            // 
            // pnlMornWednesday
            // 
            this.pnlMornWednesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMornWednesday.Location = new System.Drawing.Point(7, 47);
            this.pnlMornWednesday.Name = "pnlMornWednesday";
            this.pnlMornWednesday.Size = new System.Drawing.Size(163, 100);
            this.pnlMornWednesday.TabIndex = 0;
            this.pnlMornWednesday.Click += new System.EventHandler(this.pnlMornWednesday_Click);
            // 
            // gbTuesday
            // 
            this.gbTuesday.BackColor = System.Drawing.SystemColors.Control;
            this.gbTuesday.Controls.Add(this.lblDateTue);
            this.gbTuesday.Controls.Add(this.pnlEvenTuesday);
            this.gbTuesday.Controls.Add(this.pnlNoonTuesday);
            this.gbTuesday.Controls.Add(this.pnlMornTuesday);
            this.gbTuesday.Location = new System.Drawing.Point(197, 11);
            this.gbTuesday.Name = "gbTuesday";
            this.gbTuesday.Size = new System.Drawing.Size(178, 390);
            this.gbTuesday.TabIndex = 2;
            this.gbTuesday.TabStop = false;
            this.gbTuesday.Text = "Tuesday";
            // 
            // lblDateTue
            // 
            this.lblDateTue.AutoSize = true;
            this.lblDateTue.Location = new System.Drawing.Point(6, 24);
            this.lblDateTue.Name = "lblDateTue";
            this.lblDateTue.Size = new System.Drawing.Size(46, 17);
            this.lblDateTue.TabIndex = 3;
            this.lblDateTue.Text = "label7";
            // 
            // pnlEvenTuesday
            // 
            this.pnlEvenTuesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlEvenTuesday.Location = new System.Drawing.Point(6, 259);
            this.pnlEvenTuesday.Name = "pnlEvenTuesday";
            this.pnlEvenTuesday.Size = new System.Drawing.Size(164, 100);
            this.pnlEvenTuesday.TabIndex = 1;
            this.pnlEvenTuesday.Click += new System.EventHandler(this.pnlEvenTuesday_Click);
            // 
            // pnlNoonTuesday
            // 
            this.pnlNoonTuesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNoonTuesday.Location = new System.Drawing.Point(6, 153);
            this.pnlNoonTuesday.Name = "pnlNoonTuesday";
            this.pnlNoonTuesday.Size = new System.Drawing.Size(164, 100);
            this.pnlNoonTuesday.TabIndex = 1;
            this.pnlNoonTuesday.Click += new System.EventHandler(this.pnlNoonTuesday_Click);
            // 
            // pnlMornTuesday
            // 
            this.pnlMornTuesday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMornTuesday.Location = new System.Drawing.Point(7, 47);
            this.pnlMornTuesday.Name = "pnlMornTuesday";
            this.pnlMornTuesday.Size = new System.Drawing.Size(163, 100);
            this.pnlMornTuesday.TabIndex = 0;
            this.pnlMornTuesday.Click += new System.EventHandler(this.pnlMornTuesday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calendar week:";
            // 
            // cbCalWeek
            // 
            this.cbCalWeek.FormattingEnabled = true;
            this.cbCalWeek.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52"});
            this.cbCalWeek.Location = new System.Drawing.Point(191, 61);
            this.cbCalWeek.Name = "cbCalWeek";
            this.cbCalWeek.Size = new System.Drawing.Size(64, 24);
            this.cbCalWeek.TabIndex = 3;
            this.cbCalWeek.SelectedIndexChanged += new System.EventHandler(this.cbCalWeek_SelectedIndexChanged);
            // 
            // gbMonday
            // 
            this.gbMonday.BackColor = System.Drawing.SystemColors.Control;
            this.gbMonday.Controls.Add(this.lblDateMon);
            this.gbMonday.Controls.Add(this.pnlEvenMonday);
            this.gbMonday.Controls.Add(this.pnlNoonMonday);
            this.gbMonday.Controls.Add(this.pnlMornMonday);
            this.gbMonday.Location = new System.Drawing.Point(13, 11);
            this.gbMonday.Name = "gbMonday";
            this.gbMonday.Size = new System.Drawing.Size(178, 390);
            this.gbMonday.TabIndex = 0;
            this.gbMonday.TabStop = false;
            this.gbMonday.Text = "Monday";
            this.gbMonday.Enter += new System.EventHandler(this.gbMonday_Enter);
            // 
            // lblDateMon
            // 
            this.lblDateMon.AutoSize = true;
            this.lblDateMon.Location = new System.Drawing.Point(7, 24);
            this.lblDateMon.Name = "lblDateMon";
            this.lblDateMon.Size = new System.Drawing.Size(46, 17);
            this.lblDateMon.TabIndex = 2;
            this.lblDateMon.Text = "label6";
            // 
            // pnlEvenMonday
            // 
            this.pnlEvenMonday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlEvenMonday.Location = new System.Drawing.Point(6, 259);
            this.pnlEvenMonday.Name = "pnlEvenMonday";
            this.pnlEvenMonday.Size = new System.Drawing.Size(164, 100);
            this.pnlEvenMonday.TabIndex = 1;
            this.pnlEvenMonday.Click += new System.EventHandler(this.pnlEvenMonday_Click);
            // 
            // pnlNoonMonday
            // 
            this.pnlNoonMonday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNoonMonday.Location = new System.Drawing.Point(6, 153);
            this.pnlNoonMonday.Name = "pnlNoonMonday";
            this.pnlNoonMonday.Size = new System.Drawing.Size(164, 100);
            this.pnlNoonMonday.TabIndex = 1;
            this.pnlNoonMonday.Click += new System.EventHandler(this.pnlNoonMonday_Click);
            // 
            // pnlMornMonday
            // 
            this.pnlMornMonday.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMornMonday.Location = new System.Drawing.Point(7, 47);
            this.pnlMornMonday.Name = "pnlMornMonday";
            this.pnlMornMonday.Size = new System.Drawing.Size(163, 100);
            this.pnlMornMonday.TabIndex = 0;
            this.pnlMornMonday.Click += new System.EventHandler(this.pnlMornMonday_Click);
            // 
            // pnlDates
            // 
            this.pnlDates.Controls.Add(this.gbMonday);
            this.pnlDates.Controls.Add(this.gbTuesday);
            this.pnlDates.Controls.Add(this.gbWednesday);
            this.pnlDates.Controls.Add(this.gbThursday);
            this.pnlDates.Controls.Add(this.gbFriday);
            this.pnlDates.Controls.Add(this.gbSaturday);
            this.pnlDates.Controls.Add(this.gbSunday);
            this.pnlDates.Location = new System.Drawing.Point(64, 113);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(1296, 407);
            this.pnlDates.TabIndex = 14;
            // 
            // btnLoadSchedule
            // 
            this.btnLoadSchedule.Location = new System.Drawing.Point(261, 90);
            this.btnLoadSchedule.Name = "btnLoadSchedule";
            this.btnLoadSchedule.Size = new System.Drawing.Size(178, 23);
            this.btnLoadSchedule.TabIndex = 15;
            this.btnLoadSchedule.Text = "Load Schedule";
            this.btnLoadSchedule.UseVisualStyleBackColor = true;
            this.btnLoadSchedule.Click += new System.EventHandler(this.btnLoadSchedule_Click);
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 583);
            this.Controls.Add(this.gbGeneralScheduler);
            this.Name = "Scheduler";
            this.Text = "Scheduler";
            this.gbGeneralScheduler.ResumeLayout(false);
            this.gbGeneralScheduler.PerformLayout();
            this.gbSunday.ResumeLayout(false);
            this.gbSunday.PerformLayout();
            this.gbSaturday.ResumeLayout(false);
            this.gbSaturday.PerformLayout();
            this.gbFriday.ResumeLayout(false);
            this.gbFriday.PerformLayout();
            this.gbThursday.ResumeLayout(false);
            this.gbThursday.PerformLayout();
            this.gbWednesday.ResumeLayout(false);
            this.gbWednesday.PerformLayout();
            this.gbTuesday.ResumeLayout(false);
            this.gbTuesday.PerformLayout();
            this.gbMonday.ResumeLayout(false);
            this.gbMonday.PerformLayout();
            this.pnlDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneralScheduler;
        private System.Windows.Forms.GroupBox gbSunday;
        private System.Windows.Forms.Panel pnlEvenSunday;
        private System.Windows.Forms.Panel pnlNoonSunday;
        private System.Windows.Forms.Panel pnlMornSunday;
        private System.Windows.Forms.GroupBox gbSaturday;
        private System.Windows.Forms.Panel pnlEvenSaturday;
        private System.Windows.Forms.Panel pnlNoonSaturday;
        private System.Windows.Forms.Panel pnlMornSaturday;
        private System.Windows.Forms.GroupBox gbFriday;
        private System.Windows.Forms.Panel pnlEvenFriday;
        private System.Windows.Forms.Panel pnlNoonFriday;
        private System.Windows.Forms.Panel pnlMornFriday;
        private System.Windows.Forms.GroupBox gbThursday;
        private System.Windows.Forms.Panel pnlEvenThursday;
        private System.Windows.Forms.Panel pnlNoonThursday;
        private System.Windows.Forms.Panel pnlMornThursday;
        private System.Windows.Forms.GroupBox gbWednesday;
        private System.Windows.Forms.Panel pnlEvenWednesday;
        private System.Windows.Forms.Panel pnlNoonWednesday;
        private System.Windows.Forms.Panel pnlMornWednesday;
        private System.Windows.Forms.GroupBox gbTuesday;
        private System.Windows.Forms.Panel pnlEvenTuesday;
        private System.Windows.Forms.Panel pnlNoonTuesday;
        private System.Windows.Forms.Panel pnlMornTuesday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCalWeek;
        private System.Windows.Forms.GroupBox gbMonday;
        private System.Windows.Forms.Panel pnlEvenMonday;
        private System.Windows.Forms.Panel pnlNoonMonday;
        private System.Windows.Forms.Panel pnlMornMonday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateSun;
        private System.Windows.Forms.Label lblDateSat;
        private System.Windows.Forms.Label lblDateFri;
        private System.Windows.Forms.Label lblDateThu;
        private System.Windows.Forms.Label lblDateWed;
        private System.Windows.Forms.Label lblDateTue;
        private System.Windows.Forms.Label lblDateMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Panel pnlDates;
        private System.Windows.Forms.Button btnLoadSchedule;
    }
}