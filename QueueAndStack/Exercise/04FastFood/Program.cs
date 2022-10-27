using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _04FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                if (quantityOfFood >= queue.Peek())
                {
                    quantityOfFood -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");

        }
    }
}
