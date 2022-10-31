using System;
using System.Linq;

namespace _02_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = colElements[column];
                }
            }

            int squareMatrixCounter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    if (matrix[row, column] == matrix[row + 1, column] &&
                        matrix[row, column] == matrix[row, column + 1] &&
                        matrix[row, column] == matrix[row + 1, column + 1])
                    {
                        squareMatrixCounter++;
                    }
                }
            }

            Console.WriteLine(squareMatrixCounter);
        }
    }
}
