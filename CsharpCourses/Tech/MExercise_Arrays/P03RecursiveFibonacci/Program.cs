using System;
using System.Diagnostics;

namespace P03RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int length = int.Parse(Console.ReadLine());
            
            //if (length > 2)
            //{
            //    int[] RecursiveFibonacci = new int[length];
            //    RecursiveFibonacci[0] = 1;
            //    RecursiveFibonacci[1] = 1;

            //    for (int i = 2; i < length; i++)
            //    {
            //        RecursiveFibonacci[i] = RecursiveFibonacci[i - 1] + RecursiveFibonacci[i - 2];
            //    }
            //    Console.WriteLine(RecursiveFibonacci[length - 1]);
            //}
            //else
            //{
            //    Console.WriteLine(1);
            //}

            Console.WriteLine(GetFibonacci(length));
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds / 1000);
        }

        static int GetFibonacci(int n)
        {

            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }

        }
    }
}
