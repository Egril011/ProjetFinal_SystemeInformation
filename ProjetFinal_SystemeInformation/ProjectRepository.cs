using Microsoft.Data.Sqlite;

namespace ProjetFinal_SystemeInformation
{
    internal class ProjectRepository
    {
        public void CreateProject(Project project)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Project (ProjectName, Course, CreatedByUserId, JoinCode, CreatedAt) " +
                    "VALUES (@Name, @Course, @UserId, @JoinCode, @Created)";

                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", project.Name);
                    command.Parameters.AddWithValue("@Course", project.Course);
                    command.Parameters.AddWithValue("@UserId", project.UserId);
                    command.Parameters.AddWithValue("@JoinCode", project.JoinCode);
                    command.Parameters.AddWithValue("@Created", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Project> GetProjectsByUserId(int userId)
        {
            List<Project> projects = new List<Project>();

            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "SELECT Id, ProjectName, Course, CreatedByUserId, JoinCode, CreatedAt " +
                    "FROM Project WHERE CreatedByUserId = @userId";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Project project = new Project
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Name = reader["ProjectName"].ToString(),
                                Course = reader["Course"].ToString(),
                                UserId = Convert.ToInt32(reader["CreatedByUserId"]),
                                JoinCode = reader["JoinCode"].ToString(),
                                Created = Convert.ToDateTime(reader["CreatedAt"])
                            };

                            projects.Add(project);
                        }
                    }
                }
            }

            return projects;
        }
    }
}