using System;
using System.Linq;

namespace Snake_in_the_grass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            char[,] matrix = new char[sizes[0], sizes[1]];

            int counter = -1;

            var snake = Console.ReadLine();

            for (int row = 0; row < sizes[0]; row++)
            {

                if (row % 2 == 0)
                {
                    for (int column = 0; column < matrix.GetLength(1); column++)
                    {
                        if (counter == snake.Length - 1)
                        {
                            counter = -1;
                        }
                        counter++;
                        matrix[row, column] = snake[counter];
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {

                        if (counter == snake.Length - 1)
                        {
                            counter = -1;
                        }
                        counter++;
                        matrix[row, j] = snake[counter];
                    }
                }
            }

            PrintMatrix(matrix);


        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}


