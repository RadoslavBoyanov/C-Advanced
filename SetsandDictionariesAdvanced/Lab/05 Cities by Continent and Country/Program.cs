using System;
using System.Collections.Generic;

namespace _05_Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfInputs = int.Parse(Console.ReadLine());

            var populatedPlace = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numbersOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!populatedPlace.ContainsKey(continent))
                    populatedPlace.Add(continent, new Dictionary<string, List<string>>());

                if (!populatedPlace[continent].ContainsKey(country))
                    populatedPlace[continent].Add(country, new List<string>());

                populatedPlace[continent][country].Add(city);
                
            }

            foreach (var (continent, countries) in populatedPlace)
            {
                Console.WriteLine($"{continent}:");
                foreach (var (country, cities) in countries)
                {
                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
