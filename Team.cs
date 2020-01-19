using System;
using TheBlueAlliance;

namespace scouting
{
    public class Team
    {
        private TheBlueAlliance.Models.EventTeams.Team originalTeam;
        public int Number { get; private set; } // PRIMARY KEY
        public string Name { get; private set; }

        public Team(TheBlueAlliance.Models.EventTeams.Team team)
        {
            Number = team.team_number;
            Name = team.nickname;
        }

        public override string ToString() => Name + " #" + Number;
    }
}