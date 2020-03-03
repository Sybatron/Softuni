using System;
using System.Collections.Generic;
using System.Linq;

namespace P03ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            var input = Console.ReadLine()
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                if (!shops.ContainsKey(input[0]))
                {
                    shops[input[0]] = new Dictionary<string, double>();
                }
                shops[input[0]][input[1]] = double.Parse(input[2]);

                input = Console.ReadLine()
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }


            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
