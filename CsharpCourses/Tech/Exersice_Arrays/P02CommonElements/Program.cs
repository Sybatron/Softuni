using System;
using System.Collections.Generic;

namespace P02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");
            List<string> resulstArray = new List<string>();
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (Array.Exists(firstArray, item => item == secondArray[i]))
                {
                    resulstArray.Add(secondArray[i]);
                }
            }
            Console.WriteLine(string.Join(" ", resulstArray));
        }
    }
}
