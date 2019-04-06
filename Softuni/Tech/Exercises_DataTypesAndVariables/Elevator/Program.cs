using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int ElevatorCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)people / ElevatorCapacity);
            Console.WriteLine(courses);
        }
    }
}
