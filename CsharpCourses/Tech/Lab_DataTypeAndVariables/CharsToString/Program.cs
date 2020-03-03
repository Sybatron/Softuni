using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = new char[3];
            characters[0] = char.Parse(Console.ReadLine());
            characters[1] = char.Parse(Console.ReadLine());
            characters[2] = char.Parse(Console.ReadLine());

            string text = new string(characters);
            Console.WriteLine(text);
        }
    }
}
