using System;
using System.Collections.Generic;
using System.Linq;

namespace _01MealPlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> meal =
                new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Stack<int> dailyCalories =
                new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> dishes = new Dictionary<string, int>()
            {
                {"salad" , 350},
                {"soup", 490},
                {"pasta", 680},
                {"steak", 790}
            };

            int caloriesForNextDay = 0;
            int eatedMeals = 0;
            
            while (meal.Count > 0 && dailyCalories.Count > 0)
            {
                string caloriesFromEat = meal.Peek();
                int calories = dailyCalories.Pop();

                if (caloriesForNextDay > 0)
                {
                    calories -= caloriesForNextDay;
                }

                caloriesForNextDay = 0;

                calories -= dishes[caloriesFromEat];
                meal.Dequeue();
                eatedMeals++;

                if (calories  <= 0)
                {
                    caloriesForNextDay = Math.Abs(calories);
                }
                else
                {
                    dailyCalories.Push(calories);
                }
            }

            if (caloriesForNextDay > 0 && dailyCalories.Count > 0)
            {
                int calories = dailyCalories.Pop();
                calories -= caloriesForNextDay;
                dailyCalories.Push(calories);
            }

            if (meal.Count == 0)
            {
                Console.WriteLine($"John had {eatedMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", dailyCalories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {eatedMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meal)}.");
            }
        }
    }
}
