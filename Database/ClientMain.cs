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

        

    }
}
