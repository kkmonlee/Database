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
using System.IO;
using System.Security.AccessControl;
using System.Runtime.InteropServices;
using ADOX;
using Domain;
using Microsoft;
using Keys = System.Windows.Forms.Keys;


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
            /*
             * Create a session database for every user
             */
            //string sessionDb = @"A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\" + TB_LoginUsername.Text.ToString() + ".accdb";
            //Microsoft.Office.Interop.Access.Application;
        }

        public static string UsernameFromLogin
        {
            get { return usernameFromLogin; }
            set { usernameFromLogin = value; }
        }


        private void BT_LoginLogin_Click(object sender, EventArgs e)
        {
            var a = 0;
            #region "Timer arguments"
            this.timer1.Start();
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Loading";
            #endregion
            #region "Create user arguments"
            try
            {
                
                a += 1;
                #region "Create log database args"
                

                Catalog cat = new CatalogClass();
                string cntPath = System.IO.Directory.GetCurrentDirectory();
                string createStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" + TB_LoginUsername.Text.ToLower() + "_LOG.accdb;";
                if (!File.Exists(cntPath + "\\" + TB_LoginUsername.Text.ToLower() + "_LOG.accdb"))
                {
                    cat.Create(createStr);
                    Table tbl = new Table();
                    tbl.Name = TB_LoginUsername.Text + "_SESSIONS";
                    tbl.Columns.Append("ID", DataTypeEnum.adInteger);
                    tbl.Columns.Append("UserName", DataTypeEnum.adVarWChar, 50);
                   // ClientMain.Load() will update UserName to TB_LoginUsername.Text or usernamestringo if you will
                    tbl.Columns.Append("Cycling", DataTypeEnum.adVarWChar, 50);
                    tbl.Columns.Append("Running", DataTypeEnum.adVarWChar, 50);
                    tbl.Columns.Append("Swimming", DataTypeEnum.adVarWChar, 50);
                    cat.Tables.Append(tbl);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(tbl);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(cat.Tables);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(cat.ActiveConnection);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(cat);
                    /*
                     * Inserting UserName into Row
                     */
                    try
                    {
                        const string empty = "";
                        ////int emptyInt = int.Parse(empty);
                        //int? emptyInt = null; // using nullable int
                        //int empInt = 0;
                        var tableau = TB_LoginUsername.Text + "_SESSIONS";
                        var usernametostring = TB_LoginUsername.Text.ToString();
                        var startPath = System.IO.Directory.GetCurrentDirectory();
                        OleDbConnection myCon =
                            new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + startPath + "\\" +
                                                TB_LoginUsername.Text.ToLower() + "_LOG.accdb;");
                        OleDbCommand cmd = new OleDbCommand();
                        
                        cmd.CommandType = CommandType.Text;
                        var query = "INSERT INTO " + tableau + " ([UserName], [ID], [Cycling], [Running], [Swimming]) VALUES(@username, @id, @cycling, @running, @swimming)";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@username", usernametostring);
                        cmd.Parameters.AddWithValue("@id", a);
                        // Has to be parsed otherwise @id returns a hash value (eg. {00000000-CF60-05B3-B1D6-020F00000000})
                        // Nope, I accidentally used DataTypeEnum.adGUID thinking that it would be the most suitable for an ID variable
                        // adInteger is way more better!
                        cmd.Parameters.AddWithValue("@cycling", empty);
                        cmd.Parameters.AddWithValue("@running", empty);
                        cmd.Parameters.AddWithValue("@swimming", empty);
                        // We don't want anything in the sports coloumns yet as that will be updated in ClientMain.Log()
                        // We just want the username so ClientMain.BT_Log() can find is using WHERE
                        cmd.Connection = myCon;
                        myCon.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Username has been entered in your session database!");
                        cmd.Parameters.Clear();
                        //myCon.Dispose();
                        
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                    
                }
                else
                {
                    //if (MessageBox.Show(
                    //    "This database already exists! Delete it from /bin/*.accdb and try again \n\nClick Retry to restart the application.",
                    //    "Error!",
                    //    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    //{
                    //    Application.Restart();
                    //}
                    //else
                    //{
                    //    this.Close();
                    //}
                }
                
                #endregion

                usernameFromLogin = TB_LoginUsername.Text;
                const string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False";
                OleDbConnection connection = new OleDbConnection(constring);
                OleDbCommand command = new OleDbCommand("SELECT * FROM TPersons WHERE UserName='" + this.TB_LoginUsername.Text + "' AND PassWord='" + this.TB_LoginPassword.Text + "';", connection);
                OleDbDataReader reader;
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    var count = 0;
                    while (reader != null && reader.Read())
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
                            connection.Dispose();
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
                var errorMessages = "";
                for (var i = 0; i < exception.Errors.Count; i++)
                {
                    var oleDbError = exception.Errors[i];
                    if (oleDbError != null)
                        errorMessages += "Index #" + i + "\n" +
                                         "Message: " + oleDbError.Message + "\n" +
                                         "NativeError: " + oleDbError.NativeError + "\n" +
                                         "Source: " + oleDbError.Source + "\n" +
                                         "SQLState: " + oleDbError.SQLState + "\n";
                }

                MessageBox.Show(errorMessages);
                throw;
            }
            #endregion
            


        }

        private void timer1_Tick(object sender, EventArgs e)
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
            if (e.KeyCode != Keys.Enter) return;
            BT_LoginLogin.PerformClick();
            // time to stop the handling errors
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        private void TB_LoginUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            BT_LoginLogin.PerformClick();
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        private void BT_LoginLogin_KeyDown(object sender, KeyEventArgs e)
        {
            BT_LoginLogin.PerformClick();
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        

    }
}

