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
            List<string> usersTripsAmount = new List<string>
            {
                "peter:trip101",
                "harry:trip203",
                "peter:trip102",
                "sally:trip300",
                "harry:trip204",
                "peter:trip103"
            };



        }

    }
}