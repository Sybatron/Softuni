using System;
using System.Linq;

namespace P03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = Console.ReadLine().Split(@"\").Last();
            var partsOfFile = file.Split(".");
            //File name: Template
            //File extension: pptx

            Console.WriteLine($"File name: {partsOfFile[0]}");
            Console.WriteLine($"File extension: {partsOfFile[1]}");
        }
    }
}
