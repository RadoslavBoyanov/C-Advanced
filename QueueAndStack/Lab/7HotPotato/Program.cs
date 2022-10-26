using System;
using System.Collections.Generic;

namespace _7HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] childrens = Console.ReadLine().Split(" ");
            var queue = new Queue<string>(childrens);
            int turnEliminate = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < turnEliminate; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
