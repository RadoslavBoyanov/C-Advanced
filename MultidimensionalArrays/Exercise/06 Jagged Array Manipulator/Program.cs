using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06_Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaged = new double[rows][];

            for (int row = 0; row < jaged.Length; row++)
            {
                jaged[row] = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            }

            for (int row = 0; row < jaged.Length - 1; row++)
            {
                if (jaged[row].Length == jaged[row + 1].Length)
                {
                    for (int i = 0; i < jaged[row].Length; i++)
                    {
                        jaged[row][i] = jaged[row][i] * 2;
                    }

                    for (int j = 0; j < jaged[row + 1].Length; j++)
                    {
                        jaged[row + 1][j] = jaged[row+1][j] * 2;
                    }
                }
                else if (jaged[row].Length != jaged[row + 1].Length)
                {
                    for (int i = 0; i < jaged[row].Length; i++)
                    {
                        jaged[row][i] = jaged[row][i] / 2;
                    }

                    for (int j = 0; j < jaged[row + 1].Length; j++)
                    {
                        jaged[row + 1][j] = jaged[row + 1][j] / 2;
                    }
                }
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] tokens = commands.Split(" ").ToArray();

                string operation = tokens[0];

                switch (operation)
                {
                    case "Add":
                    {
                        int row = int.Parse(tokens[1]);
                        int column = int.Parse(tokens[2]);
                        int value = int.Parse(tokens[3]);
                        if (row >= 0 && row <= rows - 1 && column >= 0 && column <= jaged[row].Length - 1)
                        {
                            jaged[row][column] += value;
                        }
                       
                    }
                        break;
                    case "Subtract":
                    {
                        int row = int.Parse(tokens[1]);
                        int column = int.Parse(tokens[2]);
                        int value = int.Parse(tokens[3]);
                        if (row >= 0 && row <= rows - 1 && column >= 0 && column <= jaged[row].Length - 1)
                        {
                            jaged[row][column] -= value;
                        }
                    }
                        break;
                }

                commands = Console.ReadLine();
            }

            foreach (var array in jaged)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
