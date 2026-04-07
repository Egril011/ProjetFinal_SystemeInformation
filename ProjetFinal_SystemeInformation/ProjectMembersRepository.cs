using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectMembersRepository
    {
        public void AddMemberToProject(int projectId, int userId, ProjectRole projectRole)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO ProjectMembers (ProjectId, UserId, Role, JoinedAt) " +
                    "VALUES (@projectId, @userId, @role, @JoinedAt)";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@role", (int)projectRole);
                    command.Parameters.AddWithValue("@JoinedAt", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool ExistMember(int projectId, int userId)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM ProjectMembers " +
                    "WHERE ProjectId = @projectId AND UserId = @userId";
                
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@userId", userId);
                    
                    if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                    {
                        return true;
                    }

                    return false;  
                }
            }
        }
    }
}