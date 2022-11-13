using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            List<Sword> swords = new List<Sword>()
            {
                new Sword("Gladius", 70),
                new Sword("Shamshir", 80),
                new Sword("Katana",90),
                new Sword("Sabre", 110),
                new Sword("Broadsword", 150)
            };

            int forgedSwords = 0;

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int valueSteel = steel.Peek();
                int valueCarbon = carbon.Peek();

                int mix = valueSteel + valueCarbon;

                var checking = swords.FirstOrDefault(x => x.ResourcesNeeded == mix);

                if (checking != null)
                {
                    forgedSwords++;
                    checking.Count++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else
                {
                    steel.Dequeue();
                    carbon.Pop();
                    carbon.Push(valueCarbon + 5);
                }
            }

            if (forgedSwords > 0)
                Console.WriteLine($"You have forged {forgedSwords} swords.");
            else
                Console.WriteLine("You did not have enough resources to forge a sword.");

            if (steel.Count == 0)
                Console.WriteLine("Steel left: none");
            else
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            
            if (carbon.Count == 0)
                Console.WriteLine("Carbon left: none");
            else
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");

            swords = swords.Where(x => x.Count > 0).OrderBy(n => n.TypeSword).ToList();

            foreach (var sword in swords)
            {
                Console.WriteLine($"{sword.TypeSword}: {sword.Count}");
            }
        }

        public class Sword
        {

            public Sword(string typeSword, int resourcesNeeded)
            {
                TypeSword = typeSword;
                ResourcesNeeded = resourcesNeeded;
                Count = 0;
            }
            public string TypeSword { get; set; }
            public int ResourcesNeeded { get; set; }
            public int Count { get; set; }
        }
    }
}
