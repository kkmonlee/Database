using System;
using System.Data.OleDb;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Domain;
using Sessionator;

namespace Database
{
    public partial class ClientRegister : Form
    {
        // Declaring strings in memory (Dim)
        public string empid;
        
        private readonly Worker w = new Worker();
        // Using w as a reference to the Worker.cs class library
        public ClientRegister()
        {
            InitializeComponent();
        }

        //void ClearTBoxes(DependencyObject dObject)
        //{
        //    TextBox tb = dObject as TextBox;
        //    if (tb != null)
        //        tb.Text = null;

        //    foreach (DependencyObject obj in dObject.GetChildObjects())
        //        ClearTextBoxes(obj);
        //}


        private void BT_RegisterRegister_Click(object sender, EventArgs e)
        {
            //OleDbConnection connection;

            //connection =
            //    new OleDbConnection(
            //        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False");

            using (
                var connection =
                    new OleDbConnection(
                        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False")
                )
            // Using the connection string and address:
            {
                if (!empId())
                // If the function empId() returns false then
                {
                    // Do nothing
                }
                else
                {
                    if (textBox1.Text != "" && textBox2.Text != textBox3.Text)
                    // If username textbox is not null and the password textboxes match then
                    {
                        var p = new Person();
                        // Create a new instance from Person.cs class library
                        p.UserName = textBox1.Text;
                        p.PassWord = textBox3.Text;
                        // Assign username and password textbox values to Person.cs strings
                        w.Insert(p);
                        // Run the Insert function in Worker.cs
                        MessageBox.Show("You are registered!");
                        // Show success message!
                    }
                    else
                    {
                        MessageBox.Show("Values in textboxes must be same!", "Error!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        // Show error message
                    }
                   
                }
            }
        }

        private bool empId()
        // Boolean function empId() will return either true or false
        {
            using (
                var connection =
                    new OleDbConnection(
                        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False")
                )
            // Using connection as the OleDbConnection and connection string
            {
                connection.Open();
                // Open the connection
                var SqlQuery = "SELECT ID FROM TPersons WHERE UserName='" + textBox1.Text + "'";
                // Run ADO.NET command and look for the ID where the username is the textbox value
                var command = new OleDbCommand(SqlQuery, connection);
                // Tell the OleDbCommand where it's connection string is and what the command is
                OleDbDataReader dr;
                // Create an instance dr of the OleDbDataReader
                dr = command.ExecuteReader();
                // Start reading

                while (dr.Read())
                // When it is reading
                {
                    empid = dr["ID"].ToString();
                    // The ID value is assigned to empid string
                    if (empid != "0")
                    // If the ID is not 0 then that means the ID already exists!
                    {
                        MessageBox.Show("This username already exists.");
                        // Show error message

                        return false;
                        // Return false
                    }
                    connection.Close();
                    // and close connection
                }
                return true;
                // Otherwise the username is unique and return true!
            }
        }

        private void validateTextInteger(object sender, EventArgs e)
        {
            //TextBox T = (TextBox) sender;

            //try
            //{
            //    char[] UnallowedCharacters = {};
            //}

            //catch (Exception)
            //{
            //    try
            //    {
            //        int CursorIndex = T.SelectionStart - 1;
            //        T.Text = T.Text.Remove(CursorIndex, 1);

            //        //Aligns cursor to the same index
            //        T.SelectionStart = CursorIndex;
            //        T.SelectionLength = 0;
            //    }
            //    catch (Exception)
            //    {
            //    }


            //}

            // Unexplicably redundant
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Regex symbolPattern = new Regex("^[a-zA-Z0-9]*$");

            textBox1.Text = string.Concat(textBox1.Text.Where(char.IsLetterOrDigit));
            // Every character except for letter or digits is concatenated (deleted)

            //MatchCollection matches = symbolPattern.Matches(textBox1.Text);
            //if (matches.Count > 0)
            //{
            //    MessageBox.Show("You cannot use these characters!");
            //    textBox1.Text = null;
            //    textBox2.Text = null;
            //    textBox3.Text = null;
            //}
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    var symbolPattern = new Regex(@"[!'@#$%^&*()_+=\[{\]};:<>|./?,-£~¬`\s]");

        //    var matches = symbolPattern.Matches(textBox1.Text);
        //    if (matches.Count <= 0) return;
        //    MessageBox.Show(@"You cannot use these characters!");
        //    textBox1.Text = null;
        //    textBox2.Text = null;
        //    textBox3.Text = null;
        //}

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        //    var symbolPattern = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-£~¬`\s]");

        //    var matches = symbolPattern.Matches(textBox1.Text);
        //    if (matches.Count > 0)
        //    {
        //        MessageBox.Show(@"You cannot use these characters!");
        //        textBox1.Text = null;
        //        textBox2.Text = null;
        //        textBox3.Text = null;
        //    }
        //}
    }
}