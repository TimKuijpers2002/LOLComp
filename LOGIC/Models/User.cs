using DAL_Factory;
using DTO;
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

        public void UpdateUser(User user)
        {
            var tempID = 0;
            UserDTO UpdatedUser = new UserDTO()
            {
                UserID = tempID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };

            Factory.userConnectionHandler.UpdateUser(UpdatedUser);
        }
    }
}
