using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());

            if (num1 < num3)
            {
                swap(ref num1, ref num3);
            }
            if (num1 < num2)
            {
                swap(ref num1, ref num2);
            }
            if (num2 < num3)
            {
                swap(ref num2, ref num3);
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }

        static double swap(ref double n1, ref double n2)
        {
            double x = n1;
            n1 = n2;
            n2 = x;
            return 0;
        }
    }
}
