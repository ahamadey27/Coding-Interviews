using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{

    /*You are given a list of hotels and their ratings. Your task is to filter this list and display only the hotels that have a rating of 8.5 or higher.

    Input Specification
    The first line will contain an integer N (1leN
    le100), the number of hotels.
    The next N lines will each contain a hotel name (a string that may include spaces) followed by a comma, and then a floating-point number representing its rating R (1.0
    leR
    le10.0).

    Output Specification
    Print the names of the hotels with a rating of 8.5 or higher, each on a new line, in the same order they appeared in the input.
    Sample Input

    Sample Input
    Grand Hyatt,8.2
    The Peninsula,9.1
    Four Seasons,9.4
    Motel 3, 3.5
    Motel 6,4.5
    Ritz Carlton,8.9

    sample Output
    The Peninsula
    Four Seasons
    Ritz Carlton
    */
    public class HighRatedHotels
    {
        public static void HotelFunction()
        {
            Dictionary<string, decimal> hotelDictionary = new Dictionary<string, decimal>
            {
                {"Grand Hyatt", 8.2m},
                {"The Peninsula", 9.1m},
                {"Four Seasons", 9.4m},
                {"Motel 3", 3.5m},
                {"Motel 6", 4.5m},
                {"Ritz Carlton", 8.9m}
            };

            decimal threshold = 8.5m;
        }
       

    }
}