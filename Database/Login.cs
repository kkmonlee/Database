using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ADOX;
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
        // This string will transfer the username value to other forms

        public static string passwordFromLogin;
        // Redundant really.

        public Login()
        {
            InitializeComponent();
        }

        public Login(string ident)
        {
            InitializeComponent();

            BT_toolStripAdmin.Alignment = ToolStripItemAlignment.Right;
            // tried to align it to the right.
            // setting boundaries
            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Minimum = 0;
            //timer1.Enabled = true;
            toolStripStatusLabel1.Visible = false;
            //TB_LoginUsername.Text = ident;
            /*
             * Create a session database for every user
             */
            //string sessionDb = @"A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\" + TB_LoginUsername.Text.ToString() + ".accdb";
            //Microsoft.Office.Interop.Access.Application;

            // Inexplicably negligible code.
        }

        public static string UsernameFromLogin
        {
            get { return usernameFromLogin; }
            set { usernameFromLogin = value; }
            // String changes whenever username textbox changes
        }

        private void BT_LoginLogin_Click(object sender, EventArgs e)
        {
            var a = 0;

            #region "Timer arguments"

            timer1.Start();
            // Start timer!
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Loading";
            // UI stuff
            // Shows in the bottom of the form that you are loading, etc.

            #endregion

           

            try
            {
                a += 1;
                // Increment a + 1

                

                usernameFromLogin = TB_LoginUsername.Text;
                // Declare that current username is now cloned into usernameFromLogin
                const string constring =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False";
                // Create connection string
                var connection = new OleDbConnection(constring);
                // OleDbConnection is now connected using the connection string/address
                var command =
                    new OleDbCommand(
                        "SELECT * FROM TPersons WHERE UserName='" + TB_LoginUsername.Text + "' AND PassWord='" +
                        TB_LoginPassword.Text + "';", connection);
                // OleDbCommand assigns command the new instance and the ADO.NET query
                // Select everything from the TPersons table where the username and password are equal to the textbox values
                OleDbDataReader reader;
                // Create a OleDbDataReader instance to read data
                {
                    connection.Open();
                    // Open this node
                    reader = command.ExecuteReader();
                    // Execute and run the reader
                    var count = 0;
                    // Error counter
                    while (reader != null && reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count == 1)
                    // If count is exactly equal to 1 then:
                    {
                        if (
                            MessageBox.Show("Login successful!", "Success!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information) == DialogResult.OK)
                            // Show success message!
                            // If OK is pressed in success message then
                        {
                            using (var clientForm = new ClientMain())
                            // Create an instance of ClientMain form
                            {
                                clientForm.ShowDialog();
                                // Show it
                            }
                            connection.Dispose();
                            // Dispose the connection to prevent future mishaps
                            #region "Create log database args"
                            // If the user is new, they might now have a training record database.
                            // This creates it for them

                            Catalog cat = new CatalogClass();
                            // Create a new catalog using the CatalogClass instance
                            var cntPath = Directory.GetCurrentDirectory();
                            // Declare local directory
                            var createStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + cntPath + "\\" +
                                            TB_LoginUsername.Text.ToLower() + "_LOG.accdb;";
                            // Connection string with local directory and the lowercase username_LOG.accdb
                            if (!File.Exists(cntPath + "\\" + TB_LoginUsername.Text.ToLower() + "_LOG.accdb"))
                            // If the file doesn't exist (if the user is new or file got deleted) then
                            {
                                cat.Create(createStr);
                                // Create the connection string
                                var tbl = new Table();
                                // Create a new table
                                tbl.Name = TB_LoginUsername.Text + "_SESSIONS";
                                // Table shall be called the username_SESSIONS
                                tbl.Columns.Append("ID", DataTypeEnum.adInteger); 
                                // Add an ID column only for integers
                                tbl.Columns.Append("UserName", DataTypeEnum.adVarWChar, 100);
                                // Create a username column only for shorttext. Max limit is 100.
                                // ClientMain.Load() will update UserName to TB_LoginUsername.Text or usernamestringo if you will
                                tbl.Columns.Append("Cycling", DataTypeEnum.adVarWChar, 100);
                                // Create a cycling column only for shorttext. Max limit is 100.
                                tbl.Columns.Append("Running", DataTypeEnum.adVarWChar, 100);
                                // Create a running column only for shorttext. Max limit is 100.
                                tbl.Columns.Append("Swimming", DataTypeEnum.adVarWChar, 100);
                                // Create a swimming column only for shorttext. Max limit is 100.
                                cat.Tables.Append(tbl);
                                // Append changes to the table
                                Marshal.FinalReleaseComObject(tbl);
                                Marshal.FinalReleaseComObject(cat.Tables);
                                Marshal.FinalReleaseComObject(cat.ActiveConnection);
                                Marshal.FinalReleaseComObject(cat);
                                // Use System.InteropServices and Marshal to create the table

                                /*
                                 * Inserting UserName into Row
                                 */
                                try
                                {
                                    const string empty = "";
                                    // Empty string to use this as a placeholder for cells we are not filling right now

                                    ////int emptyInt = int.Parse(empty);
                                    //int? emptyInt = null; // using nullable int
                                    //int empInt = 0;
                                    var tableau = TB_LoginUsername.Text + "_SESSIONS";
                                    // username_SESSIONS will be the table name
                                    var usernametostring = TB_LoginUsername.Text;
                                    // Already explained :)
                                    var startPath = Directory.GetCurrentDirectory();
                                    // Declare local directory path
                                    var myCon =
                                        new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                                            startPath + "\\" +
                                                            TB_LoginUsername.Text.ToLower() + "_LOG.accdb;");
                                    
                                    // Declare connection strings
                                    var cmd = new OleDbCommand();
                                    // Create an OleDbCommand instance
                                    cmd.CommandType = CommandType.Text;
                                    var query = "INSERT INTO " + tableau +
                                                " ([UserName], [ID], [Cycling], [Running], [Swimming]) VALUES(@username, @id, @cycling, @running, @swimming)";
                                    // Declare ADO.NET query into a string
                                    cmd.CommandText = query;
                                    // The query is the command
                                    cmd.Parameters.AddWithValue("@username", usernametostring);
                                    cmd.Parameters.AddWithValue("@id", a);
                                    // Has to be parsed otherwise @id returns a graphical ID value (eg. {00000000-CF60-05B3-B1D6-020F00000000})
                                    // Nope, I accidentally used DataTypeEnum.adGUID thinking that it would be the most suitable for an ID variable
                                    // adInteger is way more better!
                                    cmd.Parameters.AddWithValue("@cycling", empty);
                                    cmd.Parameters.AddWithValue("@running", empty);
                                    cmd.Parameters.AddWithValue("@swimming", empty);
                                    // We don't want anything in the sports columns yet as that will be updated in ClientMain.Log()
                                    // We just want the username so ClientMain.BT_Log() can find is using WHERE
                                    cmd.Connection = myCon;
                                    // Declaring myCon as the connection
                                    myCon.Open();
                                    // Open the connection
                                    cmd.ExecuteNonQuery();
                                    // Execute the above command
                                    MessageBox.Show("Username has been entered in your session database!");
                                    // Show message!
                                    cmd.Parameters.Clear();
                                    // Clear verbatim values
                                    //myCon.Dispose();
                                }
                                catch (OleDbException ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                        }
                    }
                    else if (count > 1)
                    {
                        // If not then either username or password is duplicate
                        toolStripStatusLabel1.Visible = true;
                        toolStripStatusLabel1.Text = "Try again!";
                        MessageBox.Show("Duplicate username or password");
                    }
                    else
                    {
                        // Or it doesn't exist!
                        toolStripStatusLabel1.Visible = true;
                        toolStripStatusLabel1.Text = "Try again!";
                        MessageBox.Show("Username or password do not match.");
                        //ProgBarColor.SetState(toolStripProgressBar1, 2);
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
                    // Generate OleDbException message
                }

                MessageBox.Show(errorMessages);
                // Print it and throw.
                throw;
            }

            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value += 25;
            // Progress bar increments by 25 every second

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
                
                // When the progress bar reaches 100%
                // Client Form opens
                toolStripProgressBar1.Value = 0;
                // Reset the value to 0
                //this.Hide(); // hides the login, i'll need this later
                // I didn't need it later
                timer1.Stop();
                // Stop the timer
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
            // Creates an instance and opens the admin form
        }

        private void LB_LoginRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new ClientRegister();
            registerForm.Show();
            // Creates an instance and opents the registration form
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
            // When enter is pressed, login button is pressed
            #region "Timer arguments"

            timer1.Start();
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel1.Text = "Loading";

            #endregion

            // time to stop the handling errors
            e.SuppressKeyPress = true;
            e.Handled = true;
            // Handle all exceptions
        }

        private void TB_LoginUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            BT_LoginLogin.PerformClick();
            e.SuppressKeyPress = true;
            e.Handled = true;
            // Do the same when the cursor is in the textbox
        }

        private void BT_LoginLogin_KeyDown(object sender, KeyEventArgs e)
        {
            BT_LoginLogin.PerformClick();
            e.SuppressKeyPress = true;
            e.Handled = true;
            // Do the same when the cursor is in the textbox
        }
    }
}