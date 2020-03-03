using System;
using System.Linq;

namespace P10TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            PrintIsThreTopNumbersInTheRange(lastNumber);
        }

        private static void PrintIsThreTopNumbersInTheRange(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sumDigits = i.ToString().Sum(c => c - '0');
                bool devidableByEight = IsDevidableByEight(sumDigits);
                bool oneOddDigit = IsWithOneOddDigit(i);
                if (oneOddDigit && devidableByEight)
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool IsWithOneOddDigit(int number)
        {
            string characters = number.ToString();
            foreach (var character in characters)
            {
                switch (character)
                {
                    case '1':
                    case '3':
                    case '5':
                    case '7':
                    case '9':
                        return true;
                }
            }
            return false;
        }

        private static bool IsDevidableByEight(int sumDigits)
        {
            if (sumDigits % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
