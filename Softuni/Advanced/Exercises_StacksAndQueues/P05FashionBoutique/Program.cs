using System;
using System.Collections.Generic;
using System.Linq;

namespace P05FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var clothes = new Stack<int>(input);
            input = input.Reverse()
                    .ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());
            var rackCount = 1;
            var currentRack = 0;
            foreach (var num in input)
            {
                if (currentRack + num <= rackCapacity)
                {
                    currentRack += clothes.Pop();
                }
                else
                {
                    currentRack = clothes.Pop();
                    rackCount++;
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
