namespace Database
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.LB_LoginWelcome = new System.Windows.Forms.Label();
            this.TB_LoginUsername = new System.Windows.Forms.TextBox();
            this.LB_LoginUsername = new System.Windows.Forms.Label();
            this.LB_LoginPassword = new System.Windows.Forms.Label();
            this.TB_LoginPassword = new System.Windows.Forms.TextBox();
            this.LB_LoginRegister = new System.Windows.Forms.LinkLabel();
            this.BT_LoginLogin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BT_toolStripAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_LoginWelcome
            // 
            this.LB_LoginWelcome.Location = new System.Drawing.Point(12, 9);
            this.LB_LoginWelcome.Name = "LB_LoginWelcome";
            this.LB_LoginWelcome.Size = new System.Drawing.Size(307, 35);
            this.LB_LoginWelcome.TabIndex = 0;
            this.LB_LoginWelcome.Text = "Welcome to the Running Club Software! Enter your username and password to continu" +
    "e.";
            // 
            // TB_LoginUsername
            // 
            this.TB_LoginUsername.Location = new System.Drawing.Point(111, 57);
            this.TB_LoginUsername.Name = "TB_LoginUsername";
            this.TB_LoginUsername.Size = new System.Drawing.Size(208, 20);
            this.TB_LoginUsername.TabIndex = 1;
            // 
            // LB_LoginUsername
            // 
            this.LB_LoginUsername.AutoSize = true;
            this.LB_LoginUsername.Location = new System.Drawing.Point(12, 60);
            this.LB_LoginUsername.Name = "LB_LoginUsername";
            this.LB_LoginUsername.Size = new System.Drawing.Size(58, 13);
            this.LB_LoginUsername.TabIndex = 2;
            this.LB_LoginUsername.Text = "Username:";
            // 
            // LB_LoginPassword
            // 
            this.LB_LoginPassword.AutoSize = true;
            this.LB_LoginPassword.Location = new System.Drawing.Point(12, 97);
            this.LB_LoginPassword.Name = "LB_LoginPassword";
            this.LB_LoginPassword.Size = new System.Drawing.Size(56, 13);
            this.LB_LoginPassword.TabIndex = 3;
            this.LB_LoginPassword.Text = "Password:";
            // 
            // TB_LoginPassword
            // 
            this.TB_LoginPassword.Location = new System.Drawing.Point(111, 94);
            this.TB_LoginPassword.Name = "TB_LoginPassword";
            this.TB_LoginPassword.Size = new System.Drawing.Size(208, 20);
            this.TB_LoginPassword.TabIndex = 4;
            // 
            // LB_LoginRegister
            // 
            this.LB_LoginRegister.AutoSize = true;
            this.LB_LoginRegister.Location = new System.Drawing.Point(225, 171);
            this.LB_LoginRegister.Name = "LB_LoginRegister";
            this.LB_LoginRegister.Size = new System.Drawing.Size(106, 13);
            this.LB_LoginRegister.TabIndex = 5;
            this.LB_LoginRegister.TabStop = true;
            this.LB_LoginRegister.Text = "Click here to register!";
            this.LB_LoginRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LB_LoginRegister_LinkClicked);
            // 
            // BT_LoginLogin
            // 
            this.BT_LoginLogin.Location = new System.Drawing.Point(220, 130);
            this.BT_LoginLogin.Name = "BT_LoginLogin";
            this.BT_LoginLogin.Size = new System.Drawing.Size(99, 23);
            this.BT_LoginLogin.TabIndex = 6;
            this.BT_LoginLogin.Text = "Sign in";
            this.BT_LoginLogin.UseVisualStyleBackColor = true;
            this.BT_LoginLogin.Click += new System.EventHandler(this.BT_LoginLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.BT_toolStripAdmin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(331, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // BT_toolStripAdmin
            // 
            this.BT_toolStripAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BT_toolStripAdmin.Image = global::Database.Properties.Resources.admin_ico;
            this.BT_toolStripAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BT_toolStripAdmin.IsLink = true;
            this.BT_toolStripAdmin.Name = "BT_toolStripAdmin";
            this.BT_toolStripAdmin.Size = new System.Drawing.Size(16, 17);
            this.BT_toolStripAdmin.Text = "toolStripSplitButton1";
            this.BT_toolStripAdmin.Click += new System.EventHandler(this.BT_toolStripAdmin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 206);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BT_LoginLogin);
            this.Controls.Add(this.LB_LoginRegister);
            this.Controls.Add(this.TB_LoginPassword);
            this.Controls.Add(this.LB_LoginPassword);
            this.Controls.Add(this.LB_LoginUsername);
            this.Controls.Add(this.TB_LoginUsername);
            this.Controls.Add(this.LB_LoginWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_LoginWelcome;
        private System.Windows.Forms.TextBox TB_LoginUsername;
        private System.Windows.Forms.Label LB_LoginUsername;
        private System.Windows.Forms.Label LB_LoginPassword;
        private System.Windows.Forms.TextBox TB_LoginPassword;
        private System.Windows.Forms.LinkLabel LB_LoginRegister;
        private System.Windows.Forms.Button BT_LoginLogin;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel BT_toolStripAdmin;
    }
}

