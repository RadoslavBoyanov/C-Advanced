using System;
using System.Collections.Generic;
using System.Linq;

namespace _01TilesMaster
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whites = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Queue<int> greys = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            List<Tile> tile = new List<Tile>()
            {
                new Tile("Sink", 40),
                new Tile("Oven", 50),
                new Tile("Countertop", 60),
                new Tile("Wall", 70),
                new Tile("Floor", -1)
            };
            Tile floor = tile[4];

            while (whites.Any() && greys.Any())
            {
                int whiteTile = whites.Pop();
                int greyTile = greys.Dequeue();

                if (whiteTile == greyTile)
                {
                    int area = greyTile + whiteTile;

                    Tile foundedTiles = tile.FirstOrDefault(x => x.NeededArea == area);
                    if (foundedTiles != null)
                    {
                        foundedTiles.Count++;
                    }
                    else
                    {
                        floor.Count++;
                    }
                }
                else
                {
                    whites.Push(whiteTile / 2);
                    greys.Enqueue(greyTile);
                }
            }

            if (whites.Count <= 0)
                Console.WriteLine("White tiles left: none");
            else
                Console.WriteLine($"White tiles left: {string.Join(", ", whites)}");

            if (greys.Count <= 0)
                Console.WriteLine("Grey tiles left: none");
            else
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greys)}");


            tile = tile.FindAll(x => x.Count > 0).OrderByDescending(n => n.Count).ThenBy(y => y.Type).ToList();

            foreach (var t in tile)
            {
                Console.WriteLine($"{t.Type}: {t.Count}");
            }
        }

        public class Tile
        {
            public Tile(string type, int neededArea)
            {
                Type = type;
                NeededArea = neededArea;
                Count = 0;
            }

            public string Type { get; set; }
            public int NeededArea { get; set; }
            public int Count { get; set; }
        }
    }
}
