using System;

namespace CtoF
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((c*1.8+32),2));
        }
    }
}
