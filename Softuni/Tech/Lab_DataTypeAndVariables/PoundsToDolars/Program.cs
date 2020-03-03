using System;

namespace PoundsToDolars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());

            Console.WriteLine($"{pounds*1.31:f3}");
        }
    }
}
