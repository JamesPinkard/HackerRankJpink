using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProblems
{
    class InsertionSort
    {
        static void Solve(string[] args)
        {
            string arrayLen = Console.ReadLine();
            string arrayString = Console.ReadLine();

            int[] numArray = ReadStringIntoNumArray(arrayString);
            IComparer<int> myComparer = new CustomComparer<int>();

            int[] sortedArray = InsertSort(numArray);
        }

        private static int[] InsertSort(int[] inputArray)
        {
            int[] numArray = inputArray;
            int numLength = numArray.Length;
            for (int j = 1; j < numLength; j++)
            {
                // Set array key and comparison position
                int key = numArray[j];
                int i = j - 1;

                // move position numbers up until less than key
                while (i>=0 && numArray[i]>key)
                {
                    numArray[i + 1] = numArray[i];
                    i--;
                }

                // insert key into sorted position
                numArray[i + 1] = key;
                string result = string.Join(" ", numArray);
                Console.WriteLine(result);
            }
            return numArray;
        }

        private static int[] SortFirstPart(int[] numArray)
        {
            int numLength = numArray.Length;

            int lastnumber = numArray[numLength - 1];
            for (int i = numLength - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    numArray[i] = lastnumber;
                    string result = string.Join(" ", numArray);
                    Console.WriteLine(result);
                }
                else if (numArray[i - 1] > lastnumber)
                {
                    numArray[i] = numArray[i - 1];
                    string result = string.Join(" ", numArray);
                    Console.WriteLine(result);
                }
                else
                {
                    numArray[i] = lastnumber;
                    string result = string.Join(" ", numArray);
                    Console.WriteLine(result);
                    break;
                }
            }
            return numArray;
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

        public class CustomComparer<T> : IComparer<T> where T : IComparable
        {
            public int Compare(T x, T y)
            {
                return x.CompareTo(y);
            }
        }
    }
}
