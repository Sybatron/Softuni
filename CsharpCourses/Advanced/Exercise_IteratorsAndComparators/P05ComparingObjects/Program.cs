using System;
using System.Collections.Generic;

namespace P05ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var parameters = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = parameters[0];
                var age = int.Parse(parameters[1]);
                var town = parameters[2];

                people.Add(new Person(name, age, town));
                input = Console.ReadLine();
            }

            var n = int.Parse(Console.ReadLine()) - 1;
            var personToSearh = people[n];
            var matches = 0;

            foreach (var person in people)
            {
                if (personToSearh.CompareTo(person) == 0)
                {
                    matches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
        }
    }
}
