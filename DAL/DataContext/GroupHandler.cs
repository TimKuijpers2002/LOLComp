using DTO;
using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL.DataContext
{
    public class GroupHandler : IGroupHandler
    {
        private DBConnectionHandler _dbCon;

        public GroupHandler(DBConnectionHandler dbCon)
        {
            _dbCon = dbCon;
        }

        public void CreateGroup(GroupDTO G1)
        {
            using (_dbCon.Open())
            {
                string query = "INSERT INTO Group (Name) VALUES (@Name);";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@Name", G1.Name);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteGroup(int GroupID)
        {
            using (_dbCon.Open())
            {
                string query = "DELETE FROM Group WHERE GroupID=@GroupID";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@GroupID", GroupID);
                    _dbCon.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<GroupDTO> GetGroups()
        {
            var groups = new List<GroupDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT * FROM [dbi431200_LOLComp].[dbo].[Group]";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        GroupDTO groupDTO = new GroupDTO
                        {
                            GroupID = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        };

                        groups.Add(groupDTO);
                    }
                }
            }
            return groups;
        }

        public void UpdateGroup(GroupDTO G1)
        {
            using (_dbCon.Open())
            {
                string query = "UPDATE Group Set Name = @Name WHERE GroupID = @GroupID;";
                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@GroupID", G1.GroupID);
                    command.Parameters.AddWithValue("@Name", G1.Name);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<GroupDTO> GetGroupsWithUserID(int userID)
        {
            var groups = new List<GroupDTO>();
            using (_dbCon.Open())
            {
                string query = "SELECT COUNT(*) FROM [dbi431200_LOLComp].[dbo].[Group] WHERE GroupID = ( SELECT GroupID FROM [dbi431200_LOLComp].[dbo].[User-Group] WHERE UserID = @UserID)";

                using (SqlCommand command = new SqlCommand(query, _dbCon.connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        GroupDTO groupDTO = new GroupDTO
                        {
                            GroupID = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        };

                        groups.Add(groupDTO);
                    }
                }
            }
            return groups;
        }
    }
}
