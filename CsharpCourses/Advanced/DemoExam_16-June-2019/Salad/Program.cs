using System;
using System.Collections.Generic;
using System.Text;

namespace P03HealthyHeaven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Restaurant restaurant = new Restaurant("Casa Domingo");

            // Initialize the entities
            Vegetable tomato = new Vegetable("Tomato", 20);
            Vegetable cucumber = new Vegetable("Cucumber", 15);

            Salad salad = new Salad("Tomatoes with cucumbers");

            salad.Add(tomato);
            salad.Add(cucumber);

            Console.WriteLine(salad.GetTotalCalories()); // 35
            Console.WriteLine(salad.GetProductCount());  // 2

            Console.WriteLine(salad.ToString());
            // * Salad Tomatoes with cucumbers is 35 calories and have 2 products:
            //  - Tomato have 20 calories
            //  - Cucumber have 15 calories

            restaurant.Add(salad);

            Console.WriteLine(restaurant.Buy("Invalid salad")); // False

            // Initialize the second entities
            Vegetable corn = new Vegetable("Corn", 90);
            Salad casaDomingo = new Salad("Casa Domingo");

            casaDomingo.Add(tomato);
            casaDomingo.Add(cucumber);
            casaDomingo.Add(corn);

            restaurant.Add(casaDomingo);

            Console.WriteLine(restaurant.GetHealthiestSalad()); // Tomatoes with cucumbers

            Console.WriteLine(restaurant.GenerateMenu());
            // Casa Domingo have 2 salads:
            // * Salad Tomatoes with cucumbers is 35 calories and have 2 products:
            //  - Tomato have 20 calories
            //  - Cucumber have 15 calories
            // * Salad Casa Domingo is 125 calories and have 3 products:
            //  - Tomato have 20 calories
            //  - Cucumber have 15 calories
            //  - Corn have 90 calories

        }

        class Vegetable
        {
            public string name;
            public int calories;

            public Vegetable(string inputName, int inputCalories)
            {
                name = inputName;
                calories = inputCalories;
            }
            public override string ToString()
            {
                return $"- {name} have {calories} calories";
            }
        }

        class Salad
        {
            public string name;
            List<Vegetable> products;

            public Salad(string inputName)
            {
                name = inputName;
                products = new List<Vegetable>();
            }

            public int GetTotalCalories()
            {
                var calories = 0;
                foreach (var veggie in products)
                {
                    calories += veggie.calories;
                }
                return calories;
            }

            public int GetProductCount()
            {
                return products.Count;
            }
            public void Add(Vegetable product)
            {
                products.Add(product);
            }

            public override string ToString()
            {
                var text = new StringBuilder();
                text.Append($"* Salad {name} is {this.GetTotalCalories()} calories " +
                    $"and have {this.GetProductCount()} products:{Environment.NewLine}");
                foreach (var product in products)
                {
                    text.Append(product.ToString() + Environment.NewLine);
                }
                text.Remove(text.Length - 1, 1);
                return text.ToString();
            }
        }

        class Restaurant
        {
            public string name;
            List<Salad> salads;

            public Restaurant(string inputName)
            {
                name = inputName;
                salads = new List<Salad>();
            }

            public void Add(Salad salad)
            {
                salads.Add(salad);
            }
            public bool Buy(string name)
            {
                if (salads.Contains(new Salad(name)))
                {
                    salads.Remove(new Salad(name));
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public string GetHealthiestSalad()
            {
                var leastCalories = int.MaxValue;
                var index = 0;
                for (int i = 0; i < salads.Count; i++)
                {
                    var currentCalories = salads[i].GetTotalCalories();
                    if (currentCalories < leastCalories)
                    {
                        index = i;
                        leastCalories = currentCalories;
                    }
                }

                return salads[index].name;
            }

            public string GenerateMenu()
            {
                var text = new StringBuilder();

                text.Append($"{name} have {salads.Count} salads:{Environment.NewLine}");
                foreach (var salad in salads)
                {
                    text.Append(salad.ToString() + Environment.NewLine);
                }
                text.Remove(text.Length - 1, 1);
                return text.ToString();
            }
        }
    }
}
