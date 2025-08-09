using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{
    /* You receive data as a list of username:trip_id pairs. Your task is to count how many trips each user has taken and output the results.

    Input Specification
    The first line will be an integer N (1leNle200), the number of records.
    The next N lines will each contain a string in the format username:trip_id. Usernames and trip IDs are alphanumeric strings without spaces.

    Output Specification
    Print each unique username followed by a space and their total trip count. The list should be sorted alphabetically by username.
    
    Sample Input:
    peter:trip101
    harry:trip203
    peter:trip102
    sally:trip300
    harry:trip204
    peter:trip103

    SampleOutput:
    harry 2
    peter 3
    sally 1
    */

    
    public class UserTripCounter
    {
        public static void TripCountFuntion()
        {
            // Sample data: each string is username:trip_id
            List<string> usersTripsAmount = new List<string>
            {
                "peter:trip101",
                "harry:trip203",
                "peter:trip102",
                "sally:trip300",
                "harry:trip204",
                "peter:trip103"
            };

            // Dictionary to store trip counts for each user
            var result = new Dictionary<string, int>();

            // Count trips for each user
            foreach (var item in usersTripsAmount)
            {
                // Extract username from each record
                var userName = item.Split(":")[0]; //[0] selects the first element of the array returned by the split function
                // If user already exists, increment their count
                if (result.ContainsKey(userName))
                {
                    result[userName]++;
                }
                // If user does not exist, set their count to 1
                else
                {
                    result[userName] = 1;
                }
            }

            // Get all usernames and sort them alphabetically
            var userNames = new List<string>(result.Keys);
            userNames.Sort();

            // Print each username and their trip count
            foreach (var username in userNames)
            {
                Console.WriteLine($"{username} {result[username]}");
            }

        }

    }
}