using System;
using System.Linq;

namespace P11ArrayManipulator
{
    class Program
    {
        static int[] numbers;
        static void Main(string[] args)
        {
            numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            string help = 
            while (input != "end")
            {
                string[] inputParameters = input.Split();
                string operation = inputParameters[0];

                if (operation == "exchange")
                {
                    Exchange(int.Parse(inputParameters[1]));
                }
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void Exchange(int index)
        {
            int[] array1 = numbers.ToString()
                .Substring(0, index + 1)
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] array2 = numbers.ToString()
                .Substring(index + 1, numbers.Length - 1 - index)
                .Split()
                .Select(int.Parse)
                .ToArray();

            numbers = array2.Concat(array1).ToArray();
        }
    }
}
