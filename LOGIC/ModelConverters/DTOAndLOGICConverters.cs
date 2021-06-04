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
        private Match Match { get; set; }
        private MatchDTO MatchDTO { get; set; }

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
            Group = new Group(groupDTO.GroupID, groupDTO.Name, groupDTO.Email, groupDTO.SummonerAccountID);
            return Group;
        }

        public GroupDTO ConvertToGroupDTO(Group group)
        {
            GroupDTO = new GroupDTO()
            {
                GroupID = group.GroupID,
                Name = group.Name,
                Email = group.Email,
                SummonerAccountID = group.SummonerAccountID
            };
            return GroupDTO;
        }

        public Summoner ConvertToSummoner(SummonerDTO summonerDTO)
        {
            Summoner = new Summoner(summonerDTO.ID, summonerDTO.AccountID, summonerDTO.PuuID, summonerDTO.Name, summonerDTO.ProfileIconID, summonerDTO.RevisionDate, summonerDTO.SummonerLevel, summonerDTO.Region);
            return Summoner;
        }

        public SummonerDTO ConvertToSummonerDTO(Summoner summoner)
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

        public Match ConvertToMatch(MatchDTO matchDTO)
        {
            Match = new Match(matchDTO.gameId, matchDTO.role, matchDTO.season, matchDTO.platformId, matchDTO.champion, matchDTO.queue, matchDTO.lane, matchDTO.timestamp);
            return Match;
        }

        public MatchDTO ConvertToMatchDTO(Match match)
        {
            MatchDTO = new MatchDTO()
            {
                gameId = match.GameId,
                role = match.Role,
                season = match.Season,
                platformId = match.PlatformID,
                champion = match.Champion,
                queue = match.Queue,
                lane = match.Lane,
                timestamp = match.Timestamp
            };
            return MatchDTO;
        }
    }
}
