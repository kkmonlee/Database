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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LB_ClientName = new System.Windows.Forms.Label();
            this.TB_ClientName = new System.Windows.Forms.TextBox();
            this.LB_ClientHeight = new System.Windows.Forms.Label();
            this.TB_ClientHeight = new System.Windows.Forms.TextBox();
            this.LB_ClientWeight = new System.Windows.Forms.Label();
            this.TB_ClientWeight = new System.Windows.Forms.TextBox();
            this.BT_ClientSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(871, 583);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(863, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(863, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(863, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compare";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // TB_ClientName
            // 
            this.TB_ClientName.Location = new System.Drawing.Point(116, 37);
            this.TB_ClientName.Name = "TB_ClientName";
            this.TB_ClientName.Size = new System.Drawing.Size(186, 20);
            this.TB_ClientName.TabIndex = 3;
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
            // TB_ClientHeight
            // 
            this.TB_ClientHeight.Location = new System.Drawing.Point(116, 63);
            this.TB_ClientHeight.MaxLength = 3;
            this.TB_ClientHeight.Name = "TB_ClientHeight";
            this.TB_ClientHeight.Size = new System.Drawing.Size(46, 20);
            this.TB_ClientHeight.TabIndex = 5;
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
            // TB_ClientWeight
            // 
            this.TB_ClientWeight.Location = new System.Drawing.Point(256, 63);
            this.TB_ClientWeight.MaxLength = 3;
            this.TB_ClientWeight.Name = "TB_ClientWeight";
            this.TB_ClientWeight.Size = new System.Drawing.Size(46, 20);
            this.TB_ClientWeight.TabIndex = 7;
            // 
            // BT_ClientSave
            // 
            this.BT_ClientSave.Location = new System.Drawing.Point(227, 98);
            this.BT_ClientSave.Name = "BT_ClientSave";
            this.BT_ClientSave.Size = new System.Drawing.Size(75, 23);
            this.BT_ClientSave.TabIndex = 8;
            this.BT_ClientSave.Text = "Save";
            this.BT_ClientSave.UseVisualStyleBackColor = true;
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 583);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClientMain";
            this.Text = "ClientMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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

    }
}