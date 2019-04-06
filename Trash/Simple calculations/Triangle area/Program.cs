using System;

namespace Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Triangle area = {0}",a*h/2);
        }
    }
}
