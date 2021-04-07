﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL.DataContext
{
    public class DBConnectionHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }
        public SqlConnection connection { get; private set; }
        public SqlConnection Open()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
