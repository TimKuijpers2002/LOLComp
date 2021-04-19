using DTO;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                string query = "INSERT INTO User (Name, Email, Password) VALUES (@Name, @Email, @Password);";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@Name", U1.Name);
                    command.Parameters.AddWithValue("@Email", U1.Email);
                    command.Parameters.AddWithValue("@Password", U1.Password);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int UserID)
        {
            using (_dbCon.Open())
            {
                string query = "DELETE FROM User WHERE UserID=@UserID";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    _dbCon.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<UserDTO> GetUsers()
        {
            var users = new List<UserDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [dbi431200_LOLComp].[dbo].[User]";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UserDTO userDTO = new UserDTO
                        {
                            UserID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Email = reader.GetString(2),
                            Password = reader.GetString(3),

                        };

                        users.Add(userDTO);
                    }
                }
            }
            return users;
        }

        public void UpdateUser(UserDTO U1)
        {
            using (_dbCon.Open())
            {
                string query = "UPDATE User Set Name = @Name, Email = @Email, Password = @Password WHERE UserID = @UserID;";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@UserID", U1.UserID);
                    command.Parameters.AddWithValue("@Name", U1.Name);
                    command.Parameters.AddWithValue("@Email", U1.Email);
                    command.Parameters.AddWithValue("@Password", U1.Password);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<UserDTO> GetUserWithEmailAndPassword(string email, string password)
        {
            var users = new List<UserDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [dbi431200_LOLComp].[dbo].[User] WHERE Email = @Email AND Password = @Password;";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UserDTO userDTO = new UserDTO
                        {
                            UserID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Email = reader.GetString(2),
                            Password = reader.GetString(3),

                        };

                        users.Add(userDTO);
                    }
                }
            }
            return users;
        }

        public List<UserDTO> GetUserWithEmail(string email)
        {
            var users = new List<UserDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [dbi431200_LOLComp].[dbo].[User] WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UserDTO userDTO = new UserDTO
                        {
                            UserID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Email = reader.GetString(2),
                            Password = reader.GetString(3),

                        };

                        users.Add(userDTO);
                    }
                }
            }
            return users;
        }
    }
}
