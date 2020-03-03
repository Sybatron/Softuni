using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] character = text.ToCharArray();
            Array.Reverse(character);
            string result = new string(character);

            Console.WriteLine(result);
        }
    }
}
