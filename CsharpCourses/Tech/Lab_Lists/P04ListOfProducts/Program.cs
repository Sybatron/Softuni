using System;
using System.Collections.Generic;

namespace P04ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine((i + 1) + "." + products[i]);
            }
        }
    }
}
