using System;
using System.Linq;

namespace _03_Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = colElements[column];
                }
            }

            long squareSum = 0;
            long maxSum = long.MinValue;
            string bestValue = string.Empty;

            for (int row = 0; row < matrix.GetLength(0) - 2 ; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    squareSum = matrix[row, column] +
                                matrix[row + 1, column] +
                                matrix[row + 2, column] +
                                matrix[row, column + 1] +
                                matrix[row, column + 2] +
                                matrix[row + 1, column + 2] +
                                matrix[row + 2, column + 1] +
                                matrix[row + 1, column + 1] +
                                matrix[row + 2, column + 2];
                    if (squareSum > maxSum)
                    {
                        maxSum = squareSum;
                        bestValue =
                            $"{matrix[row, column]} {matrix[row, column + 1]} {matrix[row, column + 2]}\r\n{matrix[row + 1, column]} {matrix[row + 1, column + 1]} {matrix[row + 1, column + 2]}\r\n{matrix[row + 2, column]} {matrix[row + 2, column + 1]} {matrix[row + 2, column + 2]}";
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(bestValue);
        }
    }
}
