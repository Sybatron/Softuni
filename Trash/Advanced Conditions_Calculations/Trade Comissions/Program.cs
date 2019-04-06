using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var comission = -1.0;
            var town = Console.ReadLine();
            var income = double.Parse(Console.ReadLine());

            if(town=="Sofia")
            {
                if (income > 10000) comission = income * 0.12;
                else if (income > 1000) comission = income * 0.08;
                else if (income > 500) comission = income * 0.07;
                else if (income >= 0) comission = income * 0.05;

                if(comission<0)
                {
                    Console.WriteLine("error");
                }
                else Console.WriteLine(Math.Round(comission,2));
            }

            else if(town=="Varna")
            {
                if (income > 10000) comission = income * 0.13;
                else if (income > 1000) comission = income * 0.10;
                else if (income > 500) comission = income * 0.075;
                else if (income >= 0) comission = income * 0.045;

                if (comission < 0)
                {
                    Console.WriteLine("error");
                }
                else Console.WriteLine(Math.Round(comission, 2));
            }

            else if(town=="Plovdiv")
            {
                if (income > 10000) comission = income * 0.145;
                else if (income > 1000) comission = income * 0.12;
                else if (income > 500) comission = income * 0.08;
                else if (income >= 0) comission = income * 0.055;

                if (comission < 0)
                {
                    Console.WriteLine("error");
                }
                else Console.WriteLine(Math.Round(comission, 2));
            }

            else Console.WriteLine("error");
        }
    }
}
