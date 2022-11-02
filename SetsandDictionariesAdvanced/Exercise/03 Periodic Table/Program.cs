using System;
using System.Collections.Generic;

namespace _03_Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var table = new SortedSet<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in input)
                {
                    table.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", table));
        }
    }
}
