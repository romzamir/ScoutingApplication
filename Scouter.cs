using System;

namespace scouting
{
    public class Scouter
    {
        public int ID { get; set; } // PRIMARY KEY
        public string Name { get; set; }
        public bool Admin { get; set; }
        public string ScoutingMatches { get; set; } // matchkey;matchkey2;matchkey3
    }
}