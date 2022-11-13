using System;
using System.Linq;
using System.Threading.Channels;

namespace _02RallyRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int racingNumber = int.Parse(Console.ReadLine());

            string[,] matrix = new string[sizeOfMatrix, sizeOfMatrix];
            int currentRow = 0;
            int currentCol = 0;
            int tunnelEntryRow1 = -1;
            int tunnelEntryCol1 = -1;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                string[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    matrix[row, col] = lines[col].ToString();
                }
            }

            int tunnelEntryRow2 = -1;
            int tunnelEntryCol2 = -1;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                for (int col = 0; col < sizeOfMatrix; col++)
                {

                    if (matrix[row, col] == "T")
                    {
                        if (tunnelEntryRow1 < 0 && tunnelEntryCol1 < 0)
                        {
                            tunnelEntryRow1 = row;
                            tunnelEntryCol1 = col;
                        }
                        else
                        {
                            tunnelEntryRow2 = row;
                            tunnelEntryCol2 = col;
                        }
                    }
                }

                int kilometersPassed = 0;
                bool isReachFinish = false;
                string command = Console.ReadLine();

                while (command != "End" && isReachFinish != true)
                {
                    switch (command)
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

                    if (matrix[currentRow, currentCol] == "T")
                    {
                        kilometersPassed += 30;
                        if (currentRow == tunnelEntryRow1 && currentCol == tunnelEntryCol1)
                        {
                            currentRow = tunnelEntryRow2;
                            currentCol = tunnelEntryCol2;
                            matrix[tunnelEntryRow1, tunnelEntryCol1] = ".";
                            matrix[tunnelEntryRow2, tunnelEntryCol2] = ".";
                        }
                        else if (currentRow == tunnelEntryRow2 && currentCol == tunnelEntryCol2)
                        {
                            currentRow = tunnelEntryRow1;
                            currentCol = tunnelEntryCol1;
                            matrix[tunnelEntryRow1, tunnelEntryCol1] = ".";
                            matrix[tunnelEntryRow2, tunnelEntryCol2] = ".";
                        }
                    }
                    else if (matrix[currentRow, currentCol] == ".")
                    {
                        kilometersPassed += 10;
                    }
                    else if (matrix[currentRow, currentCol] == "F")
                    {
                        kilometersPassed += 10;
                        isReachFinish = true;
                    }

                    command = Console.ReadLine();
                }

                matrix[currentRow, currentCol] = "C";

                if (isReachFinish)
                    Console.WriteLine($"Racing car {racingNumber} finished the stage!");
                else
                    Console.WriteLine($"Racing car {racingNumber} DNF.");

                Console.WriteLine($"Distance covered {kilometersPassed} km.");

                Print(sizeOfMatrix, matrix);
            }

            static void Print(int sizeOfMatrix, string[,] matrix)
            {
                for (int row = 0; row < sizeOfMatrix; row++)
                {
                    for (int col = 0; col < sizeOfMatrix; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
