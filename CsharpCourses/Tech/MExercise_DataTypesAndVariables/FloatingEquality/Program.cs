using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double maxNumber = Math.Max(number1, number2);
            double minNumber = Math.Min(number1, number2);

            if ((maxNumber - minNumber) < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
