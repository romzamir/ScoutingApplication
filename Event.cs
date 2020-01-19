using System;
using TheBlueAlliance;

namespace scouting
{
    public class Event
    {
        private TheBlueAlliance.Models.Event.EventInformation originalEvent;
        public string Key { get; private set; } // PRIMARY KEY
        public string Name { get; private set; } // short_name
        public int Year { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Event(TheBlueAlliance.Models.Event.EventInformation eventInformation)
        {
            originalEvent = eventInformation;
            Key = originalEvent.key;
            Name = originalEvent.short_name;
            Year = originalEvent.year;
            string[] startDate = originalEvent.start_date.Split('-');
            StartDate = new DateTime(int.Parse(startDate[0]), int.Parse(startDate[1]), int.Parse(startDate[2]));
            string[] endDate = originalEvent.end_date.Split('-');
            EndDate = new DateTime(int.Parse(endDate[0]), int.Parse(endDate[1]), int.Parse(endDate[2]));
        }
    }
}