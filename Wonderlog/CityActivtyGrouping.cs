using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{
    public class CityActivtyGrouping
    {
        /*
        You are given a list of activities and the city they are in. Your goal is to group these activities by city.

        Output Specification
        For each city, print the city name followed by a colon and a space, then a comma-separated list of its activities. The cities should be listed in alphabetical order. The activities for each city should also be sorted alphabetically.

        Sample Input
        Paris,Eiffel Tower
        London,British Museum
        Paris,Louvre Museum
        Rome,Colosseum
        London,Tower of London

        Sample Output
        London: British Museum,Tower of London
        Paris: Eiffel Tower,Louvre Museum
        Rome: Colosseum
        */

        public static void CityActivity(params string[] userInput)
        {
            // Dictionary to group activities by city
            var activitiesDict = new Dictionary<string, List<string>>();

            // Loop through each input string
            foreach (var events in userInput)
            {
                // Split input into city and activity
                var parts = events.Split(",");
                var city = parts[0];
                // If city is not in the dictionary, add it with a new list
                if (!activitiesDict.ContainsKey(city))
                {
                    activitiesDict[city] = new List<string>();
                }
                // Add the activity to the city's list
                activitiesDict[city].Add(parts[1]);
            }

            // Get all city names and sort them alphabetically
            var cityNames = new List<string>(activitiesDict.Keys);
            cityNames.Sort();

            // For each city, sort its activities and print in required format
            foreach (var city in cityNames)
            {
                // Sort activities for each city alphabetically
                activitiesDict[city].Sort();

                // Join activities with commas
                string activities = string.Join(",", activitiesDict[city]);

                // Print city and its activities in the required format
                System.Console.WriteLine($"{city}: {activities}");
            }

        }
        
    }
}