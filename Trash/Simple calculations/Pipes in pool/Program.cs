using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipes_in_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            var pipe1Power = int.Parse(Console.ReadLine());
            var pipe2Power = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var liters = (pipe1Power + pipe2Power) * hours;
            var litersPipe1 = pipe1Power * hours;
            var litersPipe2 = pipe2Power * hours;

            if(liters>capacity)
            {
                var overLiters = liters - capacity;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hours,overLiters);
            }
            else
            {
                var percentage = (liters / capacity) * 100;
                var pipe1Percentage = (litersPipe1 / liters) * 100;
                var pipe2Percentage = (litersPipe2 / liters) * 100;

                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Floor(percentage),
                    Math.Floor(pipe1Percentage), Math.Floor(pipe2Percentage));
            }
        }
    }
}
