using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int FinalNumber = int.Parse(Console.ReadLine());
            int total = 0;
            for (int number = 1; number <= FinalNumber; number++)
            {
                int nowNumber = number;
                while (number > 0)
                {
                    total += number % 10;
                    number = number / 10;
                }
                bool special = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", nowNumber, special);
                total = 0;
                number = nowNumber;
            }
        }
    }
}
