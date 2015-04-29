using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Sessionator;
using Domain;


namespace Database
{

    public partial class ClientRegister : Form
    {
        private Worker w = new Worker();
        public string empid;
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
            
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False"))
            {
                
                if (!empId())
                {
                }
                else
                {
                    Person p = new Person();
                    p.UserName = textBox1.Text;
                    p.PassWord = textBox3.Text;

                    w.Insert(p);

                    MessageBox.Show("unique!");
                }
            }
        }

        private bool empId()
        {
            using (
                OleDbConnection connection =
                    new OleDbConnection(
                        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False")
                )
            {
                connection.Open();
                string SqlQuery = "SELECT ID FROM TPersons WHERE UserName='" + textBox1.Text + "'";

                OleDbCommand command = new OleDbCommand(SqlQuery, connection);

                OleDbDataReader dr;

                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    empid = dr["ID"].ToString();

                    if (empid != "0")
                    {
                        MessageBox.Show("This username already exists.");

                        return false;
                    }
                    connection.Close();
                }
                return true;
            }
            
        }
        
        private void validateTextInteger(object sender, EventArgs e)
        {
            TextBox T = (TextBox) sender;

            try
            {
                char[] UnallowedCharacters = {};
            }

            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Aligns cursor to the same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception)
                {
                }

             
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex symbolPattern = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-£~¬`\s]");

            MatchCollection matches = symbolPattern.Matches(textBox1.Text);
            if (matches.Count > 0)
            {
                MessageBox.Show("You cannot use these characters!");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex symbolPattern = new Regex(@"[!'@#$%^&*()_+=\[{\]};:<>|./?,-£~¬`\s]");

            MatchCollection matches = symbolPattern.Matches(textBox1.Text);
            if (matches.Count > 0)
            {
                MessageBox.Show("You cannot use these characters!");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex symbolPattern = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-£~¬`\s]");

            MatchCollection matches = symbolPattern.Matches(textBox1.Text);
            if (matches.Count > 0)
            {
                MessageBox.Show("You cannot use these characters!");
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
            }

        }
    }

}