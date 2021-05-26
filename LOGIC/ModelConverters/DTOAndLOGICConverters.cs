using DTO;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.ModelConverters
{
    public class DTOAndLOGICConverters
    {
        private User User { get; set; }
        private UserDTO UserDTO { get; set; }
        private Group Group { get; set; }
        private GroupDTO GroupDTO { get; set; }
        private Summoner Summoner { get; set; }
        private SummonerDTO SummonerDTO { get; set; }

        public User ConvertToUser(UserDTO userDTO)
        {
            User = new User(userDTO.UserID, userDTO.Name, userDTO.Email, userDTO.Password, userDTO.Role);
            return User;
        }

        public UserDTO ConvertToUserDTO(User user)
        {
            UserDTO = new UserDTO()
            {
                UserID = user.UserID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role
            };
            return UserDTO;
        }

        public Group ConvertToGroup(GroupDTO groupDTO)
        {
            Group = new Group(groupDTO.GroupID, groupDTO.Name);
            return Group;
        }

        public GroupDTO ConvertToGroupDTO(Group group)
        {
            GroupDTO = new GroupDTO()
            {
                GroupID = group.GroupID,
                Name = group.Name
            };
            return GroupDTO;
        }

        public Summoner ConvertToSummoner(SummonerDTO summonerDTO)
        {
            Summoner = new Summoner(summonerDTO.ID, summonerDTO.AccountID, summonerDTO.PuuID, summonerDTO.Name, summonerDTO.ProfileIconID, summonerDTO.RevisionDate, summonerDTO.SummonerLevel, summonerDTO.Region);
            return Summoner;
        }

        public SummonerDTO ConvertToGroupDTO(Summoner summoner)
        {
            SummonerDTO = new SummonerDTO()
            {
                ID = summoner.ID,
                AccountID = summoner.AccountID,
                PuuID = summoner.PuuID,
                Name = summoner.Name,
                ProfileIconID = summoner.ProfileIconID,
                RevisionDate = summoner.RevisionDate,
                SummonerLevel = summoner.SummonerLevel
            };
            return SummonerDTO;
        }
    }
}
