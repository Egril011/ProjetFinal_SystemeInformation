using Microsoft.Data.Sqlite;

namespace ProjetFinal_SystemeInformation
{
    internal class AuthService
    {
        UserRepository _userRepository = new UserRepository();

        public bool CreateUser(User user)
        {
            if(_userRepository.GetEmail(user.Email))
                return false;

            user.Password = PasswordManager.HashPassword(user, user.Password);
            _userRepository.CreateUser(user);

            return true;
        }

        public User SignIn(string email, string password)
        {
            User user = _userRepository.GetUser(email);
            if (user == null)
                return null;

            if (PasswordManager.VerifyPassword(user, password))
                return user;

            return null;
        }
    }
}