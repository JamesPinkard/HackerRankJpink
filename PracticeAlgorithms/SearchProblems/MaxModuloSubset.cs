using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProblems
{
    public class MaxModuloSubset
    {

        static void Solve(string[] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < tests; t++)
            {
                Int64[] length_mod = ReadStringIntoBigNumArray(Console.ReadLine());
                Int64 length = length_mod[0];
                Int64 modulo = length_mod[1];
                List<Int64> mySet = ReadStringIntoBigNumList(Console.ReadLine());
                Int64 maxSum = GetMaxModSum(mySet, modulo);
                Console.WriteLine(maxSum);
            }
        }

        // Practice 2
        // Check through every possible subset in a list of numbers
        // Return true if the sum of a subset equals the target sum
        static bool CanMakeSum(List<int> nums, int targetSum)
        {
            List<int> soFar = new List<int>();
            return RecMakeSum(soFar, nums, targetSum);
        }

        static bool RecMakeSum(List<int> soFar, List<int> nums, int targetSum)
        {
            if (nums.Count == 0)
            {
                return soFar.Sum() == targetSum;
            }
            else
            {
                List<int> nextNums = new List<int>();
                nextNums = nums.GetRange(1, nums.Count - 1);

                List<int> nextSoFar = new List<int>();
                nextSoFar.AddRange(soFar);
                nextSoFar.Add(nums[0]);

                if (RecMakeSum(nextSoFar, nextNums, targetSum)) return true;
                if (RecMakeSum(soFar, nextNums, targetSum)) return true;
                else
                {
                    return false;
                }
            }
        }

        public static Int64 GetMaxModSum(List<Int64> testSet, Int64 modulo)
        {
            int count = testSet.Count;            
            Int64 max = 0;
            Int64 maxPossibleNumber = modulo - 1;
            
            for (int i = 0; i < count; i++)
            {
                Int64 sum = 0;
                for (int j = i; j < count; j++)
                {
                    sum += testSet[j];
                    Int64 modSum = sum % modulo;

                    if (modSum > max)
                    {
                        max = modSum;                        
                    }
                }
            }

            return max;
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

        public static Int64[] ReadStringIntoBigNumArray(string numString)
            {
                string[] mySplit = numString.TrimEnd().Split();
                Int64[] numArray = new Int64[mySplit.Length];
                for (int j = 0; j < mySplit.Length; j++)
                {
                    Int64 num = Convert.ToInt64(mySplit[j]);
                    numArray[j] = num;
                }
                return numArray;
            }

        public static List<Int64> ReadStringIntoBigNumList(string numString)
            {
                string[] mySplit = numString.TrimEnd().Split();
                List<Int64> numList = new List<Int64>(mySplit.Length);
                for (int j = 0; j < mySplit.Length; j++)
                {
                    Int64 num = Convert.ToInt64(mySplit[j]);
                    numList.Add(num);
                }
                return numList;
            }
    }
}
