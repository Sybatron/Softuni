using System;
using System.Collections.Generic;
using System.Linq;

namespace P04ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Add { number} – add number at the end.
            //•	Insert { number} { index} – insert number at given index.
            //•	Remove { index} – remove at index.
            //•	Shift left { count} – first number becomes last ‘count’ times.
            //•	Shift right { count} – last number becomes first ‘count’ times.

            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] inputParameters = input.Split();
                string operation = inputParameters[0];

                if (operation == "add")
                {
                    listOfNumbers.Add(int.Parse(inputParameters[1]));
                }
                else
                {
                    int index = int.Parse(inputParameters[inputParameters.Length - 1]);
                    if (index > -1 && index < listOfNumbers.Count)
                    {
                        if (operation == "insert")
                        {
                            listOfNumbers.Insert(index, int.Parse(inputParameters[1]));
                        }
                        else if (operation == "remove")
                        {
                            listOfNumbers.RemoveAt(index);
                        }
                        else if (operation == "shift")
                        {
                            if (inputParameters[1] == "left")
                            {
                                for (int k = 0; k < index; k++)
                                {
                                    listOfNumbers.Add(listOfNumbers[0]);
                                    listOfNumbers.RemoveAt(0);
                                }
                            }
                            else
                            {
                                for (int k = 0; k < index; k++)
                                {
                                    listOfNumbers.Insert(0, listOfNumbers[listOfNumbers.Count - 1]);
                                    listOfNumbers.RemoveAt(listOfNumbers.Count - 1);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
