using System;
using System.Linq;

namespace P08Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var personAdressTown = new Tuple<string, string, string>(
                string.Join(" ", input.Take(2))
                , input[2]
                , string.Join(" ",input.Skip(3))
                );

            input = Console.ReadLine().Split(" ");
            var nameBeersDrunk = new Tuple<string, int, bool>(
                input[0]
                , int.Parse(input[1])
                , input.Last() == "drunk"
                );

            input = Console.ReadLine().Split(" ");
            var nameBalanceBank = new Tuple<string, double, string>(
                input.First()
                , double.Parse(input[1])
                , input.Last()
                );

            Print<string, string, string>(personAdressTown);
            Print<string, int, bool>(nameBeersDrunk);
            Print<string, double, string>(nameBalanceBank);

        }

        public static void Print<T1, T2, T3>(Tuple<T1, T2, T3> tuple)
        {
            Console.WriteLine($"{tuple.Item1} -> {tuple.Item2} -> {tuple.Item3}");
        }
    }
}
