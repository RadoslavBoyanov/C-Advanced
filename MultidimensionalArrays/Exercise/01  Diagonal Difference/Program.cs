using System;
using System.Linq;

namespace _01__Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int column = 0; column < matrixSize; column++)
                {
                    matrix[row, column] = colElements[column];
                    if (row == column)
                    {
                        primaryDiagonal += matrix[row, column];
                    }

                    if ((row + column) == (matrixSize - 1))
                    {
                        secondaryDiagonal += matrix[row, column];
                    }
                }
            }

            int diff = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(diff);
        }
    }
}
