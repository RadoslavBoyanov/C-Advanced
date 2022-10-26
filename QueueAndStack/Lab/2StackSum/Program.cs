using System;
using System.Collections.Generic;
using System.Linq;

namespace _2StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split(' ');
                string action = tokens[0].ToLower();
                switch (action)
                {
                    case "add":
                        int firstNum = int.Parse(tokens[1]);
                        int secondNum = int.Parse(tokens[2]);
                        stack.Push(firstNum);
                        stack.Push(secondNum);
                        break;
                    case "remove":
                        int numbersForRemove = int.Parse(tokens[1]);
                        if (numbersForRemove < stack.Count)
                        {
                            for (int i = 0; i < numbersForRemove; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }

                if (action == "end")
                {
                    break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
