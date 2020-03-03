using System;

namespace P02VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintCountOfVowels(text);
        }

        private static void PrintCountOfVowels(string text)
        {
            text = text.ToLower();
            int vowelsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (isThisVowel(text[i]))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }

        private static bool isThisVowel(char character)
        {
            switch (character)
            {
                case 'a':
                case 'e':
                case 'u':
                case 'o':
                case 'i':
                    return true;
                default:
                    return false;
            }
        }
    }
}
