using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models.APIModels
{
    public class Participant
    {
        public int participantId { get; private set; }
        public int championId { get; private set; }
        public List<Rune> runes { get; private set; }
        public ParticipantStats stats { get; private set; }
        public int teamId { get; private set; }
        public ParticipantTimeline timeLine { get; private set; }
        public int spell1Id { get; private set; }
        public int spell2Id { get; private set; }
        public string highestAchievedSeasonTier { get; private set; }
        public List<Mastery> masteries { get; private set; }
    }
}
