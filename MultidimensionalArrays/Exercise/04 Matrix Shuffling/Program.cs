using System;
using System.Linq;

namespace _04_Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrixSize[0]; row++)
            {
                string[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int column = 0; column < matrixSize[1]; column++)
                {
                    matrix [row, column] = colElements[column];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(" ").ToArray();

                if (tokens[0] == "swap")
                {
                    
                    if (tokens.Length == 5)
                    {
                        int row1 = int.Parse(tokens[1]);
                        int column1 = int.Parse(tokens[2]);
                        int row2 = int.Parse(tokens[3]);
                        int column2 = int.Parse(tokens[4]);
                        if ((row1 >= 0 && row1 <= matrixSize[0]) && (row2 >= 0 && row2 <= matrixSize[0] - 1) && (column1 >= 0 && column1 <= matrixSize[1] - 1) && (column2 >= 0 && column2 <= matrixSize[1] - 1))
                        {
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int column = 0; column < matrix.GetLength(1); column++)
                                {
                                    if (row == row1 && column == column1)
                                    {
                                        var temp = matrix[row1, column1];
                                        matrix[row1, column1] = matrix[row2, column2];
                                        matrix[row2, column2] = temp;

                                        for (int i = 0; i < matrix.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < matrix.GetLength(1); j++)
                                            {
                                                Console.Write($"{matrix[i, j]} ");
                                            }

                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
