using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Sessionator;


namespace Database
{
    public partial class ClientMain : Form
    {
        public string usernamestringo;
        public string passwordstringo;
        public ClientMain()
        {
            
            InitializeComponent();
            
            //Login signin = new Login(ident);
            //signin.Show();
            
            
        }

        private void BT_ClientSave_Click(object sender, EventArgs e)
        {
            try
            {


                string height = TB_ClientHeight.Text;
                string weight = TB_ClientWeight.Text;
                string name = TB_ClientName.Text;
                string bday = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                int heightint = Convert.ToInt32(height);
                int weightint = Convert.ToInt32(weight);
                // MessageBox.Show(bdint.ToString());
   
                usernamestringo = Login.usernameFromLogin;
                passwordstringo = Login.passwordFromLogin;

                
                using (OleDbConnection myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=O:\Repos\Database\Database.accdb;Persist Security Info=False"))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    string query =
                        "UPDATE TPersons SET [Name]=@Name, Height=@Height, Weight=@Weight, Bday=@Bday " + " WHERE UserName= @username";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Name", name.ToString());
                    cmd.Parameters.AddWithValue("@Height", heightint.ToString());
                    cmd.Parameters.AddWithValue("@Weight", weightint.ToString());
                    cmd.Parameters.AddWithValue("@Bday", bday.ToString());
                    cmd.Parameters.AddWithValue("@username", usernamestringo);
                    
                    cmd.Connection = myCon;
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.Parameters.Clear();
                }

                

            }
            catch (OleDbException exception)
            {
                string errorMessages = "";
                for (int i = 0; i < exception.Errors.Count; i++)
                {
                    var oleDbError = exception.Errors[i];
                    if (oleDbError != null)
                        errorMessages += "Index #" + i + "\n" +
                                         "NativeError: " + oleDbError.NativeError + "\n" +
                                         "Source: " + oleDbError.Source + "\n" +
                                         "SQLState: " + oleDbError.SQLState + "\n" +
                                         "Description: " + oleDbError.Message + "\n" +
                                         "Please consult with the software developer.";
                }
                MessageBox.Show(errorMessages.ToString());
            }
        }

        private void ClientMain_Load(object sender, EventArgs e)
        {

        }

        

    }
}
