using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TEST_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            DateTime date = startDate;
            for (; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            }
                
            Console.WriteLine(holidaysCount);
        }
    }
}