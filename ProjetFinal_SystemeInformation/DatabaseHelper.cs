using System;
using Microsoft.Data.Sqlite;

namespace ProjetFinal_SystemeInformation
{
    internal class DatabaseHelper
    {
        private static DatabaseHelper _instance = new DatabaseHelper();
        public static DatabaseHelper Instance => _instance;

        private string _connectionString = @"Data Source=DataBase\app.db;";

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }
    }
}
