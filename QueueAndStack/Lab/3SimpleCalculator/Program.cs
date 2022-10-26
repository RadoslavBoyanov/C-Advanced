using System;
using System.Collections.Generic;
using System.Linq;

namespace _3SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(" ");
            var stack = new Stack<string>(numbers.Reverse());
            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int second = int.Parse(stack.Pop());
                switch (operation)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
