using System;
using System.Collections.Generic;
using System.Linq;

namespace P03GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var data = new List<Box<string>>();
            for (int i = 0; i < count; i++)
            {
                data.Add(new Box<string>(Console.ReadLine()));
            }
            var coordinates = Console.ReadLine();

            Swap<Box<string>>(ref data, coordinates);
            foreach (var box in data)
            {
                Console.WriteLine(box.ToString());
            }
        }

        public static void Swap<T>(ref List<T> data, string coordinates)
        {
            var cords = coordinates.Split(" ")
                .Select(int.Parse)
                .ToArray();
            var cord1 = cords[0];
            var cord2 = cords[1];

            var help = data[cord1];
            data[cord1] = data[cord2];
            data[cord2] = help;
        }

    }
}
