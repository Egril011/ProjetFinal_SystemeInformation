using Microsoft.Data.Sqlite;

namespace ProjetFinal_SystemeInformation
{
    internal class AuthService
    {
        UserRepository _userRepository = new UserRepository();

        public bool CreateUser(User user)
        {
            if(_userRepository.EmailExists(user.Email))
                return false;

            user.Password = PasswordManager.HashPassword(user, user.Password);
            _userRepository.CreateUser(user);

            return true;
        }

        public User? SignIn(string email, string password)
        {
            User? user = _userRepository.GetUserByEmail(email);
            if (user == null)
                return null;

            if (!PasswordManager.VerifyPassword(user, password))
                return null;

            return user;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
    }
}