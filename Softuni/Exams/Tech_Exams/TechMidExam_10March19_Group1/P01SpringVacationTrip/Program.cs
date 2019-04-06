using System;

namespace P01SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var people = int.Parse(Console.ReadLine());
            var fuelPrice = double.Parse(Console.ReadLine());
            var foodPrice = double.Parse(Console.ReadLine());
            var hotelPrice = double.Parse(Console.ReadLine());
            var currentExpenses = people * hotelPrice * days;

            if (people > 10)
            {
                currentExpenses *= 0.75;
            }
            currentExpenses += people * foodPrice * days;

            for (int i = 1; i <= days; i++)
            {
                //Every day, they travel some distance
                //Every third and fifth day, they have some additional expenses, which are 40 % of the current value of the expenses.
                //Every seventh day, their expenses are reduced, because they withdraw(receive) a small amount of money – you can calculate it by dividing the amount of the current expenses by the group of people.

                var km = double.Parse(Console.ReadLine());
                currentExpenses += km * fuelPrice;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpenses *= 1.4;
                }

                if (i % 7 == 0)
                {
                    currentExpenses -= currentExpenses / people;
                }

                if (budget - currentExpenses < 0)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {currentExpenses - budget:f2}$ more.");
                    return;
                }
            }
            Console.WriteLine($"You have reached the destination. You have {budget - currentExpenses:f2}$ budget left.");
        }
    }
}
