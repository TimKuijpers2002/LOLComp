using DAL_Factory;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Validations
{
    public class UserValidation
    {
        public bool CheckIfUserExists(string email)
        {
            var users = new List<User>();
            var userDTOs = Factory.UserConnectionHandler.GetUserWithEmail(email);
            foreach (var userDTO in userDTOs)
            {
                users.Add(new User(userDTO.UserID, userDTO.Name, userDTO.Email, userDTO.Password, userDTO.Role));
            }
            return users.Count == 1 ? true : false;
        }
    }
}
