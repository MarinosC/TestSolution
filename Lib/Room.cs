using System.Collections.Generic;

namespace Lib
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public int Occupancy { get; set; }

        public static List<Room> GetRooms()
        {
            return new List<Room>
            {
                new Room { Id = 1, Name = "Room1", Occupancy = 1, Type = "Single" },
                new Room { Id = 2, Name = "Room2", Occupancy = 2, Type = "Twin" },
                new Room { Id = 3, Name = "Room3", Occupancy = 3, Type = "Family" },
                new Room { Id = 4, Name = "Room4", Occupancy = 2, Type = "Double" },
                new Room { Id = 5, Name = "Room5", Occupancy = 1, Type = "Single" },
            };
        }
    }
}