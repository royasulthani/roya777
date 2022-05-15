using System;

namespace task_14_may
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silahin adini daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Silahin capacity-ni daxil edin:");
            int capacity;
            do
            {
                capacity = Convert.ToInt32(Console.ReadLine());
            } while (capacity<0);
            Console.WriteLine("Silahin cari gulle sayini daxil edin");
            int nowCap;
            do
            {
                nowCap = Convert.ToInt32(Console.ReadLine());
            } while (nowCap<0|| capacity<nowCap);
            Weapon weapon1 = new Weapon(name, capacity, nowCap);
            Console.WriteLine(weapon1.ShowInfo());
            Console.WriteLine("Atis modu");
            string ChangeFireMode = Console.ReadLine();
            switch (Console.ReadLine())
            {
                case "1":
                    weapon1.Shoot();

            }
        }
    }
}
