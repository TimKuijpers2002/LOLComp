using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IUserHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="U1"></param>
        /// <exception cref="ArgumentException"></exception>
        void CreateUser(UserDTO U1);
        List<UserDTO> GetUsers();
        void UpdateUser(UserDTO U1, int userID);
        void DeleteUser(int UserID);
        List<UserDTO> GetUserWithEmailAndPassword(string email, string password);
        List<UserDTO> GetUserWithEmail(string email);
        string Login(UserDTO user);
    }
}
