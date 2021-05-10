﻿using DTO;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
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
                string query = "INSERT INTO [dbo].[User] (Name, Email, Password, Role) VALUES (@Name, @Email, @Password, @Role);";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@Name", U1.Name);
                    command.Parameters.AddWithValue("@Email", U1.Email);
                    command.Parameters.AddWithValue("@Password", U1.Password);
                    command.Parameters.AddWithValue("@Role", U1.Role);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int UserID)
        {
            using (_dbCon.Open())
            {
                string query = "DELETE FROM [dbo].[User] WHERE UserID=@UserID";
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
                string query = "SELECT * FROM [dbo].[User]";
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
                            Role = reader.GetString(4)

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
                string query = "UPDATE [dbo].[User] Set Name = @Name, Email = @Email, Password = @Password, Role = @Role WHERE UserID = @UserID;";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@UserID", U1.UserID);
                    command.Parameters.AddWithValue("@Name", U1.Name);
                    command.Parameters.AddWithValue("@Email", U1.Email);
                    command.Parameters.AddWithValue("@Password", U1.Password);
                    command.Parameters.AddWithValue("@Role", U1.Role);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<UserDTO> GetUserWithEmailAndPassword(string email, string password)
        {
            var users = new List<UserDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [dbo].[User] WHERE Email = @Email AND Password = @Password;";
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
                            Role = reader.GetString(4)

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
                string query = "SELECT * FROM [dbo].[User] WHERE Email = @Email";
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
                            Role = reader.GetString(4)

                        };

                        users.Add(userDTO);
                    }
                }
            }
            return users;
        }

        public string Login(UserDTO user)
        {
            using (_dbCon.Open())
            {

                using SqlCommand command = new SqlCommand("spValidateUserLogin", _dbCon.connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@LoginEmail", user.Email);
                command.Parameters.AddWithValue("@LoginPassword", user.Password);

                string result = command.ExecuteScalar().ToString();

                return result;
            }
        }
    }
}
