using System;
using System.Linq;

namespace P07Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var personAdress = new Tuple<string, string>(
                string.Join(" ", input.Split(" ").Take(2))
                , input.Split(" ").Last()
                );

            input = Console.ReadLine();
            var nameBeers = new Tuple<string, int>(
                input.Split(" ").First()
                , int.Parse(input.Split(" ").Last())
                );

            input = Console.ReadLine();
            var intDouble = new Tuple<int, double>(
                int.Parse(input.Split(" ").First())
                , double.Parse(input.Split(" ").Last())
                );

            Print<string,string>(personAdress);
            Print<string,int>(nameBeers);
            Print<int,double>(intDouble);

        }

        public static void Print<T1,T2>(Tuple<T1,T2> tuple)
        {
            Console.WriteLine($"{tuple.Item1} -> {tuple.Item2}");
        }
    }
}
