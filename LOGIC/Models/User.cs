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
        private DTOAndLOGIC Converter { get; set; }
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
            Converter = new DTOAndLOGIC();
            //FIX het tempID in controller nog!
            Factory.userConnectionHandler.UpdateUser(Converter.ConvertToUserDTO(user));
        }
    }
}
