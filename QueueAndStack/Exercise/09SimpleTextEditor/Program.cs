using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            stack.Push(sb.ToString());

            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] operations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int action = int.Parse(operations[0]);

                switch (action)
                {
                    case 1:
                        string text = operations[1];
                        sb.Append(text);
                        stack.Push(sb.ToString());
                        break;
                    case 2:
                        int erases = int.Parse(operations[1]);
                        sb.Remove(sb.Length - erases, erases);
                        stack.Push(sb.ToString());
                        break;
                    case 3:
                        int index = int.Parse(operations[1]);
                        Console.WriteLine(sb[index - 1]);
                        break;
                    case 4:
                        stack.Pop();
                        sb = new StringBuilder();
                        sb.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}
