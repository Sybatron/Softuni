using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrderDictInDict
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictClasses = new Dictionary<string, Dictionary<string, double>>();
            Regex gradePattern = new Regex(@"^([2-5]((\.\d{1,2}){0,1})|6(\.0{1,2}){0,1})$");
            Regex namePattern = new Regex(@"^[A-Z][a-z]{1,}$");
            for (int i = 0; i < 2; i++)
            {
                string @class = "10" + (char)('A' + i);
                Console.WriteLine(@class);
                dictClasses[@class] = new Dictionary<string, double>();
                for (int j = 1; j <= 3; j++)
                {
                    var student_grade = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (namePattern.IsMatch(student_grade[0]) && gradePattern.IsMatch(student_grade[1]))
                    {
                        dictClasses[@class][student_grade[0]] = double.Parse(student_grade[1]);
                    }
                    else
                    {
                        j--;
                    }
                }
                dictClasses[@class] = dictClasses[@class]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);
            }
            foreach (var @class in dictClasses)
            {
                Console.WriteLine(@class.Key);
                foreach (var grade in @class.Value)
                {

                    Console.WriteLine($"{grade.Key} => {grade.Value}");
                }
            }
        }
    }
}
