using System;
using System.Collections.Generic;

namespace P06GenericCountMethodDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var data = new List<Box<double>>();
            for (int i = 0; i < count; i++)
            {
                data.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }

            var compareValue = double.Parse(Console.ReadLine());
            var counter = 0;
            foreach (var box in data)
            {
                if (box.IsGreater(compareValue))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
