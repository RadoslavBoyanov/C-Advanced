using System;
using System.Collections.Generic;

namespace _03MaxandMinEl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            var stack = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');

                if (numbers[0] == "1")
                {
                    int numberToPush = int.Parse(numbers[1]);
                    stack.Push(numberToPush);
                }
                else if (numbers[0] == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (numbers[0] == "3")
                {
                    if (stack.Count > 0)
                    {
                        foreach (var number in stack)
                        {
                            if (number > maxValue)
                            {
                                maxValue = number;
                            }
                        }

                        Console.WriteLine(maxValue);
                    }
                }
                else if (numbers[0] == "4")
                {
                    if (stack.Count > 0)
                    {
                        foreach (var number in stack)
                        {
                            if (number < minValue)
                            {
                                minValue = number;
                            }
                        }

                        Console.WriteLine(minValue);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
