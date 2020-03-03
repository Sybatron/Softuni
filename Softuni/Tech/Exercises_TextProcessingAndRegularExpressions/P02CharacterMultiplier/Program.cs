using System;
using System.Linq;
using System.Numerics;

namespace P02CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = Console.ReadLine()
                .Split(" ")
                .OrderBy(x => x.Length)
                .ToArray();
            PrintSum(texts[0], texts[1]);
        }

        private static void PrintSum(string smaller, string bigger)
        {
            var sum = new BigInteger(0);
            for (int i = 0; i < smaller.Length; i++)
            {
                sum += smaller[i] * bigger[i];
            }
            if (smaller.Length != bigger.Length)
            {
                for (int i = smaller.Length; i < bigger.Length; i++)
                {
                    sum += bigger[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
