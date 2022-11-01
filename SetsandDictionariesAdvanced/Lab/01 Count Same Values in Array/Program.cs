using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            var sameValues = new Dictionary<double, int>();

            for (int number = 0; number < input.Length; number++)
            {
                if (!sameValues.ContainsKey(input[number]))
                {
                    sameValues.Add(input[number], 1);
                }
                else
                {
                    sameValues[input[number]]++;
                }
            }

            foreach (var value in sameValues)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
