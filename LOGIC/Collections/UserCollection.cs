using DAL_Factory;
using DTO;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LOGIC.ModelConverters;
namespace LOGIC.Collections
{
    public class UserCollection
    {
        private DTOAndLOGIC Converter { get; set; }
        private List<User> users { get; set; }

        public UserCollection()
        {
            Converter = new DTOAndLOGIC();
        }
        public void CreateUser(User user)
        {
            //FIX het tempID in controller nog!
            Factory.userConnectionHandler.CreateUser(Converter.ConvertToUserDTO(user));
        }

        public List<User> GetUsers()
        {
            var userDTOs = Factory.userConnectionHandler.GetUsers();
            users = new List<User>();
            foreach(var userDTO in userDTOs)
            {
                users.Add(Converter.ConvertToUser(userDTO));
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
            users = new List<User>();
            var userDTOs = Factory.userConnectionHandler.GetUserWithEmail(email);
            foreach (var userDTO in userDTOs)
            {
                users.Add(Converter.ConvertToUser(userDTO));
            }
            return users.First();
        }

        public User GetUserByEmailAndPassword(string email,string password)
        {
            users = new List<User>();
            var userDTOs = Factory.userConnectionHandler.GetUserWithEmailAndPassword(email, password);
            foreach (var userDTO in userDTOs)
            {
                users.Add(Converter.ConvertToUser(userDTO));
            }
            return users.First();
        }

        public string ValidateLogin(User user)
        {
            var result = Converter.ConvertToUserDTO(user);
            string userresult = Factory.userConnectionHandler.Login(result);
            return userresult;
        }
    }
}
