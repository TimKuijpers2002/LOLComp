using DAL_Factory;
using DTO;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOGIC.Collections
{
    public class UserCollection
    {
        private List<User> users;

        public void CreateUser(User user)
        {
            var tempID = 0;
            UserDTO NewUser = new UserDTO()
            {
                UserID = tempID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };

            Factory.userConnectionHandler.CreateUser(NewUser);
        }

        public List<User> GetUsers()
        {
            var userDTOs = Factory.userConnectionHandler.GetUsers();
            users = new List<User>();
            foreach(var userDTO in userDTOs)
            {
                users.Add(new User(userDTO.UserID, userDTO.Name, userDTO.Email, userDTO.Password));
            }
            return users;
        }

        public void DeleteUser(string email)
        {
            var userDTOs = GetUsers();
            var userToDelete = userDTOs.Where(u => u.Email == email).ToList().First();
            Factory.userConnectionHandler.DeleteUser(userToDelete.UserID);
        }

        public User GetUserByEmail(string email)
        {
            var userDTOs = GetUsers();
            return userDTOs.Where(u => u.Email == email).ToList().First();
        }
    }
}
