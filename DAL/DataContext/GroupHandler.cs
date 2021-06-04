using DTO;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL.DataContext
{
    public class GroupHandler : IGroupHandler
    {
        private readonly DBConnectionHandler _dbCon;

        public GroupHandler(DBConnectionHandler dbCon)
        {
            _dbCon = dbCon;
        }

        public void CreateGroup(GroupDTO Group, UserDTO User)
        {
            using (_dbCon.Open())
            {
                string query = "INSERT INTO [Group] (Name, Email, SummonerAccountID) VALUES (@Name, @Email, @SummonerAccountID);";
                using SqlCommand command = new SqlCommand(query, _dbCon.Connection);
                command.Parameters.AddWithValue("@Name", Group.Name);
                command.Parameters.AddWithValue("@Email", Group.Email);
                command.Parameters.AddWithValue("@SummonerAccountID", Group.SummonerAccountID);

                command.ExecuteNonQuery();

                ConnectUserAndGroup(Group.Name, User);
            }
        }

        public void DeleteGroup(int GroupID)
        {
            using (_dbCon.Open())
            {
                string query = "DELETE FROM [Group] WHERE GroupID=@GroupID";
                using SqlCommand command = new SqlCommand(query, _dbCon.Connection);
                command.Parameters.AddWithValue("@GroupID", GroupID);
                _dbCon.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<GroupDTO> GetGroups()
        {
            var groups = new List<GroupDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [Group]";
                using SqlCommand command = new SqlCommand(query, _dbCon.Connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GroupDTO groupDTO = new GroupDTO
                    {
                        GroupID = Convert.ToInt32(reader["GroupID"]),
                        Name = Convert.ToString(reader["Name"]),
                        Email = Convert.ToString(reader["Email"]),
                        SummonerAccountID = Convert.ToString(reader["SummonerAccountID"]),
                    };

                    groups.Add(groupDTO);
                }
            }
            return groups;
        }

        public void UpdateGroup(GroupDTO Group)
        {
            using (_dbCon.Open())
            {
                string query = "UPDATE [Group] Set Name = @Name WHERE GroupID = @GroupID;";
                using SqlCommand command = new SqlCommand(query, _dbCon.Connection);
                command.Parameters.AddWithValue("@GroupID", Group.GroupID);
                command.Parameters.AddWithValue("@Name", Group.Name);

                command.ExecuteNonQuery();
            }
        }

        public List<GroupDTO> GetGroupsWithUserID(int userID)
        {
            var groups = new List<GroupDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [Group] JOIN [User-Group] ON [Group].GroupID = [User-Group].GroupID WHERE [User-Group].UserID = @UserID;";

                using SqlCommand command = new SqlCommand(query, _dbCon.Connection);
                command.Parameters.AddWithValue("@UserID", userID);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GroupDTO groupDTO = new GroupDTO
                    {
                        GroupID = Convert.ToInt32(reader["GroupID"]),
                        Name = Convert.ToString(reader["Name"]),
                        Email = Convert.ToString(reader["Email"]),
                        SummonerAccountID = Convert.ToString(reader["SummonerAccountID"]),
                    };

                    groups.Add(groupDTO);
                }
            }
            return groups;
        }

        public void ConnectUserAndGroup(string groupName, UserDTO User)
        {
            using (_dbCon.Open())
            {
                string query = "INSERT INTO [User-Group] (UserID, GroupID) VALUES (@UserID, @GroupID);";
                using SqlCommand command = new SqlCommand(query, _dbCon.Connection);
                command.Parameters.AddWithValue("@GroupID", GetGroupIDWithGroupName(User.Email, groupName));
                command.Parameters.AddWithValue("@UserID", User.UserID);

                command.ExecuteNonQuery();
            }
        }

        public string GetGroupIDWithGroupName(string email, string name)
        {
            var groupIDs = new List<string>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [Group] WHERE Name = @Name AND Email = @Email;";

                using SqlCommand command = new SqlCommand(query, _dbCon.Connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Name", name);

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    groupIDs.Add(Convert.ToString(reader["GroupID"]));
                }
            }
            return groupIDs.First();
        }
    }
}
