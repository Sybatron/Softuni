using System;

namespace P08FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            decimal firstFactoriel = GetFactoriel(firstNumber);
            decimal secondFactoriel = GetFactoriel(secondNumber);

            Console.WriteLine($"{firstFactoriel / secondFactoriel:f2}");
        }

        private static ulong GetFactoriel(int number)
        {
            ulong fact = 1;
            for (uint i = 2; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
