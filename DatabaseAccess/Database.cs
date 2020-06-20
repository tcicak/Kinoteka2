using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class Database
    {

        private static Database instance;

        public static Database Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

        private string connectionString = @"Data Source = 31.147.204.119\PISERVER,1433; Initial Catalog = PI20_064_DB; User = PI20_064_User; Password = :eD^?Za_";
        private SqlConnection connection;

        private Database()
        {

        }

        public void Connect()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Disconnect()
        {
            if(connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public IDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteReader();
        }

        public object GetValue(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteScalar();
        }

        public int ExecuteCommand(string command)
        {
            SqlCommand sqlCommand = new SqlCommand(command, connection);
            return sqlCommand.ExecuteNonQuery();
        }
    }
}
