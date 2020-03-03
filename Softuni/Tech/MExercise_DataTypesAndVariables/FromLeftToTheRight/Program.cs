using System;
using System.Linq;
using System.Numerics;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                string input = Console.ReadLine();
                long[] numbers = input.Split()
                                        .Select(long.Parse)
                                        .ToArray();

                long maxNumber;
                if (numbers[0] >= numbers[1])
                {
                    maxNumber = numbers[0];
                }
                else
                {
                    maxNumber = numbers[1];
                }

                long sum= 0;
                while (maxNumber > 0)
                {
                    sum += (maxNumber % 10);
                    maxNumber /= 10;
                    Console.WriteLine(Math.Abs(sum));
                }
            }
        }
    }
}
