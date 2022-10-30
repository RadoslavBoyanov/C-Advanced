using System;
using System.Linq;

namespace _3_Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            int diagonalSum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows, columns] = colElements[columns];
                    if (rows == columns)
                        diagonalSum = diagonalSum + matrix[rows, columns];
                }
            }
            Console.WriteLine(diagonalSum);
        }
    }
}
