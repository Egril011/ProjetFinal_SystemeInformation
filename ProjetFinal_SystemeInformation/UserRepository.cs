using Microsoft.Data.Sqlite;
namespace ProjetFinal_SystemeInformation
{
    public class UserRepository
    {
        public bool EmailExists(string email)
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

                string insertQuery = "INSERT INTO Users (Username, HashPassword, Email) " +
                    "VALUES (@username, @password, @email)";
                using (SqliteCommand command = new SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.ExecuteNonQuery();
                }
            }
        }

        public User? GetUserByEmail(string email)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();
                string query = "SELECT Id, Email, HashPassword, Username FROM Users WHERE Email " +
                    "= @email";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if(!reader.Read())
                            return null;

                        User user = new User(
                            Convert.ToInt32(reader["Id"]),
                            reader["Username"].ToString(),
                            reader["HashPassword"].ToString(),
                            reader["Email"].ToString()
                            );

                        return user;
                    }
                }
            }
        }

        public User? GetUserById(int userId)
        {
            using (var connection = DatabaseHelper.Instance.GetConnection())
            {
                connection.Open();

                string query = "SELECT Id, Email, HashPassword, Username FROM Users WHERE Id " +
                    "= @userId";
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        User user = new User(
                            Convert.ToInt32(reader["Id"]),
                            reader["Username"].ToString(),
                            reader["HashPassword"].ToString(),
                            reader["Email"].ToString()
                        );

                        return user;
                    }
                }
            }
        }
    }
}