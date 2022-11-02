using System;
using System.Collections.Generic;

namespace _06_Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] colorAndClothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = colorAndClothes[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                string dress = colorAndClothes[1];
                string[] clothes = dress.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var cloth in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }
                    wardrobe[color][cloth]++;
                }
            }

            string[] searchedClothe = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if (searchedClothe[0] == color.Key && searchedClothe[1] == cloth.Key)
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    else
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }
    }
}
