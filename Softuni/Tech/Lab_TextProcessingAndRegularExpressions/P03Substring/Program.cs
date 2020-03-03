using System;

namespace P03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordToRemove = Console.ReadLine();
            var text = Console.ReadLine();
            while (text.IndexOf(wordToRemove) != -1)
            {
                text = text.Replace(wordToRemove, "");
            }
            Console.WriteLine(text);
        }
    }
}
