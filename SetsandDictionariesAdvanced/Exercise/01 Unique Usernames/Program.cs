using System;
using System.Collections.Generic;

namespace _01_Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var usernames = new HashSet<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string name = Console.ReadLine();

                usernames.Add(name);
            }

            foreach (var userName in usernames)
                Console.WriteLine(userName);
        }
    }
}
