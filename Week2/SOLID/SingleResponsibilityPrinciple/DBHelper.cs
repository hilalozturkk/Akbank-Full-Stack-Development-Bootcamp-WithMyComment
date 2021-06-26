using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    // connect to db and run command
    public class DBHelper
    {

        SqlConnection sqlConnecion = null;
        public DBHelper(string connectionString)
        {
            sqlConnecion = new SqlConnection(connectionString);
            //works with any database        
        }

        public int Execute(string commandText, Dictionary<string, object> parameters)
        { // working CreateSqlCommand , open db con. , working db , close db con, return result
            var command = CreateSqlCommand(commandText, parameters);
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        private SqlCommand CreateSqlCommand(string commandText, Dictionary<string, object> parameters)
        {//just produces command , working AddParametersToCommand , return command
            SqlCommand command = sqlConnecion.CreateCommand();
            command.CommandText = commandText;
            AddParametersToCommand(command, parameters);
            return command;
        }

        private void AddParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {// just add parameters to the command
            foreach (var item in parameters)

            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
        }
    }
}
//new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
