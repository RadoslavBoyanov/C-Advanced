using System;
using System.Collections.Generic;
using System.Linq;

namespace _02BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] givenNumbersInStack = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            int numbersToPush = numbers[0];
            int numbersToPop = numbers[1];
            int numberToContain = numbers[2];

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(givenNumbersInStack[i]);
            }

            for (int i = 1; i <= numbersToPop; i++)
            {
                stack.Pop();
            }

            int minValue = int.MaxValue;
            if (stack.Count > 0)
            {
                if (stack.Contains(numberToContain))
                {
                    Console.WriteLine("true");
                }
                else
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
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
