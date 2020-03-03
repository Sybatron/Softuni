using System;

namespace P03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char startCharacter = char.Parse(Console.ReadLine());
            char endCharacter = char.Parse(Console.ReadLine());
            PrintCharacterInRange(startCharacter, endCharacter);
        }

        private static void PrintCharacterInRange(char startCharacter, char endCharacter)
        {
            int start = Math.Min(startCharacter, endCharacter) + 1;
            int end = Math.Max(startCharacter, endCharacter);
            for (int i = start; i < end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
