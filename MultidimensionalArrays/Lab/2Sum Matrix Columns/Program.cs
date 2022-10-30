using System;
using System.Linq;

namespace _2Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] columnsElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows, columns] = columnsElements[columns];
                }
            }

            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                int colSum = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    colSum += matrix[rows, columns];
                }

                Console.WriteLine(colSum);
            }
        }
    }
}
