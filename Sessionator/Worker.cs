using System;
using System.Data;
using System.Data.OleDb;
using Domain;

namespace Sessionator
{
    public class Worker
    {
        private OleDbCommand command;
        // Creates an instance of the OleDbCommand

        private OleDbConnection connection;
        // Creates an instance of the OleDbConnection

        public Worker()
        {
            ConnectTo();
            // Calls the ConnectTo() function
        }

        private void ConnectTo()
        {
            connection =
                new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\Users\Atul Anand Sinha\Documents\Visual Studio 2013\Projects\Database\Database.accdb;Persist Security Info=False");
            // connection is now given an ADO.NET connection string which it can connect to
            command = connection.CreateCommand();
            // A command is created in the connection        
        }

        public void Insert(Person p)
        {
            try
            {
                // The above command is used here
                command.CommandText = "INSERT INTO TPersons ([UserName], [PassWord]) VALUES('" + p.UserName + "', '" +
                                      p.PassWord + "')";
                // Classic ADO.NET/SQL instruction
                // thanks to HansUp
                // http://stackoverflow.com/questions/18222856/syntax-error-in-insert-into-statement-using-oledb
                command.CommandType = CommandType.Text;
                // Command type is Text
                connection.Open();
                // Opens the connection

                command.ExecuteNonQuery();
                // Executes the commnd
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                // If connection is not closed already then...
                {
                    connection.Close();
                    // ...Close it
                }
            }
        }
    }
}