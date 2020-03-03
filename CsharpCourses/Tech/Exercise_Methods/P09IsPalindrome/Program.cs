using System;

namespace P09IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isPalindrome = true;
                for (int firstSymb = 0, lastSymb = input.Length - 1; firstSymb < input.Length; firstSymb++, lastSymb--)
                {
                    if (input[firstSymb] != input[lastSymb])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine(isPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }
    }
}
