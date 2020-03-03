using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] models = new string[length];
            double[] radius = new double[length];
            int[] height = new int[length];
            double[] volume = new double[length];

            for (int i = 0; i < length; i++)
            {
                models[i] = Console.ReadLine();
                radius[i] = double.Parse(Console.ReadLine());
                height[i] = int.Parse(Console.ReadLine());
                volume[i] = Math.PI * radius[i] * radius[i] * height[i];
            }
            double maxVolume = double.MinValue;
            string model = "";
            for (int i = 0; i < length; i++)
            {
                if (maxVolume < volume[i])
                {
                    maxVolume = volume[i];
                    model = models[i];
                }
            }
            Console.WriteLine(model);
        }
    }
}
