using System;
using System.Collections.Generic;

namespace _06_Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
