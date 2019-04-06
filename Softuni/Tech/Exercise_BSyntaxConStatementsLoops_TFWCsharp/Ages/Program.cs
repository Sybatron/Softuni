using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            /*
             * 0-2 – baby; 
3-13 – child; 

14-19 – teenager;

20-65 – adult;

>=66 – elder;*/
            if (ages >= 66)
            {
                Console.WriteLine("elder");
            }
            else if(ages>=20)
            {
                Console.WriteLine("adult");
            }
            else if(ages>=14)
            {
                Console.WriteLine("teenager");
            }
            else if(ages>=3)
            {
                Console.WriteLine("child");
            }
            else Console.WriteLine("baby");
        }
    }
}
