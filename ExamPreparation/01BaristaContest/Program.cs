using System;
using System.Collections.Generic;
using System.Linq;

namespace _01BaristaContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffee = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList());
            Stack<int> milk = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList());

            List<Drink> drinks = new List<Drink>()
            {
                new Drink("Cortado", 50),
                new Drink("Espresso", 75),
                new Drink("Capuccino", 100),
                new Drink("Americano", 150),
                new Drink("Latte", 200)
            };

            while (coffee.Count != 0 && milk.Count != 0)
            {
                int coffeeQuantity = coffee.Dequeue();
                int milkQuantity = milk.Pop();


                int sumOfMilkAndCoffee = milkQuantity + coffeeQuantity;

                Drink drinker = drinks.FirstOrDefault(x => x.Quantities == sumOfMilkAndCoffee);

                if (drinker != null)
                {
                    drinker.FoundDrinks++;

                }
                else
                {
                    milk.Push(milkQuantity - 5);
                }

            }

            if (coffee.Count == 0 && milk.Count == 0)
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            
            else
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

            if (coffee.Count == 0)
                Console.WriteLine("Coffee left: none");
            else
                Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");

            if (milk.Count == 0)
                Console.WriteLine("Milk left: none");
            else
                Console.WriteLine($"Milk left: {string.Join(", ", milk)}");

            drinks = drinks.Where(l => l.FoundDrinks > 0).OrderBy(x => x.FoundDrinks)
                .ThenByDescending(y => y.TypeOfDrink).ToList();

            foreach (var drink in drinks)
            {
                Console.WriteLine($"{drink.TypeOfDrink}: {drink.FoundDrinks}");
            }
        }

        public class Drink
        {
            public Drink(string drink, int quantities)
            {
                Quantities = quantities;
                TypeOfDrink = drink;
                FoundDrinks = 0;
            }

            public int Quantities { get; set; }
            public int FoundDrinks { get; set; }
            public string TypeOfDrink { get; set; }

        }
    }
}
