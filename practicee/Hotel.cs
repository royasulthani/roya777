using System;
using System.Collections.Generic;
using System.Text;

namespace practicee
{
    class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms = new Room[0];
        private bool id;

        public void  AddRoom(int id)
        {
            foreach (var item in Rooms)
            {
                if (item.Id == id) 
                {
                    Array.Resize(ref Rooms, Rooms.Length + 1);
                    Rooms[Rooms.Length - 1] = item;
                }
            }
        }

        public Hotel(string name)
        {
            Name = name;
        }
        public void  MakeReservation(int roomId)
        {
            foreach (var item in Rooms)
            {
                if Room.Id(item)) 
                {
                    id = true;
                }
            }
           
        }
    }
}
