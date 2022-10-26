using System;
using System.Collections.Generic;

namespace _4MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    int startIndex = stack.Pop();
                    string contents = input.Substring(startIndex,i - startIndex + 1);
                    Console.WriteLine(contents);
                }
            }
        }
    }
}
