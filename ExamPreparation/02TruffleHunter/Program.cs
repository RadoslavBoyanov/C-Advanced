using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _02TruffleHunter
{
    class Program
    {
        static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            for (int rows = 0; rows < sizeOfMatrix; rows++)
            {
                string[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int cols = 0; cols < sizeOfMatrix; cols++)
                {
                    matrix[rows, cols] = Convert.ToChar(lines[cols]);
                }
            }

            Dictionary<string, int> truffles = new Dictionary<string, int>()
            {
                {"black", 0},
                {"summer", 0},
                {"white", 0}
            };

            int eatentrufflesFromBoar = 0;

            string command = Console.ReadLine();
            while (command != "Stop the hunt")
            {
                string[] actions = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(actions[1]);
                int col = int.Parse(actions[2]);
                switch (actions[0])
                {
                    case "Collect":
                        if ((row >= 0 && row < sizeOfMatrix) && (col >= 0 && col < sizeOfMatrix))
                        {
                            if (matrix[row, col] == 'B')
                            {
                                truffles["black"]++;
                                matrix[row, col] = '-';
                            }
                            else if (matrix[row, col] == 'S')
                            {
                                truffles["summer"]++;
                                matrix[row, col] = '-';
                            }
                            else if (matrix[row, col] == 'W')
                            {
                                truffles["white"]++;
                                matrix[row, col] = '-';
                            }
                        }
                        break;
                    case "Wild_Boar":
                        string direction = actions[3];
                        
                            switch (direction)
                            {
                                case "up":
                                    for (int rows = row; rows >= 0; rows-=2)
                                    {
                                        for (int cols = col; cols == col; cols++)
                                        {
                                            if (matrix[rows, col] == 'S' || matrix[rows, col] == 'W' || matrix[rows, col] == 'B')
                                            {
                                                eatentrufflesFromBoar++;
                                                matrix[rows, col] = '-';
                                            }
                                        }
                                    }
                                    break;
                                case "down":
                                    for (int rows = row; rows < sizeOfMatrix; rows += 2)
                                    {
                                        for (int cols = col; cols == col; cols++)
                                        {
                                            if (matrix[rows, col] == 'S' || matrix[rows, col] == 'W' || matrix[rows, col] == 'B')
                                            {
                                                eatentrufflesFromBoar++;
                                                matrix[rows, col] = '-';
                                            }
                                        }
                                    }
                                    break;
                                case "left":
                                    for (int rows = row; rows == row; rows++)
                                    {
                                        for (int columns = col; columns >= 0; columns -= 2)
                                        {
                                            if (matrix[row, columns] == 'S' || matrix[row, columns] == 'W' || matrix[row, columns] == 'B')
                                            {
                                                eatentrufflesFromBoar++;
                                                matrix[row, columns] = '-';
                                            }
                                        }
                                    }
                                    break;
                                case "right":
                                    for (int rows = row; rows == row; rows++)
                                    {
                                        for (int columns = col; columns < sizeOfMatrix; columns += 2)
                                        {
                                            if (matrix[row, columns] == 'S' || matrix[row, columns] == 'W' || matrix[row, columns] == 'B')
                                            {
                                                eatentrufflesFromBoar++;
                                                matrix[row, columns] = '-';
                                            }
                                        }
                                    }
                                    break;
                            
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Peter manages to harvest {truffles["black"]} black, {truffles["summer"]} summer, and {truffles["white"]} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatentrufflesFromBoar} truffles.");

            Print(sizeOfMatrix, matrix);
        }

        private static void Print(int sizeOfMatrix, char[,] matrix)
        {
            for (int rows = 0; rows < sizeOfMatrix; rows++)
            {
                for (int cols = 0; cols < sizeOfMatrix; cols++)
                {
                    Console.Write($"{matrix[rows, cols]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
