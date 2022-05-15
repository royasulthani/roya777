using System;
using System.Collections.Generic;
using System.Text;

namespace task_14_may
{
    class Weapon
    {
        public Weapon(string name,int capacity,int nowCap)
        {
            Id = Id++;
            Name = name;
            Capacity = capacity;
            NowCap = nowCap;
        }
        private static int _id;
        private int _capacity;
        private int _nowCap;
        public int Id { get; }
        public string Name { get; set; }
        public int NowCap { get; set; }
        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value >= 0)
                    _capacity = value;
            }
        }
        public bool ChangeFireMode = false;
        public int Count { get; set; }
        public int Shoot(int count)
        {
            return --NowCap;
        }
        public int Fire()
        {
            NowCap = 0;
            Console.WriteLine($"Gulle bitdi");
            return 0;
            {

            }
        }
        public int GetRemainBulletCount()
        {
            return Capacity - NowCap;
        }
        public void Reload()
        {
            NowCap = 30;
        }
        public string ShowInfo()
        {
            return $"\n Weapon info:\nName:{Name}\nCapacity:{Capacity}\nNowCap:{NowCap}";
        }
        public void Check { get; set; }
    }
}
