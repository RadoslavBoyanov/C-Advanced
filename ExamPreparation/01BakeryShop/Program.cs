using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _01BakeryShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));

            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse));

            List<Bakery> bakery = new List<Bakery>()
            {
                new Bakery("Croissant", 50, 50),
                new Bakery("Muffin", 40, 60),
                new Bakery("Baguette", 30, 70),
                new Bakery("Bagel", 20, 80)
            };

            while (water.Count > 0 && flour.Count > 0)
            {
                double quantityWater = water.Peek();
                double quantityFlour = flour.Peek();

                double quantityFromWaterAndFlour = quantityFlour + quantityWater;

                double percentOfWater = (quantityWater * 100)/ quantityFromWaterAndFlour;

                double percentOfFlour = 100 - percentOfWater;

                var result = bakery.FirstOrDefault(x => x.Water == percentOfWater);

                if (result != null)
                {
                    result.Count++;
                    water.Dequeue();
                    flour.Pop();
                }
                else
                {
                    double redundancyFlour = quantityFlour - quantityWater;
                    quantityFlour = quantityWater;
                    double mix = quantityWater + quantityFlour; 

                    double mixForCroissant = (quantityFlour * 100) / mix;

                    var croissant = bakery.First(x => x.Water == mixForCroissant);
                    if (croissant != null)
                    {
                        croissant.Count++;
                        water.Dequeue();
                        flour.Pop();
                        flour.Push(redundancyFlour);
                    }
                }
            }

            bakery = bakery.Where(x=> x.Count > 0).OrderByDescending(c => c.Count).ThenBy(p=>p.Product).ToList();

            foreach (var product in bakery)
            {
                Console.WriteLine($"{product.Product}: {product.Count}");
            }

            if (water.Count == 0)
                Console.WriteLine("Water left: None");
            else
                Console.WriteLine($"Water left: {string.Join(", ", water)}");

            if (flour.Count == 0)
                Console.WriteLine("Flour left: None");
            else
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
        }


        public class Bakery
        {
            private string product;
            private int water;
            private int flour;

            public Bakery(string product, int water, int flour)
            {
                this.Product = product;
                this.Water = water;
                this.Flour = flour;
                Count = 0;
            }

            public string Product { get; set; }
            public int Water { get; set; }
            public int Flour { get; set; }
            public int Count { get; set; }
        }
    }
}