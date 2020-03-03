using System;
using System.Collections.Generic;

namespace P05GenericCountMethodStrings
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

            var compareValue = Console.ReadLine();
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
