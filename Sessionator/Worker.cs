using System;
using System.Data;
using System.Data.OleDb;
using Domain;

namespace Sessionator
{
    public class Worker
    {
        private OleDbCommand command;
        private OleDbConnection connection;

        public Worker()
        {
            ConnectTo();
        }

        private void ConnectTo()
        {
            connection =
                new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public void Insert(Person p)
        {
            try
            {
                command.CommandText = "INSERT INTO TPersons ([UserName], [PassWord]) VALUES('" + p.UserName + "', '" +
                                      p.PassWord + "')";
                // thanks to HansUp
                // http://stackoverflow.com/questions/18222856/syntax-error-in-insert-into-statement-using-oledb
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}