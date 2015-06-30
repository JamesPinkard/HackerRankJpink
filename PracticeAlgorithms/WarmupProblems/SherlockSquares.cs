using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockSquares
{
    class SherlockSquares
    {
        static void Solve(String[] args)
        {
            int numberOfTests = ReadInt();
            for (int i = 0; i < numberOfTests; i++)
            {
                int[] Numbers = ReadIntoIntegerArray();
                int firstNum = Numbers[0];
                int lastNum = Numbers[1];

                double firstSquare = Math.Sqrt(firstNum);
                int firstSquareInt = Convert.ToInt32(Math.Ceiling(firstSquare));

                double secondSquare = Math.Sqrt(lastNum);
                int lastSquareInt = Convert.ToInt32(Math.Floor(secondSquare));

                int numOfSquares = 1 + (lastSquareInt - firstSquareInt);
                Console.WriteLine(numOfSquares);
            }
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