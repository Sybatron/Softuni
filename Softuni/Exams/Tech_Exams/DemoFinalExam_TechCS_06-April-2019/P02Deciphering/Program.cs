using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P02Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            //only lowercase letters, from 'd' onwards, and the symbols '{', '}', '|', '#

            var bookPattern = new Regex(@"^[d-z{}|#]+$");
            var encryptedText = Console.ReadLine();
            if (!bookPattern.IsMatch(encryptedText))
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            var thisIsRepWithThat = Console.ReadLine().Split(" ");
            var decrcryptedText = new StringBuilder(encryptedText);
            for (int i = 0; i < decrcryptedText.Length; i++)
            {
                decrcryptedText[i] = (char)(decrcryptedText[i] - 3);
            }

            decrcryptedText = decrcryptedText.Replace(thisIsRepWithThat[0], thisIsRepWithThat[1]);
            Console.WriteLine(decrcryptedText);
        }
    }
}
