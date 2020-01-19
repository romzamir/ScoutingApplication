using System;
using TheBlueAlliance;
using System.Collections.Generic;

namespace scouting
{
    class Program
    {
        static string GetTeams(string[] teams)
        {
            string text = "";
            for (int i = 0; i < teams.Length; i++)
            {
                if (i != 0)
                    text += ";";
                text += teams[i];
            }
            return text;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                var temp = Events.GetEventTeamsList("2019isde2");
                foreach (var item in temp)
                {
                    if (item.team_number != 4320) continue;
                    Console.WriteLine("Team: " + item.nickname + " #" + item.team_number);
                    break;
                }
                //2019iscmp
                //2019isde2
                //Console.WriteLine(temp.event_type);
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nEXCEPTION!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(exception.ToString());
            }
        }
    }
}
