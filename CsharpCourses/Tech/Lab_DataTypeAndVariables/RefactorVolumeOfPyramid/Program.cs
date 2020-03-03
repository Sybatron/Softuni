using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double volume = double.Parse(Console.ReadLine());
            volume = (lenght * width * volume)/3;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
