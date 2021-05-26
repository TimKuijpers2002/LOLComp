using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace DAL.DataContext
{
    public class DBConnectionHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }
        public SqlConnection Connection { get; private set; }
        public SqlConnection Open()
        {
            Connection = new SqlConnection(connectionString);
            if (!isAvailable(Connection))
            {
                throw new Exception("There was an error trying to form a connection, try again later");
            }
            Connection.Open();
            return Connection;
        }

        private bool isAvailable(SqlConnection connection)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
