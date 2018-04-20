using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class BookingEngine
    {
        private static readonly List<Booking> Bookings;
        static BookingEngine()
        {
            Bookings = new List<Booking>();
        }

        public static void AddBooking(int roomId, DateTime? dateFrom, DateTime? dateTo)
        {
            var booking = new Booking
            {
                RoomId = roomId,
                FromDate = dateFrom,
                ToDate = dateTo
            };
            Bookings.Add(booking);
        }

        public static bool SearchForAvailability(int roomId, DateTime? fromDate, DateTime? toDate)
        {
            if (Bookings.Count < 1)
                return true;

            bool overlaps = Bookings.Any(b => b.RoomId == roomId && fromDate <= b.ToDate && b.FromDate <= toDate);
            return !overlaps;
        }


        public static bool MakeBooking(int roomId, DateTime? dateFrom, DateTime? dateTo)
        {
            if (!SearchForAvailability(roomId, dateFrom, dateTo))
                return false;

            AddBooking(roomId, dateFrom, dateTo);
            return true;
        }

    }
}
