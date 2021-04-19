using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IUserHandler
    {
        void CreateUser(UserDTO U1);
        List<UserDTO> GetUsers();
        void UpdateUser(UserDTO U1);
        void DeleteUser(int UserID);
        List<UserDTO> GetUserWithEmailAndPassword(string email, string password);
        List<UserDTO> GetUserWithEmail(string email);
    }
}
