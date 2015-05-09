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
        //string connectionString;
        private OleDbConnection connection;
        private OleDbDataAdapter oledbAdapter;
        private OleDbCommandBuilder oledbCmdBuilder;
        //int i;
        private string Sql;
        private readonly DataSet ds = new DataSet();
        private readonly Worker w = new Worker();

        public Admin()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            BT_AdminSave.Enabled = false;
        }

        private void BT_AdminAdd_Click(object sender, EventArgs e)
        {
            var p = new Person();
            p.UserName = TB_AdminUsername.Text;
            p.PassWord = TB_AdminPassword.Text;

            w.Insert(p);
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
            Sql = "SELECT * FROM TPersons";
            try
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(Sql, connection);
                
                
                dataGridView1.DataSource = ds;
                oledbAdapter.Fill(ds);
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
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                changes = ds.GetChanges();
                if (changes != null)
                {
                    oledbAdapter.Update(ds.Tables[0]);
                }
                ds.AcceptChanges();
                MessageBox.Show("Changes have been saved.");
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
            dataGridView1.ReadOnly = false;
        }

        private void LB_AdminUsername_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }
    }
}