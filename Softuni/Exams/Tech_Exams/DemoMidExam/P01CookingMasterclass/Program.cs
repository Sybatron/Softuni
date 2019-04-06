using System;

namespace P01CookingMasterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	budget – floating - point number in range[0.00…1, 000.00]
            //•	students – integer in range[0…100]
            //•	price of flour for a package – floating - point number in range[0.00…100.00]
            //•	price of egg for a single egg – floating - point number in range[0.00…100.00]
            //•	price of apron for a single apron – floating - point number in range[0.00…100.00]

            //flour, 10 eggs and an apron

            //•	If the calculated price of the items is less or equal to the budget:
            //"Items purchased for {the cost of the items}$."
            //•	If the calculated price is more than the budget: "{neededMoney}$ more needed."
            //•	All prices must be rounded to two digits after the decimal point.

            //aprons buy 20% more, rounded up to the next integer
            //every fifth package of flour is free.

            double budget = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var flourPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var apronPrice = double.Parse(Console.ReadLine());

            var totalPrice = students * flourPrice;
            totalPrice -= students / 5 * flourPrice;//the free flour

            totalPrice += students * 10 * eggPrice;
            totalPrice += Math.Ceiling(students * 1.2) * apronPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{totalPrice - budget:f2}$ more needed.");
            }
        }
    }
}
