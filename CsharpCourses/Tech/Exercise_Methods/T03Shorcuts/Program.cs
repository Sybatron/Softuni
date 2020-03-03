using System;
using System.Diagnostics;

namespace T03Shorcuts
{
    class Program
    {
        static Random rnd=new Random();


        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            char[] pesho = { 'a', 'b', 'z', 'd' };
            Array.Sort(pesho);
            Console.WriteLine(string.Join(", ",pesho));
            uint count1 = 0;
            uint count2 = 0;
            uint count3 = 0;
            uint count4 = 0;
            uint count5 = 0;
            uint count6 = 0;

            for (long i = 0; i < 100; i++)
            {
                int dieNumber = rnd.Next(1, 7);
                switch (dieNumber)
                {
                    case 1:
                        {
                            count1++;
                            break;
                        }
                    case 2:
                        {
                            count2++;
                            break;
                        }
                    case 3:
                        {
                            count3++;
                            break;
                        }
                    case 4:
                        {
                            count4++;
                            break;
                        }
                    case 5:
                        {
                            count5++;
                            break;
                        }
                    case 6:
                        {
                            count6++;
                            break;
                        }
                }
            }
            Console.WriteLine(count1);
            Console.WriteLine(count2);
            Console.WriteLine(count3);
            Console.WriteLine(count4);
            Console.WriteLine(count5);
            Console.WriteLine(count6);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Penka(time);
        }

        private static void Penka(Stopwatch time)
        {
            throw new NotImplementedException("ЕБИ СИ ЛОЛИТО");
        }
    }
}
