using Microsoft.AspNetCore.Identity;

namespace ProjetFinal_SystemeInformation
{
    internal class PasswordManager
    {
        private static PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

        public static string HashPassword(User user, string password)
        {
            return _passwordHasher.HashPassword(user, password);
        }

        public static bool VerifyPassword(User user, string password)
        {
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, password);
            return result == PasswordVerificationResult.Success;
        }
    }
}
