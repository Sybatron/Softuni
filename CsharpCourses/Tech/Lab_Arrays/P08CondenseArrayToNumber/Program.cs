using System;
using System.Linq;

namespace P08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 10 3  2+10 10+3  12 13  12 + 13  25
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] newArray = new int[numbers.Length - 1];
                for (int j = 0; j < newArray.Length; j++)
                {
                    newArray[j] = numbers[j] + numbers[j + 1];
                }
                numbers = newArray;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
