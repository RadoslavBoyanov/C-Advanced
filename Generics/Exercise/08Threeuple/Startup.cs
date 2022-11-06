using System;

namespace _08Threeuple
{
    public class Startup
    {
        static void Main(string[] args)
        {
            string[] personAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] personDringkingBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] personBank = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Threeuple<string, string, string> personTuple = new Threeuple<string, string, string>
            {
                Item1 = $"{personAdress[0]} {personAdress[1]}",
                Item2 = $"{personAdress[2]}",
                Item3 = $"{personAdress[3]}"
            };
            Threeuple<string, int, bool> isPersonDrunk = new Threeuple<string, int, bool>
            {
                Item1 = $"{personDringkingBeer[0]}",
                Item2 = int.Parse(personDringkingBeer[1]),
                Item3 = "drunk" == $"{personDringkingBeer[2]}" 
            };
            Threeuple<string, double, string> personAndHisBank = new Threeuple<string ,double, string>
            {
                Item1 = $"{personBank[0]}",
                Item2 = double.Parse(personBank[1]),
                Item3 = $"{personBank[2]}"
            };

            Console.WriteLine(personTuple);
            Console.WriteLine(isPersonDrunk);
            Console.WriteLine(personAndHisBank);
        }
    }
}
