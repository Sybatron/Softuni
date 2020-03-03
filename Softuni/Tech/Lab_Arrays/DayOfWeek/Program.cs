using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday","Tuesday","Wednesday",
                             "Thursday","Friday","Saturday","Sunday"};

            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index <= 6)
            {
                Console.WriteLine(days[index]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
