using System;
using System.Linq;

namespace _1SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            (int rowsCount, int columnsCount) = (matrixSize[0], matrixSize[1]);

            int[,] matrix = new int[rowsCount, columnsCount];

            long sum = 0;

            for (int rows = 0; rows < rowsCount; rows++)
            {
                int[] colsElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int columns = 0; columns < columnsCount; columns++)
                {
                    matrix [rows, columns] = colsElements[columns];
                    sum += matrix[rows, columns];
                }
            }

            Console.WriteLine(rowsCount);
            Console.WriteLine(columnsCount);
            Console.WriteLine(sum);
        }
    }
}
