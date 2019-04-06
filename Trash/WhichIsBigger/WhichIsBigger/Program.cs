using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhichIsBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<string>
            {
                Console.ReadLine(),
                Console.ReadLine()
            };
            arr.Sort();
            Console.WriteLine(arr[0]);
        }
    }
}
