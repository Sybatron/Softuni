using System;
using System.Collections.Generic;
using System.Linq;

namespace P02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            //•	Delete { element} 
            //•	Insert { element} { position}
            while (input != "end")
            {
                string[] operations = input.Split().Select(x => x.ToLower()).ToArray();
                if (operations[0] == "insert")
                {
                    listOfNumbers.Insert(int.Parse(operations[2]), int.Parse(operations[1]));
                }
                else
                {
                    listOfNumbers.RemoveAll(x => x == int.Parse(operations[1]));
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
