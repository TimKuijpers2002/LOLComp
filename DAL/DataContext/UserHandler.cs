using DTO;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataContext
{
    public class UserHandler : IUserHandler
    {
        private DBConnectionHandler _dbCon;

        public UserHandler(DBConnectionHandler dbCon)
        {
            _dbCon = dbCon;
        }

        public void CreateUser(UserDTO U1)
        {
            using (_dbCon.Open())
            {
                string query = "INSERT INTO User (UserID, Name, Email, Password) VALUES (@UserID, @Name, @Email, @Password);";
            }
        }

        public void DeleteUser(int UserID)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO U1)
        {
            throw new NotImplementedException();
        }
    }
}
