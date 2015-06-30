using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    class DiagonalSums
    {
        static void Solve(string[] args)
        {
            int number = ConsoleHelper.ReadInt();

            string[] nextLines = ConsoleHelper.ReadNextLines(number);
            int[,] grid = ReadIntoGrid(nextLines, number, number);
            int diagonalDifference = GetDiagonalDifference(grid);            
        }

        private static int[,] ReadIntoGrid(string[] nextLines, int number1, int number2)
        {
            int count = nextLines.Length;
            int[,] grid = new int[count, count];

            for (int i = 0; i < nextLines.Length; i++)
            {
                string line = Console.ReadLine();
                string[] mySplit = line.TrimEnd().Split();

                for (int j = 0; j < mySplit.Length; j++)
                {
                    int num = Convert.ToInt32(mySplit[j]);
                    grid[i, j] = num;
                }                   
            }

            return grid;
        }
        


        private static int GetDiagonalDifference(int[,] grid)
        {
            throw new NotImplementedException();
        }

    }
}
