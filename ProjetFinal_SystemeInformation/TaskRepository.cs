using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class TaskRepository
    {
        public void CreateTask(Task task)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Tasks (ProjectId, CreatedByUserId, Title, Description, " +
                    "Priority, Status, DueDate, CreatedAt) " +
                    "VALUES (@projectId, @createdByUserId, @title, " +
                    "@description, @priority, @status, @dueDate, @createdAt)";
                using (var command = new Microsoft.Data.Sqlite.SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", task.ProjectId);
                    command.Parameters.AddWithValue("@createdByUserId", task.CreatedByUserId);
                    command.Parameters.AddWithValue("@title", task.Title);
                    command.Parameters.AddWithValue("@description", task.Description);
                    command.Parameters.AddWithValue("@priority", (int)task.Priority);
                    command.Parameters.AddWithValue("@status", (int)task.Status);
                    command.Parameters.AddWithValue("@dueDate", task.DueDate);
                    command.Parameters.AddWithValue("@createdAt", task.CreatedAt);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
