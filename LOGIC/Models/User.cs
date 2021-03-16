using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models
{
    public class User
    {
        public int UserID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public User(int userID, string name, string email, string password)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Password = password;
        }

        public void DeleteUser(int userID)
        {

        }

        public void UpdateUser(User user)
        {
            //UserDTO _user = new UserDTO;


        }
    }
}
