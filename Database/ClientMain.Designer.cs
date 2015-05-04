namespace Database
{
    partial class ClientMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_ClientSave = new System.Windows.Forms.Button();
            this.TB_ClientWeight = new System.Windows.Forms.TextBox();
            this.LB_ClientWeight = new System.Windows.Forms.Label();
            this.TB_ClientHeight = new System.Windows.Forms.TextBox();
            this.LB_ClientHeight = new System.Windows.Forms.Label();
            this.TB_ClientName = new System.Windows.Forms.TextBox();
            this.LB_ClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BT_Reset = new System.Windows.Forms.Button();
            this.BT_Log = new System.Windows.Forms.Button();
            this.exerciseStyleComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.exerciseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Duration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minuteComboBox = new System.Windows.Forms.ComboBox();
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SessiondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BT_runningView = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabCycling = new System.Windows.Forms.TabPage();
            this.tabRunning = new System.Windows.Forms.TabPage();
            this.tabSwimming = new System.Windows.Forms.TabPage();
            this.Session1 = new System.Windows.Forms.Label();
            this.Session2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Session3 = new System.Windows.Forms.Label();
            this.calSession1 = new System.Windows.Forms.Label();
            this.calSession2 = new System.Windows.Forms.Label();
            this.calSession3 = new System.Windows.Forms.Label();
            this.LB_TotalCalories = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRunning.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 398);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BT_ClientSave);
            this.tabPage1.Controls.Add(this.TB_ClientWeight);
            this.tabPage1.Controls.Add(this.LB_ClientWeight);
            this.tabPage1.Controls.Add(this.TB_ClientHeight);
            this.tabPage1.Controls.Add(this.LB_ClientHeight);
            this.tabPage1.Controls.Add(this.TB_ClientName);
            this.tabPage1.Controls.Add(this.LB_ClientName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Birthday:";
            // 
            // BT_ClientSave
            // 
            this.BT_ClientSave.Location = new System.Drawing.Point(227, 142);
            this.BT_ClientSave.Name = "BT_ClientSave";
            this.BT_ClientSave.Size = new System.Drawing.Size(75, 23);
            this.BT_ClientSave.TabIndex = 8;
            this.BT_ClientSave.Text = "Save";
            this.BT_ClientSave.UseVisualStyleBackColor = true;
            this.BT_ClientSave.Click += new System.EventHandler(this.BT_ClientSave_Click);
            // 
            // TB_ClientWeight
            // 
            this.TB_ClientWeight.Location = new System.Drawing.Point(256, 63);
            this.TB_ClientWeight.MaxLength = 3;
            this.TB_ClientWeight.Name = "TB_ClientWeight";
            this.TB_ClientWeight.Size = new System.Drawing.Size(46, 20);
            this.TB_ClientWeight.TabIndex = 7;
            // 
            // LB_ClientWeight
            // 
            this.LB_ClientWeight.AutoSize = true;
            this.LB_ClientWeight.Location = new System.Drawing.Point(174, 66);
            this.LB_ClientWeight.Name = "LB_ClientWeight";
            this.LB_ClientWeight.Size = new System.Drawing.Size(76, 13);
            this.LB_ClientWeight.TabIndex = 6;
            this.LB_ClientWeight.Text = "Weight (in kg):";
            // 
            // TB_ClientHeight
            // 
            this.TB_ClientHeight.Location = new System.Drawing.Point(116, 63);
            this.TB_ClientHeight.MaxLength = 3;
            this.TB_ClientHeight.Name = "TB_ClientHeight";
            this.TB_ClientHeight.Size = new System.Drawing.Size(46, 20);
            this.TB_ClientHeight.TabIndex = 5;
            // 
            // LB_ClientHeight
            // 
            this.LB_ClientHeight.AutoSize = true;
            this.LB_ClientHeight.Location = new System.Drawing.Point(35, 66);
            this.LB_ClientHeight.Name = "LB_ClientHeight";
            this.LB_ClientHeight.Size = new System.Drawing.Size(75, 13);
            this.LB_ClientHeight.TabIndex = 4;
            this.LB_ClientHeight.Text = "Height (in cm):";
            // 
            // TB_ClientName
            // 
            this.TB_ClientName.Location = new System.Drawing.Point(116, 37);
            this.TB_ClientName.Name = "TB_ClientName";
            this.TB_ClientName.Size = new System.Drawing.Size(186, 20);
            this.TB_ClientName.TabIndex = 3;
            // 
            // LB_ClientName
            // 
            this.LB_ClientName.AutoSize = true;
            this.LB_ClientName.Location = new System.Drawing.Point(28, 40);
            this.LB_ClientName.Name = "LB_ClientName";
            this.LB_ClientName.Size = new System.Drawing.Size(82, 13);
            this.LB_ClientName.TabIndex = 2;
            this.LB_ClientName.Text = "Your Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to your control panel!";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BT_Reset);
            this.tabPage2.Controls.Add(this.BT_Log);
            this.tabPage2.Controls.Add(this.exerciseStyleComboBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.exerciseTypeComboBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TB_Duration);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.minuteComboBox);
            this.tabPage2.Controls.Add(this.hourComboBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.SessiondateTimePicker);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BT_Reset
            // 
            this.BT_Reset.Location = new System.Drawing.Point(87, 167);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(75, 23);
            this.BT_Reset.TabIndex = 16;
            this.BT_Reset.Text = "Reset";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // BT_Log
            // 
            this.BT_Log.Location = new System.Drawing.Point(186, 167);
            this.BT_Log.Name = "BT_Log";
            this.BT_Log.Size = new System.Drawing.Size(75, 23);
            this.BT_Log.TabIndex = 14;
            this.BT_Log.Text = "Log";
            this.BT_Log.UseVisualStyleBackColor = true;
            this.BT_Log.Click += new System.EventHandler(this.BT_Log_Click);
            // 
            // exerciseStyleComboBox
            // 
            this.exerciseStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exerciseStyleComboBox.FormattingEnabled = true;
            this.exerciseStyleComboBox.Location = new System.Drawing.Point(123, 130);
            this.exerciseStyleComboBox.Name = "exerciseStyleComboBox";
            this.exerciseStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.exerciseStyleComboBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Exercise Speed/Style:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Exercise Type:";
            // 
            // exerciseTypeComboBox
            // 
            this.exerciseTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exerciseTypeComboBox.FormattingEnabled = true;
            this.exerciseTypeComboBox.Location = new System.Drawing.Point(123, 103);
            this.exerciseTypeComboBox.Name = "exerciseTypeComboBox";
            this.exerciseTypeComboBox.Size = new System.Drawing.Size(76, 21);
            this.exerciseTypeComboBox.TabIndex = 10;
            this.exerciseTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.exerciseTypeComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label7.Location = new System.Drawing.Point(166, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "hours";
            // 
            // TB_Duration
            // 
            this.TB_Duration.Location = new System.Drawing.Point(124, 77);
            this.TB_Duration.MaxLength = 2;
            this.TB_Duration.Name = "TB_Duration";
            this.TB_Duration.Size = new System.Drawing.Size(36, 20);
            this.TB_Duration.TabIndex = 8;
            this.TB_Duration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duration:";
            // 
            // minuteComboBox
            // 
            this.minuteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.minuteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.minuteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteComboBox.FormattingEnabled = true;
            this.minuteComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minuteComboBox.Location = new System.Drawing.Point(177, 50);
            this.minuteComboBox.Name = "minuteComboBox";
            this.minuteComboBox.Size = new System.Drawing.Size(48, 21);
            this.minuteComboBox.TabIndex = 6;
            // 
            // hourComboBox
            // 
            this.hourComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.hourComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "24"});
            this.hourComboBox.Location = new System.Drawing.Point(123, 50);
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(48, 21);
            this.hourComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // SessiondateTimePicker
            // 
            this.SessiondateTimePicker.Location = new System.Drawing.Point(123, 20);
            this.SessiondateTimePicker.Name = "SessiondateTimePicker";
            this.SessiondateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.SessiondateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Log a session here:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(702, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compare";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BT_runningView
            // 
            this.BT_runningView.Location = new System.Drawing.Point(609, 317);
            this.BT_runningView.Name = "BT_runningView";
            this.BT_runningView.Size = new System.Drawing.Size(75, 23);
            this.BT_runningView.TabIndex = 1;
            this.BT_runningView.Text = "View";
            this.BT_runningView.UseVisualStyleBackColor = true;
            this.BT_runningView.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabCycling);
            this.tabControl2.Controls.Add(this.tabRunning);
            this.tabControl2.Controls.Add(this.tabSwimming);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(702, 372);
            this.tabControl2.TabIndex = 2;
            // 
            // tabCycling
            // 
            this.tabCycling.Location = new System.Drawing.Point(4, 22);
            this.tabCycling.Name = "tabCycling";
            this.tabCycling.Padding = new System.Windows.Forms.Padding(3);
            this.tabCycling.Size = new System.Drawing.Size(521, 161);
            this.tabCycling.TabIndex = 0;
            this.tabCycling.Text = "Cycling";
            this.tabCycling.UseVisualStyleBackColor = true;
            // 
            // tabRunning
            // 
            this.tabRunning.Controls.Add(this.LB_TotalCalories);
            this.tabRunning.Controls.Add(this.calSession3);
            this.tabRunning.Controls.Add(this.calSession2);
            this.tabRunning.Controls.Add(this.calSession1);
            this.tabRunning.Controls.Add(this.Session3);
            this.tabRunning.Controls.Add(this.textBox1);
            this.tabRunning.Controls.Add(this.Session2);
            this.tabRunning.Controls.Add(this.Session1);
            this.tabRunning.Controls.Add(this.BT_runningView);
            this.tabRunning.Location = new System.Drawing.Point(4, 22);
            this.tabRunning.Name = "tabRunning";
            this.tabRunning.Padding = new System.Windows.Forms.Padding(3);
            this.tabRunning.Size = new System.Drawing.Size(694, 346);
            this.tabRunning.TabIndex = 1;
            this.tabRunning.Text = "Running";
            this.tabRunning.UseVisualStyleBackColor = true;
            // 
            // tabSwimming
            // 
            this.tabSwimming.Location = new System.Drawing.Point(4, 22);
            this.tabSwimming.Name = "tabSwimming";
            this.tabSwimming.Size = new System.Drawing.Size(521, 177);
            this.tabSwimming.TabIndex = 2;
            this.tabSwimming.Text = "Swimming";
            this.tabSwimming.UseVisualStyleBackColor = true;
            // 
            // Session1
            // 
            this.Session1.AutoSize = true;
            this.Session1.Location = new System.Drawing.Point(7, 7);
            this.Session1.Name = "Session1";
            this.Session1.Size = new System.Drawing.Size(50, 13);
            this.Session1.TabIndex = 2;
            this.Session1.Text = "Session1";
            // 
            // Session2
            // 
            this.Session2.AutoSize = true;
            this.Session2.Location = new System.Drawing.Point(236, 7);
            this.Session2.Name = "Session2";
            this.Session2.Size = new System.Drawing.Size(50, 13);
            this.Session2.TabIndex = 3;
            this.Session2.Text = "Session2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 44);
            this.textBox1.TabIndex = 4;
            // 
            // Session3
            // 
            this.Session3.AutoSize = true;
            this.Session3.Location = new System.Drawing.Point(478, 7);
            this.Session3.Name = "Session3";
            this.Session3.Size = new System.Drawing.Size(50, 13);
            this.Session3.TabIndex = 5;
            this.Session3.Text = "Session3";
            // 
            // calSession1
            // 
            this.calSession1.AutoSize = true;
            this.calSession1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calSession1.Location = new System.Drawing.Point(9, 125);
            this.calSession1.Name = "calSession1";
            this.calSession1.Size = new System.Drawing.Size(48, 13);
            this.calSession1.TabIndex = 6;
            this.calSession1.Text = "label10";
            // 
            // calSession2
            // 
            this.calSession2.AutoSize = true;
            this.calSession2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calSession2.Location = new System.Drawing.Point(238, 125);
            this.calSession2.Name = "calSession2";
            this.calSession2.Size = new System.Drawing.Size(48, 13);
            this.calSession2.TabIndex = 7;
            this.calSession2.Text = "label10";
            // 
            // calSession3
            // 
            this.calSession3.AutoSize = true;
            this.calSession3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calSession3.Location = new System.Drawing.Point(480, 125);
            this.calSession3.Name = "calSession3";
            this.calSession3.Size = new System.Drawing.Size(48, 13);
            this.calSession3.TabIndex = 8;
            this.calSession3.Text = "label10";
            // 
            // LB_TotalCalories
            // 
            this.LB_TotalCalories.AutoSize = true;
            this.LB_TotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TotalCalories.Location = new System.Drawing.Point(7, 327);
            this.LB_TotalCalories.Name = "LB_TotalCalories";
            this.LB_TotalCalories.Size = new System.Drawing.Size(48, 13);
            this.LB_TotalCalories.TabIndex = 9;
            this.LB_TotalCalories.Text = "label10";
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 398);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(351, 263);
            this.Name = "ClientMain";
            this.Text = "ClientMain";
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabRunning.ResumeLayout(false);
            this.tabRunning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BT_ClientSave;
        private System.Windows.Forms.TextBox TB_ClientWeight;
        private System.Windows.Forms.Label LB_ClientWeight;
        private System.Windows.Forms.TextBox TB_ClientHeight;
        private System.Windows.Forms.Label LB_ClientHeight;
        private System.Windows.Forms.TextBox TB_ClientName;
        private System.Windows.Forms.Label LB_ClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox minuteComboBox;
        private System.Windows.Forms.ComboBox hourComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker SessiondateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Duration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox exerciseTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox exerciseStyleComboBox;
        private System.Windows.Forms.Button BT_Reset;
        private System.Windows.Forms.Button BT_Log;
        private System.Windows.Forms.Button BT_runningView;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabCycling;
        private System.Windows.Forms.TabPage tabRunning;
        private System.Windows.Forms.TabPage tabSwimming;
        private System.Windows.Forms.Label Session1;
        private System.Windows.Forms.Label Session2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Session3;
        private System.Windows.Forms.Label calSession1;
        private System.Windows.Forms.Label calSession3;
        private System.Windows.Forms.Label calSession2;
        private System.Windows.Forms.Label LB_TotalCalories;

    }
}