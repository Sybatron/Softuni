using System;

namespace T01Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            var kiro = new Pesho();
            kiro.variable = 5;
            var gosho = new (kiro);
        }

        class Pesho
        {
            public int variable;

        }
    }
}
