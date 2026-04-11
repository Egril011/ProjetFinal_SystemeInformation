using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class TaskRepository
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
                using (var command = new SqliteCommand(query, connection))
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

        public void UpdateStatus(Task task)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Tasks SET Status = @status WHERE Id = @id";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@status", (int)task.Status);
                    command.Parameters.AddWithValue("@id", task.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Task> GetAllProjectTasks(int projectId)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "SELECT Id, ProjectId, CreatedByUserId, Title, Description, " +
                    "Priority, Status, DueDate, CreatedAt FROM Tasks WHERE ProjectId = @projectId";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    using (var reader = command.ExecuteReader())
                    {
                        var tasks = new List<Task>();
                        while (reader.Read())
                        {
                            Task task = new Task(
                                Convert.ToInt32(reader["Id"]),
                                Convert.ToInt32(reader["ProjectId"]),
                                Convert.ToInt32(reader["CreatedByUserId"]),
                                Convert.ToString(reader["Title"]),
                                Convert.ToString(reader["Description"]),
                                (TaskPriority)Convert.ToInt32(reader["Priority"]),
                                (TaskStatus)Convert.ToInt32(reader["Status"]),
                                Convert.ToDateTime(reader["DueDate"]),
                                Convert.ToDateTime(reader["CreatedAt"])
                            );

                            tasks.Add(task);
                        }

                        return tasks;
                    }
                }
            }
        }
    }
}