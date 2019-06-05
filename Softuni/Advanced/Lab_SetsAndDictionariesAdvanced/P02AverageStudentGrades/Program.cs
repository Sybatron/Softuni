using System;
using System.Collections.Generic;
using System.Linq;

namespace P02AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!students.ContainsKey(input[0]))
                {
                    students[input[0]] = new List<double>();
                }
                students[input[0]].Add(double.Parse(input[1]));
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():F2})");
            }
        }
    }
}
