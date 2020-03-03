using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int WaterTankCapacity = 255;
            int length = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                int PouredLiters = int.Parse(Console.ReadLine());
                if( WaterTankCapacity-PouredLiters<0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += PouredLiters;
                    WaterTankCapacity -= PouredLiters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
