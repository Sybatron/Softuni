using System;
using System.Collections.Generic;
using System.Linq;

namespace P04FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var orders = new Queue<int>(input);
            Console.WriteLine(orders.Max());
            foreach (var order in input)
            {
                if (quantity - order >= 0)
                {
                    quantity -= order;
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");

        }
    }
}
