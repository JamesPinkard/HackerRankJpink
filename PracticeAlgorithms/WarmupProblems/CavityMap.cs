using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    class CavityMap
    {
        static void Solve(string[] args)
        {
            int numberOfRows = ReadInt();
            int numberOfColumns = numberOfRows;

            int[,] grid = new int[numberOfRows, numberOfColumns];



            for (int r = 0; r < numberOfRows; r++)
            {
                string rowOfNumbers = Console.ReadLine();

                for (int c = 0; c < numberOfColumns; c++)
                {
                    grid[r, c] = Convert.ToInt32(rowOfNumbers[c]);
                }
            }



            for (int r = 0; r < numberOfRows; r++)
            {
                char[] outRow = new char[numberOfColumns];
                for (int c = 0; c < numberOfColumns; c++)
                {
                    int cellValue = grid[r, c];
                    if (c != 0 & c != numberOfColumns - 1 & r != 0 & r != numberOfRows - 1)
                    {
                        int[] neighbors = GetCellNeighbors(grid, r, c);
                        if (IsCavity(cellValue, neighbors))
                        {
                            outRow[c] = 'X';
                        }
                        else
                        {
                            outRow[c] = Convert.ToChar(cellValue);
                        }
                    }
                    else
                    {
                        outRow[c] = Convert.ToChar(cellValue);
                    }
                }
                Console.WriteLine(outRow);
            }
        }

        private static bool IsCavity(int cellValue, int[] neighbors)
        {
            foreach (var n in neighbors)
            {
                if (cellValue <= n)
                {
                    return false;
                }
            }
            return true;
        }

        private static int[] GetCellNeighbors(int[,] grid, int r, int c)
        {
            int north = grid[r - 1, c];
            int east = grid[r, c + 1];
            int south = grid[r + 1, c];
            int west = grid[r, c - 1];
            int[] result = { north, east, south, west };
            return result;
        }

        private static int ReadInt()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            return t;
        }

        private static int[] ReadIntoIntegerArray()
        {
            string line = Console.ReadLine();
            string[] mySplit = line.TrimEnd().Split();

            int lineLength = mySplit.Length;
            int[] result = new int[lineLength];

            for (int i = 0; i < lineLength; i++)
            {
                int part = Convert.ToInt32(mySplit[i]);
                result[i] = part;
            }

            return result;
        }
    }
}
