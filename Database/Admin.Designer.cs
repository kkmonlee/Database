namespace Database
{
    partial class Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_AdminAdd = new System.Windows.Forms.Button();
            this.TB_AdminPassword = new System.Windows.Forms.TextBox();
            this.LB_AdminPassword = new System.Windows.Forms.Label();
            this.TB_AdminUsername = new System.Windows.Forms.TextBox();
            this.LB_AdminUsername = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_AdminUpdate = new System.Windows.Forms.Button();
            this.BT_AdminSave = new System.Windows.Forms.Button();
            this.BT_AdminEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_AdminAdd);
            this.groupBox1.Controls.Add(this.TB_AdminPassword);
            this.groupBox1.Controls.Add(this.LB_AdminPassword);
            this.groupBox1.Controls.Add(this.TB_AdminUsername);
            this.groupBox1.Controls.Add(this.LB_AdminUsername);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add People";
            // 
            // BT_AdminAdd
            // 
            this.BT_AdminAdd.Location = new System.Drawing.Point(187, 98);
            this.BT_AdminAdd.Name = "BT_AdminAdd";
            this.BT_AdminAdd.Size = new System.Drawing.Size(76, 23);
            this.BT_AdminAdd.TabIndex = 4;
            this.BT_AdminAdd.Text = "Add";
            this.BT_AdminAdd.UseVisualStyleBackColor = true;
            this.BT_AdminAdd.Click += new System.EventHandler(this.BT_AdminAdd_Click);
            // 
            // TB_AdminPassword
            // 
            this.TB_AdminPassword.Location = new System.Drawing.Point(101, 63);
            this.TB_AdminPassword.Name = "TB_AdminPassword";
            this.TB_AdminPassword.Size = new System.Drawing.Size(162, 20);
            this.TB_AdminPassword.TabIndex = 3;
            // 
            // LB_AdminPassword
            // 
            this.LB_AdminPassword.AutoSize = true;
            this.LB_AdminPassword.Location = new System.Drawing.Point(6, 66);
            this.LB_AdminPassword.Name = "LB_AdminPassword";
            this.LB_AdminPassword.Size = new System.Drawing.Size(56, 13);
            this.LB_AdminPassword.TabIndex = 2;
            this.LB_AdminPassword.Text = "Password:";
            // 
            // TB_AdminUsername
            // 
            this.TB_AdminUsername.Location = new System.Drawing.Point(101, 26);
            this.TB_AdminUsername.Name = "TB_AdminUsername";
            this.TB_AdminUsername.Size = new System.Drawing.Size(162, 20);
            this.TB_AdminUsername.TabIndex = 1;
            // 
            // LB_AdminUsername
            // 
            this.LB_AdminUsername.AutoSize = true;
            this.LB_AdminUsername.Location = new System.Drawing.Point(6, 29);
            this.LB_AdminUsername.Name = "LB_AdminUsername";
            this.LB_AdminUsername.Size = new System.Drawing.Size(58, 13);
            this.LB_AdminUsername.TabIndex = 0;
            this.LB_AdminUsername.Text = "Username:";
            this.LB_AdminUsername.Click += new System.EventHandler(this.LB_AdminUsername_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 284);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BT_AdminUpdate
            // 
            this.BT_AdminUpdate.Location = new System.Drawing.Point(292, 303);
            this.BT_AdminUpdate.Name = "BT_AdminUpdate";
            this.BT_AdminUpdate.Size = new System.Drawing.Size(75, 23);
            this.BT_AdminUpdate.TabIndex = 2;
            this.BT_AdminUpdate.Text = "Update";
            this.BT_AdminUpdate.UseVisualStyleBackColor = true;
            this.BT_AdminUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // BT_AdminSave
            // 
            this.BT_AdminSave.Location = new System.Drawing.Point(578, 303);
            this.BT_AdminSave.Name = "BT_AdminSave";
            this.BT_AdminSave.Size = new System.Drawing.Size(99, 23);
            this.BT_AdminSave.TabIndex = 3;
            this.BT_AdminSave.Text = "Save Changes";
            this.BT_AdminSave.UseVisualStyleBackColor = true;
            this.BT_AdminSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // BT_AdminEdit
            // 
            this.BT_AdminEdit.Location = new System.Drawing.Point(442, 303);
            this.BT_AdminEdit.Name = "BT_AdminEdit";
            this.BT_AdminEdit.Size = new System.Drawing.Size(75, 23);
            this.BT_AdminEdit.TabIndex = 4;
            this.BT_AdminEdit.Text = "Edit";
            this.BT_AdminEdit.UseVisualStyleBackColor = true;
            this.BT_AdminEdit.Click += new System.EventHandler(this.BT_AdminEdit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 439);
            this.Controls.Add(this.BT_AdminEdit);
            this.Controls.Add(this.BT_AdminSave);
            this.Controls.Add(this.BT_AdminUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BT_AdminAdd;
        private System.Windows.Forms.TextBox TB_AdminPassword;
        private System.Windows.Forms.Label LB_AdminPassword;
        private System.Windows.Forms.TextBox TB_AdminUsername;
        private System.Windows.Forms.Label LB_AdminUsername;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_AdminUpdate;
        private System.Windows.Forms.Button BT_AdminSave;
        private System.Windows.Forms.Button BT_AdminEdit;
    }
}