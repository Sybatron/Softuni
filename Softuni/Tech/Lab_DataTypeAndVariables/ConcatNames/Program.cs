using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string SecongName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine(FirstName + delimeter + SecongName);
        }
    }
}
