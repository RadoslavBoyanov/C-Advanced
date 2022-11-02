using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lenghtsOfSets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstLenght = lenghtsOfSets[0];
            int secondLenght = lenghtsOfSets[1];

            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < firstLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < secondLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            var newSet = new HashSet<int>();

            foreach (var set in firstSet)
            {
                foreach (var set2 in secondSet)
                {
                    if (set == set2)
                    {
                        newSet.Add(set);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", newSet));
                
            

        }
    }
}
