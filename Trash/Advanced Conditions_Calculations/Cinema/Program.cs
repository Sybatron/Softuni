using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            var price = rows * columns * 1.0;
            switch (type)
            {
                case "premiere":
                    price *= 12;
                    break;
                case "normal":
                    price *= 7.50;
                    break;
                case "discount":
                    price *= 5.00;
                    break;
            }

            Console.WriteLine(price);
        }
    }
}
