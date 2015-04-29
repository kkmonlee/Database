namespace Database
{
    partial class ClientRegister
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
            this.LB_RegisterWelcome = new System.Windows.Forms.Label();
            this.LB_RegisterUsername = new System.Windows.Forms.Label();
            this.LB_RegisterPassword = new System.Windows.Forms.Label();
            this.LB_RegisterConfirm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BT_RegisterRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_RegisterWelcome
            // 
            this.LB_RegisterWelcome.AutoSize = true;
            this.LB_RegisterWelcome.Location = new System.Drawing.Point(13, 13);
            this.LB_RegisterWelcome.Name = "LB_RegisterWelcome";
            this.LB_RegisterWelcome.Size = new System.Drawing.Size(278, 13);
            this.LB_RegisterWelcome.TabIndex = 0;
            this.LB_RegisterWelcome.Text = "Please enter your desired username and password below!";
            // 
            // LB_RegisterUsername
            // 
            this.LB_RegisterUsername.AutoSize = true;
            this.LB_RegisterUsername.Location = new System.Drawing.Point(52, 50);
            this.LB_RegisterUsername.Name = "LB_RegisterUsername";
            this.LB_RegisterUsername.Size = new System.Drawing.Size(58, 13);
            this.LB_RegisterUsername.TabIndex = 1;
            this.LB_RegisterUsername.Text = "Username:";
            // 
            // LB_RegisterPassword
            // 
            this.LB_RegisterPassword.AutoSize = true;
            this.LB_RegisterPassword.Location = new System.Drawing.Point(54, 84);
            this.LB_RegisterPassword.Name = "LB_RegisterPassword";
            this.LB_RegisterPassword.Size = new System.Drawing.Size(56, 13);
            this.LB_RegisterPassword.TabIndex = 2;
            this.LB_RegisterPassword.Text = "Password:";
            // 
            // LB_RegisterConfirm
            // 
            this.LB_RegisterConfirm.AutoSize = true;
            this.LB_RegisterConfirm.Location = new System.Drawing.Point(16, 118);
            this.LB_RegisterConfirm.Name = "LB_RegisterConfirm";
            this.LB_RegisterConfirm.Size = new System.Drawing.Size(94, 13);
            this.LB_RegisterConfirm.TabIndex = 3;
            this.LB_RegisterConfirm.Text = "Confirm Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 6;
            // 
            // BT_RegisterRegister
            // 
            this.BT_RegisterRegister.Location = new System.Drawing.Point(201, 154);
            this.BT_RegisterRegister.Name = "BT_RegisterRegister";
            this.BT_RegisterRegister.Size = new System.Drawing.Size(90, 23);
            this.BT_RegisterRegister.TabIndex = 7;
            this.BT_RegisterRegister.Text = "Sign up";
            this.BT_RegisterRegister.UseVisualStyleBackColor = true;
            this.BT_RegisterRegister.Click += new System.EventHandler(this.BT_RegisterRegister_Click);
            // 
            // ClientRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 202);
            this.Controls.Add(this.BT_RegisterRegister);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LB_RegisterConfirm);
            this.Controls.Add(this.LB_RegisterPassword);
            this.Controls.Add(this.LB_RegisterUsername);
            this.Controls.Add(this.LB_RegisterWelcome);
            this.Name = "ClientRegister";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_RegisterWelcome;
        private System.Windows.Forms.Label LB_RegisterUsername;
        private System.Windows.Forms.Label LB_RegisterPassword;
        private System.Windows.Forms.Label LB_RegisterConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BT_RegisterRegister;
    }
}