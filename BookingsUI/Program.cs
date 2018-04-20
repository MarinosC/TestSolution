using System;
using Lib;

namespace BookingsUI
{
    class Program
    {
        static void Main()
        {
            LoadRooms();
            BookingEngine.MakeBooking(2, DateTime.Parse("2018-04-15"), DateTime.Parse("2018-04-19"));
            BookingEngine.MakeBooking(1, DateTime.Parse("2018-04-15"), DateTime.Parse("2018-04-19"));
            BookingEngine.MakeBooking(1, DateTime.Parse("2018-04-20"), DateTime.Parse("2018-04-25"));
            BookingEngine.MakeBooking(1, DateTime.Parse("2018-04-30"), DateTime.Parse("2018-05-01"));

            var isAvailable =
                BookingEngine.SearchForAvailability(1, DateTime.Parse("2018-04-26"), DateTime.Parse("2018-04-28"));

            Console.WriteLine($"Is avalailble = {isAvailable}");
        }



        private static void LoadRooms()
        {
            Room.GetRooms();

        }
    }
}
