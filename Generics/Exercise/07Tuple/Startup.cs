using System;

namespace _07Tuple
{
    public class Startup
    {
        static void Main(string[] args)
        {
            string[] personAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] personDringkingBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] numberSplit = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string> personTuple = new Tuple<string,string>
            {
                Item1 = $"{personAdress[0]} {personAdress[1]}",
                Item2 = $"{personAdress[2]}"
            };
            Tuple<string, int> personDrinking = new Tuple<string, int>
            {
                Item1 = $"{personDringkingBeer[0]}",
                Item2 = int.Parse(personDringkingBeer[1])
            };
            Tuple<int, double> numbers = new Tuple<int, double>
            {
                Item1 = int.Parse(numberSplit[0]),
                Item2 = double.Parse(numberSplit[1])
            };

            Console.WriteLine(personTuple);
            Console.WriteLine(personDrinking);
            Console.WriteLine(numbers);
        }
    }
}
