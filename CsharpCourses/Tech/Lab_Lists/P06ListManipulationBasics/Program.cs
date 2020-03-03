using System;
using System.Collections.Generic;
using System.Linq;

namespace P06ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add { number}: add a number to the end of the list.
            //Remove { number}: remove a number from the list.
            //RemoveAt { index}: remove a number at a given index.
            //Insert { number} { index}: insert a number at a given index.

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] inputParameters = input.Split();
                string operation = inputParameters[0];
                int element = int.Parse(inputParameters[1]);
                int index = int.Parse(inputParameters[inputParameters.Length - 1]);

                if (operation == "add")
                {
                    numbers.Add(element);
                }
                else if (operation == "remove")
                {
                    numbers.Remove(element);
                }
                else if (operation == "removeat")
                {
                    numbers.RemoveAt(index);
                }
                else
                {
                    numbers.Insert(index, element);
                }
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
