using System;
using System.Linq;

namespace _4_Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[matrixSize, matrixSize];

            for (int rows = 0; rows < matrixSize; rows++)
            {
                string colElements = Console.ReadLine();
                for (int columns = 0; columns < matrixSize; columns++)
                {
                    matrix[rows, columns] = colElements[columns].ToString();
                }
            }

            string symbol = Console.ReadLine();
            bool isThereASameSymbol = false;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    if (matrix[rows, columns] == symbol)
                    {
                        Console.WriteLine($"({rows}, {columns})");
                        isThereASameSymbol = true;
                        break;
                    }
                }

                if (isThereASameSymbol == true)
                {
                    break;
                }
            }

            if (isThereASameSymbol == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
