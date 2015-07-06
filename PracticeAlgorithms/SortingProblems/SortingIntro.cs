using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    class SortingIntro
    {
        static void Solve(string[] args)
        {
            int findNum = Convert.ToInt32(Console.ReadLine());
            int arrayLen = Convert.ToInt32(Console.ReadLine());

            string inputArray = Console.ReadLine();
            int[] numArray = ReadStringIntoNumArray(inputArray);

            int index = FindInt(numArray, findNum);
            Console.WriteLine(index);
        }

        public static int[] ReadStringIntoNumArray(string numString)
        {
            string[] mySplit = numString.TrimEnd().Split();
            int[] numArray = new int[mySplit.Length];
            for (int j = 0; j < mySplit.Length; j++)
            {
                int num = Convert.ToInt32(mySplit[j]);
                numArray[j] = num;
            }
            return numArray;
        }

        private static int FindInt(int[] numArray, int findNum)
        {
            int len = numArray.Length;

            for (int i = 0; i < len; i++)
            {
                if (numArray[i] == findNum)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
