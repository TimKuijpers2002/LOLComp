using DAL_Factory;
using DTO;
using LOGIC.ModelConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOGIC.Models
{
    public class User
    {
        private DTOAndLOGICConverters converter;
        public int UserID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }

        public User(int userID, string name, string email, string password, string role)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
        }

        public void UpdateUser(User user)
        {
            converter = new DTOAndLOGICConverters();
            //FIX het tempID in controller nog!
            Factory.userConnectionHandler.UpdateUser(converter.ConvertToUserDTO(user));
        }
    }
}
