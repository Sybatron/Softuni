using System;

namespace RadToGrad
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(((rad* 180)/ Math.PI),2));
        }
    }
}
