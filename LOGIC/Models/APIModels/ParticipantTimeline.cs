using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models.APIModels
{
    public class ParticipantTimeline
    {
        public int participantId { get; private set; }
        public Dictionary<string, double> csDiffPerMinDeltas { get; private set; }
        public Dictionary<string, double> damageTakenPerMinDeltas { get; private set; }
        public string role { get; private set; }
        public Dictionary<string, double> damageTakenDiffPerMinDeltas { get; private set; }
        public Dictionary<string, double> xpPerMinDeltas { get; private set; }
        public Dictionary<string, double> xpDiffPerMinDeltas { get; private set; }
        public string lane { get; private set; }
        public Dictionary<string, double> creepsPerMinDeltas { get; private set; }
        public Dictionary<string, double> goldPerMinDeltas { get; private set; }
    }
}
