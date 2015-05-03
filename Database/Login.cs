using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.OleDb;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using Domain;


namespace Database
{
    //public static class ProgBarColor
    //{
    //    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
    //    static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

    //    public static void SetState(this ProgressBar pBar, int state)
    //    {
    //        SendMessage(pBar.Handle, 1040, (IntPtr) state, IntPtr.Zero);
    //    }
    //}

    public partial class Login : Form
    {
        
        public static string usernameFromLogin;
        public static string passwordFromLogin;

        public Login()
        {
            InitializeComponent();
            
        }

        public Login(string ident)
        {

            InitializeComponent();
            
            BT_toolStripAdmin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            // tried to align it to the right.
            // setting boundaries
            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Minimum = 0;
            //timer1.Enabled = true;
            toolStripStatusLabel1.Visible = false;
            TB_LoginUsername.Text = ident;
        }

        public static string UsernameFromLogin
        {
            get { return usernameFromLogin; }
            set { usernameFromLogin = value; }
        }


        private void BT_LoginLogin_Click(object sender, EventArgs e)
        {
            #region "Timer arguments"
            this.timer1.Start();
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Loading";
            #endregion
            #region "Create user arguments"
            try
            {

                usernameFromLogin = TB_LoginUsername.Text;
                string constring =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False";
                OleDbConnection connection = new OleDbConnection(constring);
                OleDbCommand command = new OleDbCommand("SELECT * FROM TPersons WHERE UserName='" + this.TB_LoginUsername.Text + "' AND PassWord='" + this.TB_LoginPassword.Text + "';", connection);
                OleDbDataReader reader;
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    {
                        if (
                            MessageBox.Show("Login successful!", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            var clientForm = new ClientMain();
                            ////var loginForm = new Login();
                            //clientForm.Show();
                            ////loginForm.Close();
                            ////raises exceptions, will use this in clientForm.Load()
                            ////i'll just disable this form
                            //foreach (Control c in Controls)
                            //{
                            //    c.Enabled = false;
                            //}

                            /*
                             * ShowDialog is amazing!
                             */
                            clientForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("You should've clicked OK. :(");

                        }
                       
                        
                    }
                    else if (count > 1)
                    {
                        MessageBox.Show("Duplicate username or password");
                        toolStripStatusLabel1.Visible = true;
                        toolStripStatusLabel1.Text = "Try again!";
                    }
                    else
                    {
                        MessageBox.Show("Username or password do not match.");
                        //ProgBarColor.SetState(toolStripProgressBar1, 2);
                        toolStripStatusLabel1.Visible = true;
                        toolStripStatusLabel1.Text = "Try again!";
                    }
                }
            }
            catch (OleDbException exception)
            {
                string errorMessages = "";
                for (int i = 0; i < exception.Errors.Count; i++)
                {
                    errorMessages += "Index #" + i + "\n" +
                          "Message: " + exception.Errors[i].Message + "\n" +
                          "NativeError: " + exception.Errors[i].NativeError + "\n" +
                          "Source: " + exception.Errors[i].Source + "\n" +
                          "SQLState: " + exception.Errors[i].SQLState + "\n";
                }

                System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                log.Source = "My Application";
                log.WriteEntry(errorMessages);
                Console.WriteLine(errorMessages);
                throw;
            }
            #endregion

        }

        protected void timer1_Tick(object sender, EventArgs e)
        {

            toolStripProgressBar1.Value += 25;
            //else if (toolStripProgressBar1.Value > 0)
            //{
            //    toolStripProgressBar1.Value = 0;
            //    toolStripProgressBar1.Value += 25;
            //}
            
            


            /// could invert if to prevent nesting
            /// 
            ///  if (toolStripProgressBar1.Value != 100) return;
            /// var mainForm = new Main();
            /// mainForm.Show();
            /// this.Hide(); // hides the login, i'll need this later
            ///timer1.Stop();
            /// 
            
            if (toolStripProgressBar1.Value == 100)
            {
                // Client Form opens

                toolStripProgressBar1.Value = 0;
                //this.Hide(); // hides the login, i'll need this later
                timer1.Stop();
                toolStripStatusLabel1.Text = "Loaded!";


            }
            /// <summary>
            /// Diagnostics
            ///else if (Application.OpenForms.OfType<Main>().Any())
            ///{
            ///    timer1.Enabled = false;
            ///    MessageBox.Show("Form is open Atul");
            ///}
            /// </summary>

        }

        private void BT_toolStripAdmin_Click(object sender, EventArgs e)
        {
            var mainForm = new Admin();
            mainForm.Show();
        }

        private void LB_LoginRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new ClientRegister();
            registerForm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = false;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TB_LoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_LoginLogin.PerformClick();
                // time to stop the handling errors
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void TB_LoginUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BT_LoginLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void BT_LoginLogin_KeyDown(object sender, KeyEventArgs e)
        {
            BT_LoginLogin.PerformClick();
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        

    }
}

