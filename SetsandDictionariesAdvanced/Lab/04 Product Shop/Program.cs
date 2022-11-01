using System;
using System.Collections.Generic;

namespace _04_Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shopProducts = new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] tokens = input.Split(", ");

                string shop = tokens[0];
                string productName = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shopProducts.ContainsKey(shop))
                    shopProducts[shop] = new Dictionary<string, double>();
               
                if (!shopProducts[shop].ContainsKey(productName))
                    shopProducts[shop].Add(productName, price);

                input = Console.ReadLine();
            }

            foreach (var shop in shopProducts)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var productPrice in shop.Value)
                {
                    Console.WriteLine($"Product: {productPrice.Key}, Price: {productPrice.Value}");
                }
            }
        }
    }
}
