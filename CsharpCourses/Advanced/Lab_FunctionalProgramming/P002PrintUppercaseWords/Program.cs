using System;
using System.Linq;

namespace P002PrintUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var uppercaseWords = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsUpper((char)x[0]))
                ;

            Console.WriteLine(string.Join(Environment.NewLine,uppercaseWords));    
        }
    }
}
