using System.ComponentModel;
using System.Windows.Forms;

namespace Database
{
    partial class ClientMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabCycling = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CyclingView = new System.Windows.Forms.Button();
            this.CyclingTotalCalories = new System.Windows.Forms.Label();
            this.CyclingCalories3 = new System.Windows.Forms.Label();
            this.CyclingCalories2 = new System.Windows.Forms.Label();
            this.CyclingCalories1 = new System.Windows.Forms.Label();
            this.CyclingSession3 = new System.Windows.Forms.Label();
            this.CyclingSession2 = new System.Windows.Forms.Label();
            this.CyclingSession1 = new System.Windows.Forms.Label();
            this.tabRunning = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RunningTotalCalories = new System.Windows.Forms.Label();
            this.RunningCalories3 = new System.Windows.Forms.Label();
            this.RunningCalories2 = new System.Windows.Forms.Label();
            this.RunningCalories1 = new System.Windows.Forms.Label();
            this.RunningSession3 = new System.Windows.Forms.Label();
            this.RunningSession2 = new System.Windows.Forms.Label();
            this.RunningSession1 = new System.Windows.Forms.Label();
            this.BT_runningView = new System.Windows.Forms.Button();
            this.tabSwimming = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BT_SwimmingView = new System.Windows.Forms.Button();
            this.SwimmingTotalCalories = new System.Windows.Forms.Label();
            this.SwimmingCalories3 = new System.Windows.Forms.Label();
            this.SwimmingCalories2 = new System.Windows.Forms.Label();
            this.SwimmingCalories1 = new System.Windows.Forms.Label();
            this.SwimmingSession3 = new System.Windows.Forms.Label();
            this.SwimmingSession2 = new System.Windows.Forms.Label();
            this.SwimmingSession1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabCycling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabRunning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSwimming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(709, 273);
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
            this.tabPage1.Size = new System.Drawing.Size(701, 247);
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
            this.TB_ClientWeight.TextChanged += new System.EventHandler(this.TB_ClientWeight_TextChanged);
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
            this.TB_ClientHeight.TextChanged += new System.EventHandler(this.TB_ClientHeight_TextChanged);
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
            this.TB_ClientName.TextChanged += new System.EventHandler(this.TB_ClientName_TextChanged);
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
            this.tabPage2.Size = new System.Drawing.Size(701, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BT_Reset
            // 
            this.BT_Reset.Location = new System.Drawing.Point(123, 167);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(75, 23);
            this.BT_Reset.TabIndex = 16;
            this.BT_Reset.Text = "Reset";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // BT_Log
            // 
            this.BT_Log.Location = new System.Drawing.Point(215, 167);
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
            this.exerciseStyleComboBox.Size = new System.Drawing.Size(167, 21);
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
            this.SessiondateTimePicker.Size = new System.Drawing.Size(167, 20);
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
            this.tabPage3.Size = new System.Drawing.Size(701, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compare";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabControl2.Size = new System.Drawing.Size(701, 247);
            this.tabControl2.TabIndex = 2;
            // 
            // tabCycling
            // 
            this.tabCycling.Controls.Add(this.label10);
            this.tabCycling.Controls.Add(this.pictureBox2);
            this.tabCycling.Controls.Add(this.CyclingView);
            this.tabCycling.Controls.Add(this.CyclingTotalCalories);
            this.tabCycling.Controls.Add(this.CyclingCalories3);
            this.tabCycling.Controls.Add(this.CyclingCalories2);
            this.tabCycling.Controls.Add(this.CyclingCalories1);
            this.tabCycling.Controls.Add(this.CyclingSession3);
            this.tabCycling.Controls.Add(this.CyclingSession2);
            this.tabCycling.Controls.Add(this.CyclingSession1);
            this.tabCycling.Location = new System.Drawing.Point(4, 22);
            this.tabCycling.Name = "tabCycling";
            this.tabCycling.Padding = new System.Windows.Forms.Padding(3);
            this.tabCycling.Size = new System.Drawing.Size(693, 221);
            this.tabCycling.TabIndex = 0;
            this.tabCycling.Text = "Cycling";
            this.tabCycling.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label10.Location = new System.Drawing.Point(476, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "View/Update your sessions";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Database.Properties.Resources.cycle;
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // CyclingView
            // 
            this.CyclingView.Location = new System.Drawing.Point(615, 189);
            this.CyclingView.Name = "CyclingView";
            this.CyclingView.Size = new System.Drawing.Size(75, 23);
            this.CyclingView.TabIndex = 16;
            this.CyclingView.Text = "View";
            this.CyclingView.UseVisualStyleBackColor = true;
            this.CyclingView.Click += new System.EventHandler(this.CyclingView_Click);
            // 
            // CyclingTotalCalories
            // 
            this.CyclingTotalCalories.AutoSize = true;
            this.CyclingTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CyclingTotalCalories.Location = new System.Drawing.Point(8, 202);
            this.CyclingTotalCalories.Name = "CyclingTotalCalories";
            this.CyclingTotalCalories.Size = new System.Drawing.Size(48, 13);
            this.CyclingTotalCalories.TabIndex = 15;
            this.CyclingTotalCalories.Text = "label10";
            // 
            // CyclingCalories3
            // 
            this.CyclingCalories3.AutoSize = true;
            this.CyclingCalories3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CyclingCalories3.Location = new System.Drawing.Point(520, 157);
            this.CyclingCalories3.Name = "CyclingCalories3";
            this.CyclingCalories3.Size = new System.Drawing.Size(48, 13);
            this.CyclingCalories3.TabIndex = 14;
            this.CyclingCalories3.Text = "label10";
            // 
            // CyclingCalories2
            // 
            this.CyclingCalories2.AutoSize = true;
            this.CyclingCalories2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CyclingCalories2.Location = new System.Drawing.Point(310, 157);
            this.CyclingCalories2.Name = "CyclingCalories2";
            this.CyclingCalories2.Size = new System.Drawing.Size(48, 13);
            this.CyclingCalories2.TabIndex = 13;
            this.CyclingCalories2.Text = "label10";
            // 
            // CyclingCalories1
            // 
            this.CyclingCalories1.AutoSize = true;
            this.CyclingCalories1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CyclingCalories1.Location = new System.Drawing.Point(125, 157);
            this.CyclingCalories1.Name = "CyclingCalories1";
            this.CyclingCalories1.Size = new System.Drawing.Size(48, 13);
            this.CyclingCalories1.TabIndex = 12;
            this.CyclingCalories1.Text = "label10";
            // 
            // CyclingSession3
            // 
            this.CyclingSession3.AutoSize = true;
            this.CyclingSession3.Location = new System.Drawing.Point(520, 3);
            this.CyclingSession3.Name = "CyclingSession3";
            this.CyclingSession3.Size = new System.Drawing.Size(41, 13);
            this.CyclingSession3.TabIndex = 11;
            this.CyclingSession3.Text = "label13";
            // 
            // CyclingSession2
            // 
            this.CyclingSession2.AutoSize = true;
            this.CyclingSession2.Location = new System.Drawing.Point(317, 3);
            this.CyclingSession2.Name = "CyclingSession2";
            this.CyclingSession2.Size = new System.Drawing.Size(41, 13);
            this.CyclingSession2.TabIndex = 10;
            this.CyclingSession2.Text = "label14";
            // 
            // CyclingSession1
            // 
            this.CyclingSession1.AutoSize = true;
            this.CyclingSession1.Location = new System.Drawing.Point(125, 3);
            this.CyclingSession1.Name = "CyclingSession1";
            this.CyclingSession1.Size = new System.Drawing.Size(41, 13);
            this.CyclingSession1.TabIndex = 9;
            this.CyclingSession1.Text = "label15";
            // 
            // tabRunning
            // 
            this.tabRunning.Controls.Add(this.label11);
            this.tabRunning.Controls.Add(this.pictureBox1);
            this.tabRunning.Controls.Add(this.RunningTotalCalories);
            this.tabRunning.Controls.Add(this.RunningCalories3);
            this.tabRunning.Controls.Add(this.RunningCalories2);
            this.tabRunning.Controls.Add(this.RunningCalories1);
            this.tabRunning.Controls.Add(this.RunningSession3);
            this.tabRunning.Controls.Add(this.RunningSession2);
            this.tabRunning.Controls.Add(this.RunningSession1);
            this.tabRunning.Controls.Add(this.BT_runningView);
            this.tabRunning.Location = new System.Drawing.Point(4, 22);
            this.tabRunning.Name = "tabRunning";
            this.tabRunning.Padding = new System.Windows.Forms.Padding(3);
            this.tabRunning.Size = new System.Drawing.Size(693, 221);
            this.tabRunning.TabIndex = 1;
            this.tabRunning.Text = "Running";
            this.tabRunning.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label11.Location = new System.Drawing.Point(470, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "View/Update your sessions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Database.Properties.Resources.runningman;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RunningTotalCalories
            // 
            this.RunningTotalCalories.AutoSize = true;
            this.RunningTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningTotalCalories.Location = new System.Drawing.Point(7, 201);
            this.RunningTotalCalories.Name = "RunningTotalCalories";
            this.RunningTotalCalories.Size = new System.Drawing.Size(48, 13);
            this.RunningTotalCalories.TabIndex = 9;
            this.RunningTotalCalories.Text = "label10";
            // 
            // RunningCalories3
            // 
            this.RunningCalories3.AutoSize = true;
            this.RunningCalories3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningCalories3.Location = new System.Drawing.Point(512, 160);
            this.RunningCalories3.Name = "RunningCalories3";
            this.RunningCalories3.Size = new System.Drawing.Size(48, 13);
            this.RunningCalories3.TabIndex = 8;
            this.RunningCalories3.Text = "label10";
            // 
            // RunningCalories2
            // 
            this.RunningCalories2.AutoSize = true;
            this.RunningCalories2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningCalories2.Location = new System.Drawing.Point(311, 160);
            this.RunningCalories2.Name = "RunningCalories2";
            this.RunningCalories2.Size = new System.Drawing.Size(48, 13);
            this.RunningCalories2.TabIndex = 7;
            this.RunningCalories2.Text = "label10";
            // 
            // RunningCalories1
            // 
            this.RunningCalories1.AutoSize = true;
            this.RunningCalories1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningCalories1.Location = new System.Drawing.Point(133, 160);
            this.RunningCalories1.Name = "RunningCalories1";
            this.RunningCalories1.Size = new System.Drawing.Size(48, 13);
            this.RunningCalories1.TabIndex = 6;
            this.RunningCalories1.Text = "label10";
            // 
            // RunningSession3
            // 
            this.RunningSession3.AutoSize = true;
            this.RunningSession3.Location = new System.Drawing.Point(510, 6);
            this.RunningSession3.Name = "RunningSession3";
            this.RunningSession3.Size = new System.Drawing.Size(50, 13);
            this.RunningSession3.TabIndex = 5;
            this.RunningSession3.Text = "Session3";
            // 
            // RunningSession2
            // 
            this.RunningSession2.AutoSize = true;
            this.RunningSession2.Location = new System.Drawing.Point(309, 6);
            this.RunningSession2.Name = "RunningSession2";
            this.RunningSession2.Size = new System.Drawing.Size(50, 13);
            this.RunningSession2.TabIndex = 3;
            this.RunningSession2.Text = "Session2";
            // 
            // RunningSession1
            // 
            this.RunningSession1.AutoSize = true;
            this.RunningSession1.Location = new System.Drawing.Point(131, 6);
            this.RunningSession1.Name = "RunningSession1";
            this.RunningSession1.Size = new System.Drawing.Size(50, 13);
            this.RunningSession1.TabIndex = 2;
            this.RunningSession1.Text = "Session1";
            // 
            // BT_runningView
            // 
            this.BT_runningView.Location = new System.Drawing.Point(609, 191);
            this.BT_runningView.Name = "BT_runningView";
            this.BT_runningView.Size = new System.Drawing.Size(75, 23);
            this.BT_runningView.TabIndex = 1;
            this.BT_runningView.Text = "View";
            this.BT_runningView.UseVisualStyleBackColor = true;
            this.BT_runningView.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabSwimming
            // 
            this.tabSwimming.Controls.Add(this.label12);
            this.tabSwimming.Controls.Add(this.pictureBox3);
            this.tabSwimming.Controls.Add(this.BT_SwimmingView);
            this.tabSwimming.Controls.Add(this.SwimmingTotalCalories);
            this.tabSwimming.Controls.Add(this.SwimmingCalories3);
            this.tabSwimming.Controls.Add(this.SwimmingCalories2);
            this.tabSwimming.Controls.Add(this.SwimmingCalories1);
            this.tabSwimming.Controls.Add(this.SwimmingSession3);
            this.tabSwimming.Controls.Add(this.SwimmingSession2);
            this.tabSwimming.Controls.Add(this.SwimmingSession1);
            this.tabSwimming.Location = new System.Drawing.Point(4, 22);
            this.tabSwimming.Name = "tabSwimming";
            this.tabSwimming.Size = new System.Drawing.Size(693, 221);
            this.tabSwimming.TabIndex = 2;
            this.tabSwimming.Text = "Swimming";
            this.tabSwimming.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label12.Location = new System.Drawing.Point(475, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "View/Update your sessions";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Database.Properties.Resources.swimming;
            this.pictureBox3.Location = new System.Drawing.Point(3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // BT_SwimmingView
            // 
            this.BT_SwimmingView.Location = new System.Drawing.Point(614, 190);
            this.BT_SwimmingView.Name = "BT_SwimmingView";
            this.BT_SwimmingView.Size = new System.Drawing.Size(75, 23);
            this.BT_SwimmingView.TabIndex = 26;
            this.BT_SwimmingView.Text = "View";
            this.BT_SwimmingView.UseVisualStyleBackColor = true;
            this.BT_SwimmingView.Click += new System.EventHandler(this.BT_SwimmingView_Click);
            // 
            // SwimmingTotalCalories
            // 
            this.SwimmingTotalCalories.AutoSize = true;
            this.SwimmingTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingTotalCalories.Location = new System.Drawing.Point(7, 203);
            this.SwimmingTotalCalories.Name = "SwimmingTotalCalories";
            this.SwimmingTotalCalories.Size = new System.Drawing.Size(48, 13);
            this.SwimmingTotalCalories.TabIndex = 25;
            this.SwimmingTotalCalories.Text = "label10";
            // 
            // SwimmingCalories3
            // 
            this.SwimmingCalories3.AutoSize = true;
            this.SwimmingCalories3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingCalories3.Location = new System.Drawing.Point(519, 158);
            this.SwimmingCalories3.Name = "SwimmingCalories3";
            this.SwimmingCalories3.Size = new System.Drawing.Size(48, 13);
            this.SwimmingCalories3.TabIndex = 24;
            this.SwimmingCalories3.Text = "label10";
            // 
            // SwimmingCalories2
            // 
            this.SwimmingCalories2.AutoSize = true;
            this.SwimmingCalories2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingCalories2.Location = new System.Drawing.Point(309, 158);
            this.SwimmingCalories2.Name = "SwimmingCalories2";
            this.SwimmingCalories2.Size = new System.Drawing.Size(48, 13);
            this.SwimmingCalories2.TabIndex = 23;
            this.SwimmingCalories2.Text = "label10";
            // 
            // SwimmingCalories1
            // 
            this.SwimmingCalories1.AutoSize = true;
            this.SwimmingCalories1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwimmingCalories1.Location = new System.Drawing.Point(124, 158);
            this.SwimmingCalories1.Name = "SwimmingCalories1";
            this.SwimmingCalories1.Size = new System.Drawing.Size(48, 13);
            this.SwimmingCalories1.TabIndex = 22;
            this.SwimmingCalories1.Text = "label10";
            // 
            // SwimmingSession3
            // 
            this.SwimmingSession3.AutoSize = true;
            this.SwimmingSession3.Location = new System.Drawing.Point(519, 4);
            this.SwimmingSession3.Name = "SwimmingSession3";
            this.SwimmingSession3.Size = new System.Drawing.Size(41, 13);
            this.SwimmingSession3.TabIndex = 21;
            this.SwimmingSession3.Text = "label13";
            // 
            // SwimmingSession2
            // 
            this.SwimmingSession2.AutoSize = true;
            this.SwimmingSession2.Location = new System.Drawing.Point(316, 4);
            this.SwimmingSession2.Name = "SwimmingSession2";
            this.SwimmingSession2.Size = new System.Drawing.Size(41, 13);
            this.SwimmingSession2.TabIndex = 20;
            this.SwimmingSession2.Text = "label14";
            // 
            // SwimmingSession1
            // 
            this.SwimmingSession1.AutoSize = true;
            this.SwimmingSession1.Location = new System.Drawing.Point(124, 4);
            this.SwimmingSession1.Name = "SwimmingSession1";
            this.SwimmingSession1.Size = new System.Drawing.Size(41, 13);
            this.SwimmingSession1.TabIndex = 19;
            this.SwimmingSession1.Text = "label15";
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 273);
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
            this.tabCycling.ResumeLayout(false);
            this.tabCycling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabRunning.ResumeLayout(false);
            this.tabRunning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSwimming.ResumeLayout(false);
            this.tabSwimming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button BT_ClientSave;
        private TextBox TB_ClientWeight;
        private Label LB_ClientWeight;
        private TextBox TB_ClientHeight;
        private Label LB_ClientHeight;
        private TextBox TB_ClientName;
        private Label LB_ClientName;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox minuteComboBox;
        private ComboBox hourComboBox;
        private Label label5;
        private Label label4;
        private DateTimePicker SessiondateTimePicker;
        private Label label3;
        private TextBox TB_Duration;
        private Label label6;
        private Label label8;
        private ComboBox exerciseTypeComboBox;
        private Label label7;
        private Label label9;
        private ComboBox exerciseStyleComboBox;
        private Button BT_Reset;
        private Button BT_Log;
        private Button BT_runningView;
        private TabControl tabControl2;
        private TabPage tabCycling;
        private TabPage tabRunning;
        private TabPage tabSwimming;
        private Label RunningSession1;
        private Label RunningSession2;
        private Label RunningSession3;
        private Label RunningCalories1;
        private Label RunningCalories3;
        private Label RunningCalories2;
        private Label RunningTotalCalories;
        private Button CyclingView;
        private Label CyclingTotalCalories;
        private Label CyclingCalories3;
        private Label CyclingCalories2;
        private Label CyclingCalories1;
        private Label CyclingSession3;
        private Label CyclingSession2;
        private Label CyclingSession1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label10;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox3;
        private Button BT_SwimmingView;
        private Label SwimmingTotalCalories;
        private Label SwimmingCalories3;
        private Label SwimmingCalories2;
        private Label SwimmingCalories1;
        private Label SwimmingSession3;
        private Label SwimmingSession2;
        private Label SwimmingSession1;

    }
}