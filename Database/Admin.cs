using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Domain;
using Sessionator;

namespace Database
{
    public partial class Admin : Form
    {
        private DataSet changes;
        // Creating a DataSet which will store changes in the database
        //string connectionString;
        private OleDbConnection connection;
        // Creating an instance of OleDbConnection
        private OleDbDataAdapter oledbAdapter;
        // Creating an instance of OleDbDataAdapter
        // This will be the mediator from the database to the DataSet
        private string Sql;
        // Used for SQL ADO.NET command
        private readonly DataSet ds = new DataSet();
        // Another DataSet storing all the information from Database.accdb
        private readonly Worker w = new Worker();
        // Calling Worker.cs functions using this

        public Admin()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            // When form loads, dataGrid should be readonly
            BT_AdminSave.Enabled = false;
            // Save button should be disabled unless Edit button is pressed
        }

        private void BT_AdminAdd_Click(object sender, EventArgs e)
        {
            var p = new Person();
            // Creating an instance of Person.cs to use its functions and strings
            p.UserName = TB_AdminUsername.Text;
            p.PassWord = TB_AdminPassword.Text;
            // Declaring the textbox values to Person.cs strings

            w.Insert(p);
            // Using the Insert function in Person.cs through here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connectionString = @"Povider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False";
            connection =
                new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False");
            // Connection address is being declared
            Sql = "SELECT * FROM TPersons";
            // ADO.NET command is to select everything from the TPersons table

            try
            {
                connection.Open();
                // Open the connection
                oledbAdapter = new OleDbDataAdapter(Sql, connection);
                // Determine the functions representing the OleDbDataAdapter (the ADO.NET command and the connection address)
                
                dataGridView1.DataSource = ds;
                oledbAdapter.Fill(ds);
                // OleDbDataAdapter inserts data into DataSet
                dataGridView1.DataSource = ds.Tables[0];

                //oledbAdapter.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommandBuilder oledbCmdBuilder;
                // Creates an instance of the OleDbCommandBuilder
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                // Connects the command builder to the DataReadAdapter
                changes = ds.GetChanges();
                // Retrieving changes in the DataGrid
                if (changes != null)
                // If there are changes then
                {
                    oledbAdapter.Update(ds.Tables[0]);
                    // Update the database using oledbAdapter
                }
                ds.AcceptChanges();
                // DataSet accepts changes
                MessageBox.Show("Changes have been saved.");
                // MessageBox tells user that changes have been saved
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
            BT_AdminSave.Enabled = false;
            dataGridView1.ReadOnly = true;
        }

        private void BT_AdminEdit_Click(object sender, EventArgs e)
        {
            BT_AdminSave.Enabled = true;
            // After clicking the Edit button Save button is enabled
            dataGridView1.ReadOnly = false;
            // DataGrid can be edited
        }

        private void LB_AdminUsername_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            // Testing
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }
    }
}