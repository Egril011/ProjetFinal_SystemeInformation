using System;
using Microsoft.Data.Sqlite;

namespace ProjetFinal_SystemeInformation
{
    internal class DatabaseHelper
    {
        private static DatabaseHelper _instance = new DatabaseHelper();

        public static DatabaseHelper Instance => _instance;
        private string _connectionString;

        private DatabaseHelper() 
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;
            string dbPath = Path.Combine(projectPath, "DataBase", "app.db");

            _connectionString = $"Data Source={dbPath};";
        }

        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(_connectionString);
        }
    }
}