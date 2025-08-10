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
            var activitiesDict = new Dictionary<string, string[]>();

            foreach (var events in userInput)
            {
                var parts = events.Split(",");
                var city = parts[0];
                var rest = new List<string>();
                for (int i = 1; i < parts.Length; i++)
                {
                    rest.Add(parts[i]);
                }


            }


        }
        
    }
}