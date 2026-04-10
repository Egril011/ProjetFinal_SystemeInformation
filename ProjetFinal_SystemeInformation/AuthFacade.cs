using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class AuthFacade
    {
        private AuthService _authService;
        private UserSession _userSession;

        public AuthFacade(AuthService authService, UserSession userSession)
        {
            _authService = authService;
            _userSession = userSession;
        }

        public User? CurrentUser => _userSession.CurrentUser;

        public bool CreateUser(User user)
        {
            return _authService.CreateUser(user);
        }

        public bool SignIn(string email, string password)
        {
            User? user = _authService.SignIn(email, password);
            if (user == null)
                return false;
           
            _userSession.SignIn(user);
            return true;
        }

        public void SignOut()
        {
            _userSession.SignOut();
        }

        public User? GetUserById(int id)
        {
            return _authService.GetUserById(id);
        }
    }
}