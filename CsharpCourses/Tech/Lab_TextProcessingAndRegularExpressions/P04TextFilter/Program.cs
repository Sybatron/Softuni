using System;

namespace P04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banWords = Console.ReadLine().Split(", ");
            var text = Console.ReadLine();
            foreach (var word in banWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
