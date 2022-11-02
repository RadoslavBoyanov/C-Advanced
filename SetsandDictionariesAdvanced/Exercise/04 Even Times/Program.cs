using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04_Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var evenTimes = new Dictionary<int, int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!evenTimes.ContainsKey(number))
                {
                    evenTimes.Add(number, 1);
                }
                else
                {
                    evenTimes[number]++;
                }
                
            }

            foreach (var (numberKey, value) in evenTimes)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(numberKey);
                }
            }
        }
    }
}
