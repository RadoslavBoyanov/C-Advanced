using System;
using System.Collections.Generic;
using System.Linq;

namespace _5PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    queue.Enqueue(number);
                }   
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
