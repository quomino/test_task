using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace test_task
{
    
    class DatabaseClass
    {
        NpgsqlConnection connection = new NpgsqlConnection(@"Server = localhost; Port = 5432; User Id = postgres; Password = qwerty123; Database = bank;");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public NpgsqlConnection getConnection()
        {
            return connection;
        }
    }
    
}
