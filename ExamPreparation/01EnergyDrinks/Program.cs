using System;
using System.Collections.Generic;
using System.Linq;

namespace _01EnergyDrinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeine = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> energyDrink = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int stamatLimit = 300;
            int stamatCaffeine = 0;

            while (caffeine.Count > 0 && energyDrink.Count > 0)
            {
                int mgCaffeine = caffeine.Peek();
                int mlDrink = energyDrink.Peek();
                int result = mgCaffeine * mlDrink;
                
                if (result + stamatCaffeine <= 300)
                {
                    caffeine.Pop();
                    energyDrink.Dequeue();
                    stamatCaffeine += result;
                    
                }
                else
                {
                    caffeine.Pop();
                    energyDrink.Dequeue();
                    energyDrink.Enqueue(mlDrink);
                    if (stamatCaffeine != 0)
                    {
                        stamatCaffeine -= 30;
                    }
                }
            }

            if (energyDrink.Count > 0)
                Console.WriteLine($"Drinks left: {string.Join(", ", energyDrink)}");
            
            else
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");


            Console.WriteLine($"Stamat is going to sleep with {stamatCaffeine} mg caffeine.");
        }
    }
}
