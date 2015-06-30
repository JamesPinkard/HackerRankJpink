﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupProblems
{
    public static class DiagonalSums
    {
        public static void Solve(string[] args)
        {
            int number = ConsoleHelper.ReadInt();

            string[] nextLines = ConsoleHelper.ReadNextLines(number);
            int[,] grid = ReadIntoGrid(nextLines, number, number);
            int diagonalDifference = GetDiagonalDifference(grid);            
        }

        public static int[,] ReadIntoGrid(string[] nextLines, int number1, int number2)
        {
            int count = nextLines.Length;
            int[,] grid = new int[count, count];

            for (int i = 0; i < nextLines.Length; i++)
            {
                string line = nextLines[i];
                string[] mySplit = line.TrimEnd().Split();

                for (int j = 0; j < mySplit.Length; j++)
                {
                    int num = Convert.ToInt32(mySplit[j]);
                    grid[i, j] = num;
                }                   
            }

            return grid;
        }
        


        public static int GetDiagonalDifference(int[,] grid)
        {
            int gridDim = grid.GetLength(1);
            List<int> firstDiagonal = new List<int>();
            for (int i = 0; i < gridDim; i++)
            {
                int row = i;
                int column = i;

                firstDiagonal.Add(grid[row, column]);
            }

            List<int> secondDiagonal = new List<int>();
            for (int j = 0; j < gridDim; j++)
            {
                int row = j;
                int decrement = j + 1;
                int column = gridDim - decrement;

                secondDiagonal.Add(grid[row, column]);                
            }
            int firstSum = firstDiagonal.Sum();
            int secondSum = secondDiagonal.Sum();
            int dif = Math.Abs(firstSum - secondSum);
            return dif;
        }

    }
}
