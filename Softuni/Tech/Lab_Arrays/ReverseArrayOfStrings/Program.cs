using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split(" ");
            Array.Reverse(texts);
            Console.WriteLine(string.Join(" ",texts));
        }
    }
}
