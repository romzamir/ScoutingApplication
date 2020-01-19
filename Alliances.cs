using System;
using TheBlueAlliance;

namespace scouting
{
    public class Alliances
    {
        public string Blue { get; private set; }
        public string Red { get; private set; }
        
        public Alliances(Team[] blues, Team[] reds)
        {
            foreach (Team team in blues)
                Blue += team.Number + ";";
            foreach (Team team in reds)
                Red += team.Number + ";";

            
            if (Blue[Blue.Length - 1] == ';')
                Blue = Blue.Remove(Blue.Length - 1);
            if (Red[Red.Length - 1] == ';')
                Red = Red.Remove(Red.Length - 1);
        }

        public override string ToString() => Blue + "|" + Red;
    }
}