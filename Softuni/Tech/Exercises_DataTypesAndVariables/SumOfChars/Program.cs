using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sum += character;
            }
            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
