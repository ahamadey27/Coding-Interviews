using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{
    public class CommonDestinations
    {
        /*
        You are given the travel histories of two users. Find all the destinations (cities) that both users have visited.

        Input Specification
        The first line contains a comma-separated list of cities visited by User A.
        The second line contains a comma-separated list of cities visited by User B.
        City names are single words.

        Output Specification
        Print the common cities, one per line, sorted alphabetically. If there are no common cities, print None.

        INPUT: 
        Paris,Tokyo,New York,Lisbon
        London,Tokyo,Rome,Paris

        OUTPUT: 
        Paris
        Tokyo
        */

        public static void CommonCities(string userA, string userB)
        {

            if (userA == null || userB == null)
            {
                System.Console.WriteLine("None");
                return;
            }

            var partsA = userA.Split(',');
            var setA = new HashSet<string>();
            foreach (var p in partsA)
            {
                var city = p.Trim();
                if (city.Length > 0)
                {
                    setA.Add(city);
                }
            }

            var partsB = userB.Split(',');
            var matches = new HashSet<string>();
            foreach (var q in partsB)
            {
                var city = q.Trim();
                if (setA.Contains(city))
                {
                    matches.Add(city);
                }
            }

            if (matches == null)
            {
                System.Console.WriteLine("no matches");
            }
            else
            {
                List<string> finalList = matches.ToList();
                finalList.Sort();
                foreach (string name in finalList)
                {
                    System.Console.WriteLine(name);
                }
                
            }
           
            

        }
        
        
        
        
    }
}