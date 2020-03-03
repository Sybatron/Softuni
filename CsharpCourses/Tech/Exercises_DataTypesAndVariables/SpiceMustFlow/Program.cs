using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yieldCapacity = int.Parse(Console.ReadLine());
            int totalSpices = 0;
            int days = 0;
            for (int i = 100; i <= yieldCapacity;)
            {
                totalSpices += yieldCapacity;
                yieldCapacity -= 10;
                totalSpices -= 26;
                days++;
            }
            totalSpices -= 26;
            if(totalSpices<0)
            {
                totalSpices = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalSpices);
        }
    }
}
