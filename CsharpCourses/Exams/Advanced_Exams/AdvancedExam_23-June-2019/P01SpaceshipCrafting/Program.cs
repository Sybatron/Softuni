using System;
using System.Collections.Generic;
using System.Linq;

namespace P01SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            var liquids = new Queue<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var items = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var advancedItems = new Dictionary<string, int>()
            {
                {"Aluminium", 0 },
                {"Carbon fiber", 0 },
                {"Glass", 0},
                {"Lithium", 0}
            };

            var craftingValues = new string[4]
            {
                "Glass",
                "Aluminium",
                "Lithium",
                "Carbon fiber"
            };
            while (liquids.Count > 0 && items.Count > 0)
            {
                var currentSum = liquids.Peek() + items.Peek();
                if (currentSum >= 25 && currentSum <= 100 && currentSum % 25 == 0)
                {
                    advancedItems[craftingValues[currentSum / 25 - 1]]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    var currentItem = items.Pop() + 3;
                    items.Push(currentItem);
                }
            }

            var shipCrafted = true;
            foreach (var value in advancedItems)
            {
                if (value.Value == 0)
                {
                    shipCrafted = false;
                    break;
                }
            }

            if (shipCrafted)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }

            Console.WriteLine($"Aluminium: {advancedItems["Aluminium"]}" + Environment.NewLine +
                              $"Carbon fiber: {advancedItems["Carbon fiber"]}" + Environment.NewLine +
                              $"Glass: {advancedItems["Glass"]}" + Environment.NewLine +
                              $"Lithium: {advancedItems["Lithium"]}");

        }
    }
}
