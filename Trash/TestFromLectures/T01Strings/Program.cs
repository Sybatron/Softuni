using System;
using System.Linq;

namespace T01Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).Take(5).ToArray();
            //Console.WriteLine(string.Join(" ", numbers));
            var text = Console.ReadLine();
            if (text.StartsWith("pederas"))
            {
                throw new Exception("Don't swear");
            }
            else
            {
                Console.WriteLine("You're a good guy");
            }
        }

    }
}
