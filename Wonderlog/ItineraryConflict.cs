using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{
    public class ItineraryConflict
    {
        /*
        You are given a list of booked events for a single day, specified by a start and end time in 24-hour format. Your task is to determine if there are any overlapping events in the itinerary. An overlap occurs if an event starts before a previous event has ended.

        Output Specification
        Print Conflict if there is at least one overlap. Otherwise, print No Conflict

        Constraints
        For any event, the end time will always be after the start time.

        Sample Input
        09:00-11:30
        14:00-16:00
        11:00-13:00

        Sample Output
        Conflict
        */

        //params lets you pass a variable number of arguments (avoid using new string[] when calling adding function parameters)
        public static void TimeConfilct(params string[] events)
        {
            //TimeSpan is used to represent time intervals
            var eventList = new List<(TimeSpan start, TimeSpan end)>();

            foreach (var evt in events)
            {
                var parts = evt.Split('-');
                var start = TimeSpan.Parse(parts[0]);
                var end = TimeSpan.Parse(parts[1]);
                eventList.Add((start, end)); //double parenthesis are used to create a tuple (a single object that holds multiple values) 

            }
        }
    }
}