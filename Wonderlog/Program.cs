using System;
using Wonderlog; 

class Program
{
    static void Main(string[] args)
    {
        //HighRatedHotels.HotelFunction();
        //ItineraryConflict.TimeConfilct("09:00-11:30", "14:00-16:00", "11:00-13:00");
        CityActivtyGrouping.CityActivity(
            "Paris,Eiffel Tower",
            "London,British Museum",
            "Paris,Louvre Museum",
            "Rome,Colosseum",
            "London,Tower of London"
        );
    }
}