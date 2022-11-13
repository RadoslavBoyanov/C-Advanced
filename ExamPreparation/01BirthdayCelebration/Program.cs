using System;
using System.Collections.Generic;
using System.Linq;

namespace _01BirthdayCelebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guest = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> plate = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int wastedFood = 0;

            while (guest.Count > 0 && plate.Count > 0)
            {
                int enteredGuest = guest.Dequeue();
                int gramsOfFood = plate.Pop();

                while (enteredGuest > 0)
                {
                    enteredGuest -= gramsOfFood;
                    if (enteredGuest <= 0)
                    {
                        wastedFood += Math.Abs(enteredGuest);
                        break;
                    }
                    else
                    {
                        gramsOfFood = plate.Pop();
                        
                    }
                }
            }

            if (plate.Count > 0)
                Console.WriteLine($"Plates: {string.Join(" ", plate)}");
            if (guest.Count > 0)
                Console.WriteLine($"Guests: {string.Join(" ", guest)}");
          
            Console.WriteLine($"Wasted grams of food: {wastedFood}");


        }
    }
}

