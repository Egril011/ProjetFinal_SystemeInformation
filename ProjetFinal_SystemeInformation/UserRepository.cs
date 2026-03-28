using Microsoft.Data.Sqlite;
namespace ProjetFinal_SystemeInformation
{
    internal class UserRepository
    {
        public bool GetEmail(string email)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string seachQuery = "SELECT COUNT(*) FROM Users WHERE Email = @email";

                using (SqliteCommand command = new SqliteCommand(seachQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public void CreateUser(User user)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();

                string insertQuery = "INSERT INTO Users (Username, Password, Email) VALUES (@username, @password, @email)";
                using (SqliteCommand command = new SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public User GetUser(string email)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "SELECT Id, Email, Password, Username FROM Users WHERE Email " +
                    "= @email";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if(!reader.Read())
                            return null;

                        User user = new User {
                            Id = Convert.ToInt32(reader["Id"]),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Username = reader["Username"].ToString()
                        };

                        return user;
                    }
                }
            }
        }
    }
}