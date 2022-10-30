using System;
using System.Linq;

namespace _6_Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string[] command = Console.ReadLine().Split(" ");

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= 0 && row <= jagged.Length - 1&& col >= 0 && col <= jagged.Length - 1)
                {
                    if (command[0] == "Subtract")
                    {
                        value = -value;
                    }

                    jagged[row][col] += value;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                
                command = Console.ReadLine().Split(" ");
            }

            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
