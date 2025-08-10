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
            // TimeSpan is used to represent time intervals
            var eventList = new List<(TimeSpan start, TimeSpan end)>();

            // Parse each event string into start and end times
            foreach (var evt in events)
            {
                var parts = evt.Split('-'); // Split the string into start and end time
                var start = TimeSpan.Parse(parts[0]); // Convert start time string to TimeSpan
                var end = TimeSpan.Parse(parts[1]);   // Convert end time string to TimeSpan
                eventList.Add((start, end)); // Add the tuple (start, end) to the list
            }

            // Sorts the list of events by their start time (earliest to latest)
            eventList.Sort((a, b) => a.start.CompareTo(b.start));

            // Loop through each event starting from the second one
            for (int i = 1; i < eventList.Count; i++)
            {
                // Check if the current event starts before the previous event ends (overlap)
                if (eventList[i].start < eventList[i - 1].end)
                {
                    Console.WriteLine("Conflict"); // Print "Conflict" if there is an overlap
                    return; // Exit the function since a conflict was found
                }
            }
            // If no conflicts were found, print "No Conflict" once after checking all events
            System.Console.WriteLine("No Conflict");
        }
    }
}