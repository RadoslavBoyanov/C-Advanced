using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            var dictinioryGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!dictinioryGrades.ContainsKey(name))
                    dictinioryGrades.Add(name, new List<decimal>());
                dictinioryGrades [name].Add(grade);
                
            }

            foreach (var (name, gradesList) in dictinioryGrades)
            {
                var average = gradesList.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in gradesList)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
