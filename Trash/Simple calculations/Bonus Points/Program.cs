using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var num = int.Parse(Console.ReadLine());
            var bonusPoints=0.0;

            if(num>1000)
            {
                bonusPoints = num * 0.10;
            }
            else if(num>100)
            {
                bonusPoints=num*0.20;
            }
            else
            {
                bonusPoints = 5;
            }

            if(num%10==5)
            {
                bonusPoints += 2;
            }
            else if(num%2==0)
            {
                bonusPoints += 1;
            }

            Console.WriteLine("Bonus score: {0}",bonusPoints);
            Console.WriteLine("Total score: {0}",bonusPoints+num);
        }
    }
}
