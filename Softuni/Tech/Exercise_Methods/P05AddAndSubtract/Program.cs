using System;

namespace P05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = GetSumFromTwoIntegers(firstNumber, secondNumber);
            result = GetSubstractionFromTwoIntegers(result, thirdNumber);
            Console.WriteLine(result);
        }

        private static int GetSumFromTwoIntegers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static int GetSubstractionFromTwoIntegers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
