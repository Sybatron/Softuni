using System;

namespace RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalNumber = int.Parse(Console.ReadLine());
            for (int number = 2; number <= originalNumber; number++)
            {
                string isNumPrime = "true";
                for (int divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isNumPrime = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", number, isNumPrime);
            }
        }
    }
}
