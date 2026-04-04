using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class UserSession
    {
        public User CurrentUser { get; private set; }

        public void SignIn(User user)
        {
            CurrentUser = user;
        }

        public void SignOut()
        {
            CurrentUser = null;
        }
    }
}
