using System;

namespace P01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            PrintMinNumOfThreeNums(firstNum, secondNum, thirdNum);
        }

        private static void PrintMinNumOfThreeNums(int firstNum, int secondNum, int thirdNum)
        {
            int min = Math.Min(firstNum, secondNum);
            min = Math.Min(min, thirdNum);
            Console.WriteLine(min);
        }
    }
}
