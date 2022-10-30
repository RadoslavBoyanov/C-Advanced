using System;
using System.Linq;

namespace _5_Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows, columns] = colElements[columns];
                }
            }
            int squareSum = 0;
            long biggestValue = long.MinValue;
            string numbersInBigestValue = "";

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++)
                {
                    squareSum = matrix[rows + 1, columns] +
                                matrix[rows, columns + 1] +
                                matrix[rows, columns] +
                                matrix[rows + 1, columns + 1];
                    if (squareSum > biggestValue)
                    {
                        biggestValue = squareSum;
                        numbersInBigestValue =
                            $"{matrix[rows, columns]} {matrix[rows, columns + 1]} \r\n{matrix[rows + 1, columns]} {matrix[rows + 1, columns + 1]}";
                    }
                }
            }

            Console.WriteLine(numbersInBigestValue);
            Console.WriteLine(biggestValue);
        }
    }
}
