using System;
using System.Transactions;

namespace _02Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];
            int currentRow = 0;
            int currentColumn = 0;

            for (int rows = 0; rows < sizeOfMatrix; rows++)
            {
                string lines = Console.ReadLine();
                for (int columns = 0; columns < sizeOfMatrix; columns++)
                {
                    matrix[rows, columns] = lines[columns];
                    if (lines[columns] == 'A')
                    {
                        currentRow = rows;
                        currentColumn = columns;
                    }
                }
            }

            int mirrorRow1 = 0;
            int mirrorColumn1 = 0;
            bool isFoundM = false;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    if (matrix[row, col] == 'M')
                    {
                        mirrorRow1 = row;
                        mirrorColumn1 = col;
                        isFoundM = true;
                        if (isFoundM)
                        {
                            break;
                        }
                    }
                }

                if (isFoundM)
                {
                    break;
                }
            }

            int mirrorRow2 = 0;
            int mirrorColumn2 = 0;
            bool isFoundM2 = false;

            for (int row = mirrorRow2; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    if (matrix[row, col] == 'M' && (row != mirrorRow1 && col != mirrorColumn1))
                    {
                        mirrorRow2 = row;
                        mirrorColumn2 = col;
                        isFoundM2 = true;
                        if (isFoundM2)
                        {
                            break;
                        }
                    }
                }

                if (isFoundM2)
                {
                    break;
                }
            }

            int goldCoins = 0;

            
            matrix[currentRow, currentColumn] = '-';

            while (true)
            {
                if (goldCoins >= 65)
                {
                    break;
                }
                string command = Console.ReadLine();

                int oldRow = currentRow;
                int oldCol = currentColumn;
                switch (command)
                {
                    case "up":
                        currentRow--;
                        break;
                    case "down":
                        currentRow++;
                        break;
                    case "left":
                        currentColumn--;
                        break;
                    case "right":
                        currentColumn++;
                        break;  
                }

                if ((currentRow >= 0 && currentRow < sizeOfMatrix) && (currentColumn >= 0 && currentColumn < sizeOfMatrix))
                {
                    if (char.IsDigit(matrix[currentRow, currentColumn]))
                    {
                        goldCoins += Convert.ToInt32(new string(matrix[currentRow, currentColumn], 1));
                        matrix[currentRow, currentColumn] = '-';
                    }
                    else if (currentRow == mirrorRow1 && currentColumn == mirrorColumn1)
                    {
                        currentRow = mirrorRow2;
                        currentColumn = mirrorColumn2;
                        matrix[mirrorRow1, mirrorColumn1] = '-';
                        matrix[mirrorRow2, mirrorColumn2] = '-';
                    }
                    else if (currentRow == mirrorRow2 && currentColumn == mirrorColumn2)
                    {
                        currentRow = mirrorRow1;
                        currentColumn = mirrorColumn1;
                        matrix[mirrorRow1, mirrorColumn1] = '-';
                        matrix[mirrorRow2, mirrorColumn2] = '-';
                    }
                }
                else
                {
                    break;
                }
            }

            if ((currentRow >= 0 && currentRow < sizeOfMatrix) && (currentColumn >= 0 && currentColumn < sizeOfMatrix))
                 matrix[currentRow, currentColumn] = 'A';

            if ((currentRow < 0 || currentRow >= sizeOfMatrix) || (currentColumn < 0 || currentColumn >= sizeOfMatrix))
            {
                Console.WriteLine("I do not need more swords!");
            }

            if (goldCoins >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }

            Console.WriteLine($"The king paid {goldCoins} gold coins.");

            Print(sizeOfMatrix, matrix);

        }


        private static void Print(int sizeOfMatrix, char[,] matrix)
        {
            for (int rows = 0; rows < sizeOfMatrix; rows++)
            {
                for (int columns = 0; columns < sizeOfMatrix; columns++)
                {
                    Console.Write($"{matrix[rows, columns]}");
                }

                Console.WriteLine();
            }
        }
    }
}
