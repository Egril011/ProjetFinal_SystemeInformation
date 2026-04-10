using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectMembersRepository
    {
        public void AddMemberToProject(ProjectMember projectMember)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO ProjectMembers (ProjectId, UserId, Role, JoinedAt) " +
                    "VALUES (@projectId, @userId, @role, @JoinedAt)";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectMember.ProjectId);
                    command.Parameters.AddWithValue("@userId", projectMember.UserId);
                    command.Parameters.AddWithValue("@role", (int)projectMember.ProjectRole);
                    command.Parameters.AddWithValue("@JoinedAt", projectMember.JoinedAt);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveAllMembersFromProject(int projectId)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM ProjectMembers WHERE ProjectId = @projectId";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveMemberFromProject(int projectId, int userId)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM ProjectMembers " +
                    "WHERE ProjectId = @projectId AND UserId = @userId";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool MemberExists(int projectId, int userId)
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

        public int GetProjectLeaderId(int projectId)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();

                string query = "SELECT UserId FROM ProjectMembers " +
                    "WHERE ProjectId = @projectId AND Role = @role";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@role", (int)ProjectRole.Leader);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["UserId"]);
                        }
                    }
                }
            }

            return -1;
        }

        public bool IsUserProjectOwner(int projectId, int userId)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM ProjectMembers " +
                    "WHERE ProjectId = @projectId AND UserId = @userId AND Role = @role";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@role", (int)ProjectRole.Leader);
                    if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        public List<int> GetProjectMembers(int projectId)
        {
            List<int> members = new List<int>();
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();

                string query = "SELECT UserId FROM ProjectMembers " +
                    "WHERE ProjectId = @projectId";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            members.Add(Convert.ToInt32(reader["UserId"]));
                        }
                    }
                }
            }

            return members;
        }
    }
}