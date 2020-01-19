using System;
using TheBlueAlliance;

namespace scouting
{
    public class Match
    {
        private TheBlueAlliance.Models.EventMatches.Match originalMatch;
        public string Key { get; private set; } // PRIMARY KEY
        public MatchType Type { get; private set; }
        
        public int MatchNum { get; private set; }
        public string EventKey { get; private set; }
        public Alliances Alliances { get; set; } ////////////////////////////////// check
        public Match(TheBlueAlliance.Models.EventMatches.Match match) 
        {
            string key = match.key;
            EventKey = match.event_key;
            originalMatch = match;
            MatchNum = match.match_number;
            switch (match.comp_level)
            {
                case "qm": Type = MatchType.Qualification; break;
                case "qf": Type = MatchType.QuarterFinal; break;
                case "sf": Type = MatchType.SemiFinal; break;
                case "f": Type = MatchType.Final; break;
            }
        }

        public enum MatchType
        {
            Qualification, 
            QuarterFinal, 
            SemiFinal,
            Final
        }

    }
}