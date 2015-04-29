using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using System.Data.OleDb;

namespace Broker
{
    public class Threadinator
    {
        private OleDbConnection connection;
        private OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.15.0;Data Source=A:\Users\Atul Anand Sinha\Documents\visual studio 2013\Projects\Database\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            ConnectTo();
        }

        public void LoginSys(Person



    }
}
