using System;
using System.Linq;

namespace P02HelensAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var energy = int.Parse(Console.ReadLine());
            var side = int.Parse(Console.ReadLine());
            var field = new char[side][];

            for (int i = 0; i < side; i++)
            {
                field[i] = Console.ReadLine()
                    .ToCharArray();
            }

            while (energy > 0)
            {

            }
        }
    }
}
