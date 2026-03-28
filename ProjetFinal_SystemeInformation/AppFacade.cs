using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    internal class AppFacade
    {
        private AuthService _authService = new AuthService();

        public bool CreateUser(User user)
        {
            return _authService.CreateUser(user);
        }

        public User SignIn(string email, string password)
        {
            return _authService.SignIn(email, password);
        }
    }
}
