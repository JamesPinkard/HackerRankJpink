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

        public static int GetMaxModSum(List<int> testSet, int p)
        {
            throw new NotImplementedException();
        }
    }
}
