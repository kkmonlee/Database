using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class ClientMain : Form
    {
        public ClientMain()
        {
            InitializeComponent();
            //Login signin = new Login(ident);
            //signin.Show();
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command = new OleDbCommand();
        }

        private void BT_ClientSave_Click(object sender, EventArgs e)
        {
            //OleDbConnection connection = new OleDbConnection();
            OleDbConnection connection =
                new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False");
            connection.Open();
            string height = TB_ClientHeight.Text;
            string weight = TB_ClientWeight.Text;
            string name = TB_ClientName.Text;
            string bday = dateTimePicker1.Value.ToString("d//m/Y");

        }

        

    }
}
