using System;

namespace P12TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split();
            foreach (var name in names)
            {
                if (PrintName(name, EqualsSumOfTextWithNum(name, sum)))
                {
                    return;
                }
            }
        }

        static bool PrintName(string name, bool isNamePrintable)
        {
            if (isNamePrintable)
            {
                Console.WriteLine(name);
                return true;
            }
            return false;
        }

        static bool EqualsSumOfTextWithNum(string text, int sum, bool isEqual = true)
        {
            var currentSum = 0;
            foreach (var @char in text)
            {
                currentSum += @char;
            }
            if (currentSum < sum)
            {
                isEqual = false;
            }
            return isEqual;
        }
    }
}
