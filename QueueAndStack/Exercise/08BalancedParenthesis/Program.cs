using System;
using System.Collections.Generic;
using System.Linq;

namespace _08BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var p in parentheses)
            {
                if (parentheses.Any())
                {
                    char check = stack.Peek();
                    if (check == '{' && p == '}')
                    {
                        stack.Pop();
                        continue;
                    } 
                    if (check == '[' && p == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    if (check == '(' && p == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(p);
            }

            if (parentheses.Any())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
