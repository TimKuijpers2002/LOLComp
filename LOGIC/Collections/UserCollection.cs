﻿using DAL_Factory;
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
        private DTOAndLOGICConverters converter;
        private List<User> users;

        public UserCollection()
        {
            converter = new DTOAndLOGICConverters();
        }
        public void CreateUser(User user)
        {
            Factory.userConnectionHandler.CreateUser(converter.ConvertToUserDTO(user));
        }

        public List<User> GetUsers()
        {
            var userDTOs = Factory.userConnectionHandler.GetUsers();
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
            Factory.userConnectionHandler.DeleteUser(userToDelete.UserID);
        }

        public User GetUserByEmail(string email)
        {
            users = new List<User>();
            var userDTOs = Factory.userConnectionHandler.GetUserWithEmail(email);
            foreach (var userDTO in userDTOs)
            {
                users.Add(converter.ConvertToUser(userDTO));
            }
            return users.First();
        }

        public string ValidateLogin(User user)
        {
            var result = converter.ConvertToUserDTO(user);
            string userresult = Factory.userConnectionHandler.Login(result);
            return userresult;
        }
    }
}
