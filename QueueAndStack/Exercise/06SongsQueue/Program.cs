using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _06SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string[] songsInQueue = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < songsInQueue.Length; i++)
            {
                queue.Enqueue(songsInQueue[i]);
            }

            string command = Console.ReadLine();

            while (queue.Any())
            {

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    var song = command.Substring(4);
                    if (queue.Contains(song))
                        Console.WriteLine($"{song} is already contained!");
                    else
                        queue.Enqueue(song);
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
