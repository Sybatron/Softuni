using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
