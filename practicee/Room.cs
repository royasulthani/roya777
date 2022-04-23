using System;
using System.Collections.Generic;
using System.Text;

namespace practicee
{
    class Room
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte PerconCapacity { get; set; }
        public bool IsAvaliable { get; set; } = true;
        public Room(string name, double price, byte perconcapacity, bool isavaliable)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PerconCapacity = perconcapacity;
            IsAvaliable = isavaliable;
   }

        internal static bool Id(Room item)
        {
            throw new NotImplementedException();
        }

        public string ShowInfo()
        {
            return ($"Id : {Id} Name :{Name} Price :{Price} PersonCapacity:{PerconCapacity} IsAvaliable:{IsAvaliable}");
        }

    }



    }

