using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetFinal_SystemeInformation
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }

        public User(string username, string password, string email) 
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public User(int id, string username, string password, string email) 
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
        }

        public void SetHashedPassword(string hashPassword)
        {
            Password = hashPassword;
        }
    }
}