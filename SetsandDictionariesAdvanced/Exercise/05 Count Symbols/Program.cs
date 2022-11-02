using System;
using System.Collections.Generic;

namespace _05_Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var countSymbols = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (!countSymbols.ContainsKey(currentSymbol))
                    countSymbols.Add(currentSymbol, 1);
                else
                    countSymbols[currentSymbol]++;
            }

            foreach (var (symbol, timeValue) in countSymbols)
            {
                Console.WriteLine($"{symbol}: {timeValue} time/s");
            }
        }
    }
}
