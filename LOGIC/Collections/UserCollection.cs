using DAL_Factory;
using DTO;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LOGIC.ModelConverters;
using LOGIC.Validations;

namespace LOGIC.Collections
{
    public class UserCollection
    {
        private readonly DTOAndLOGICConverters converter;
        private List<User> users;
        private readonly UserValidation userValidations;

        public UserCollection()
        {
            converter = new DTOAndLOGICConverters();
            userValidations = new UserValidation();
        }
        public void CreateUser(User user)
        {
            if (!userValidations.CheckIfUserExists(user.Email))
            {
                Factory.UserConnectionHandler.CreateUser(converter.ConvertToUserDTO(user));
            }
            else
            {
                throw new Exception("This email is already in use, try a different one");
            }
        }

        public List<User> GetUsers()
        {
            var userDTOs = Factory.UserConnectionHandler.GetUsers();
            users = new List<User>();
            foreach(var userDTO in userDTOs)
            {
                users.Add(converter.ConvertToUser(userDTO));
            }
            return users;
        }

        public void DeleteUser(string email)
        {
            var userDTOs = GetUsers();
            var userToDelete = userDTOs.Where(u => u.Email == email).ToList().First();
            Factory.UserConnectionHandler.DeleteUser(userToDelete.UserID);
        }

        public User GetUserByEmail(string email)
        {
            users = new List<User>();
            var userDTOs = Factory.UserConnectionHandler.GetUserWithEmail(email);
            foreach (var userDTO in userDTOs)
            {
                users.Add(converter.ConvertToUser(userDTO));
            }
            return users.First();
        }

        public string ValidateLogin(User user)
        {
            var result = converter.ConvertToUserDTO(user);
            string userresult = Factory.UserConnectionHandler.Login(result);
            return userresult;
        }
    }
}
