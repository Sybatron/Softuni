using System;
using System.Linq;

namespace P06EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int i = 1; i < numbers.Length; i++)
                {
                    int sumLeft = 0;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        sumLeft += numbers[j];
                    }

                    int sumRight = 0;
                    for (int q = i + 1; q < numbers.Length; q++)
                    {
                        sumRight += numbers[q];
                    }

                    if (sumLeft == sumRight)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }

                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
