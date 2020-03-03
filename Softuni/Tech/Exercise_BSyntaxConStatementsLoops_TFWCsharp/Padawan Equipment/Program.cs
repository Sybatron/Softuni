using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double needed = lightsaberPrice * Math.Ceiling(students * 0.1 + students);
            needed += robesPrice * students;
            needed += beltsPrice * (students - students / 6);
            if (money >= needed)
            {
                Console.WriteLine($"The money is enough - it would cost {needed:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {needed - money:f2}lv more.");
            }
        }
    }
}
