using System;
using System.Collections.Generic;
using System.Linq;

namespace _05FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int maxCapacityOfARack = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(clothesInBox);
            int total = 0;
            int racks = 0;
            while (stack.Count > 0)
            {
                if (total + stack.Peek() <= maxCapacityOfARack)
                {
                    total += stack.Pop();
                }
                else
                {
                    total = 0;
                    racks++; 
                }
            }
            if (total <= maxCapacityOfARack)
            {
                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}
