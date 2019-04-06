using System;
using System.Globalization;

namespace Intro_and_Basic_SyntaxLab_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {

                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }
                else Console.WriteLine("Please write an even number.");
            }
        }
    }
}
