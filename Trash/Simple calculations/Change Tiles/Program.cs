using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareSide = int.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileLenght = double.Parse(Console.ReadLine());
            var benchWidth = int.Parse(Console.ReadLine());
            var benchLenght = int.Parse(Console.ReadLine());
            var time = (squareSide * squareSide - benchLenght * benchWidth) / (tileLenght * tileWidth);
            Console.WriteLine(time);
            time *= 0.2;
            Console.WriteLine(time);

        }
    }
}
