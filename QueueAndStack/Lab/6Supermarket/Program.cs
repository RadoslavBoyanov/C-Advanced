using System;
using System.Collections.Generic;

namespace _6Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input != "Paid")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    int lenght = queue.Count;
                    for (int i = 0; i < lenght; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
