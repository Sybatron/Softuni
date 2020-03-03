using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            BigInteger[] snowballValues = new BigInteger[count];
            BigInteger maxSnowballValue = long.MinValue;
            int[] snowballSnow = new int[count];
            int[] snowballTime = new int[count];
            int[] snowballQuality = new int[count];

            int index = 0;
            for (int i = 0; i < count; i++)
            {
                snowballSnow[i] = int.Parse(Console.ReadLine());
                snowballTime[i] = int.Parse(Console.ReadLine());
                snowballQuality[i] = int.Parse(Console.ReadLine());
                snowballValues[i] = BigInteger.Pow((snowballSnow[i] / snowballTime[i]), snowballQuality[i]);

                if (maxSnowballValue < snowballValues[i])
                {
                    maxSnowballValue = snowballValues[i];
                    index = i;
                }
            }

            if(count>0)
            {
                Console.WriteLine($"{snowballSnow[index]} : {snowballTime[index]} = {maxSnowballValue}" +
                $" ({snowballQuality[index]})");
            }
        }
    }
}