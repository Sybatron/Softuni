using System;
using System.Collections.Generic;

namespace T02SortArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int length = int.Parse(Console.ReadLine());
            //var numbers = new int[length];
            //for (int i = 0; i < length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //PrintAllNumbers(numbers);
            //Array.Sort(numbers);
            //PrintAllNumbers(numbers);
            //Array.Reverse(numbers);
            //PrintAllNumbers(numbers);

            //int length = int.Parse(Console.ReadLine());
            //var numbers = new List<int>();
            //for (int i = 0; i < length; i++)
            //{
            //    numbers.Add(int.Parse(Console.ReadLine()));
            //}
            //PrintAllNumbers(numbers);
            //numbers.Sort();
            //PrintAllNumbers(numbers);
            //numbers.Reverse();
            //PrintAllNumbers(numbers);

            int[] testArray = { 1, 2, 3, 4, };
        }

        private static void PrintAllNumbers(int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
        private static void PrintAllNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
