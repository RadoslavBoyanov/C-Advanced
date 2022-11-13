using System;

namespace _02WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            int currentRow = 0;
            int currentCol = 0;
            for (int rows = 0; rows < sizeOfMatrix; rows++)
            {
                string lines = Console.ReadLine();
                for (int cols = 0; cols < sizeOfMatrix; cols++)
                {
                    matrix[rows, cols] = lines[cols];
                    if (matrix[rows, cols] == 'V')
                    {
                        currentRow = rows;
                        currentCol = cols;
                    }
                }
            }

            matrix[currentRow, currentCol] = '*';
            int countOfRods = 0;
            int countOfHoles = 1;
            string direction = Console.ReadLine();
            bool isElocrocuted = false;
            while (direction != "End" && isElocrocuted != true)
            {
                int oldRow = currentRow;
                int oldCol = currentCol;

                switch (direction)
                {
                    case "up":
                        currentRow--;
                        break;
                    case "down":
                        currentRow++;
                        break;
                    case "left":
                        currentCol--;
                        break;
                    case "right":
                        currentCol++;
                        break;
                }

                if ((currentRow >= 0 && currentRow < sizeOfMatrix) && (currentCol >= 0 && currentCol < sizeOfMatrix))
                {
                    if (matrix[currentRow, currentCol] == '-')
                    {
                        matrix[currentRow, currentCol] = '*';
                        countOfHoles++;
                    }
                    else if (matrix[currentRow, currentCol] == 'R')
                    {
                        countOfRods++;
                        Console.WriteLine("Vanko hit a rod!");
                        currentRow = oldRow;
                        currentCol = oldCol;
                    }
                    else if (matrix[currentRow, currentCol] == 'C')
                    {
                        matrix[currentRow, currentCol] = 'E';
                        countOfHoles++;
                        isElocrocuted = true;
                        if (isElocrocuted)
                        {
                           break; 
                        }
                    }
                    else if (matrix[currentRow, currentCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currentRow}, {currentCol}]!");
                    }
                }
                else
                {
                    currentRow = oldRow;
                    currentCol = oldCol;
                }

                direction = Console.ReadLine();
            }

            if (isElocrocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
            }
            else
            {
                matrix[currentRow, currentCol] = 'V';
                Console.WriteLine($"Vanko managed to make {countOfHoles} hole(s) and he hit only {countOfRods} rod(s).");
            }
            Print(sizeOfMatrix, matrix);
        }

        private static void Print(int sizeOfMatrix, char[,] matrix)
        {

            for (int rows = 0; rows < sizeOfMatrix; rows++)
            {
                for (int cols = 0; cols < sizeOfMatrix; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }

                Console.WriteLine();
            }
        }
    }
}
