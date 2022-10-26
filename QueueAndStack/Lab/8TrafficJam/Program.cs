using System;
using System.Collections.Generic;

namespace _8TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsPassingOnGreenLight = int.Parse(Console.ReadLine());

            var queue = new Queue<string>();
            int countCrossroad = 0;

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command != "green")
                {
                    queue.Enqueue(command);
                }
                else if (command == "green")
                {
                    for (int i = 0; i < carsPassingOnGreenLight; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            countCrossroad++;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{countCrossroad} cars passed the crossroads.");
        }
    }
}
