using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1.DAL
{
    class DataAccess
    {
        private SqlConnection connection;

        public DataAccess()
        {
            var connectionString = Properties.Settings.Default.ConnectionUppgift1;
            connection = new SqlConnection(connectionString);
        }

        public DataSet ExecuteSelectCommand(string commandText, CommandType commandType)
        {
            //, SqlParameter[] parameters
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            SqlCommand command = connection.CreateCommand();

            command.CommandText = commandText;
            command.CommandType = commandType;
            //command.Parameters.AddRange(parameters);

            try
            {
                connection.Open();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    dataAdapter.Fill(dataTable);
                }

                dataSet.Tables.Add(dataTable);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }

            return dataSet;
        }

        public bool ExecuteNonQuery(string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            command.CommandType = commandType;
            command.Parameters.AddRange(parameters);

            int updatedLines;

            try
            {
                connection.Open();

                updatedLines = command.ExecuteNonQuery();
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }

            return updatedLines > 0;
        }
    }
}
