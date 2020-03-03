using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexOfLetter = int.Parse(Console.ReadLine());
            int aCharValue = 'a';
            for (char a = (char)aCharValue; a < aCharValue + indexOfLetter; a++)
            {
                for (char b = (char)aCharValue; b < aCharValue + indexOfLetter; b++)
                {
                    for (char c = (char)aCharValue; c < aCharValue+indexOfLetter; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
