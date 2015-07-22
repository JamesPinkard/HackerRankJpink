using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NUnit.Framework;

using SearchProblems;

namespace ZHackerRankTests
{
    [TestFixture]
    public class SearchTests
    {
        [Test]
        [Category("fast")]
        public void MaxModuloSubset_GetMaxModSum_ReturnsSix()
        {
            Int64 modulo = 7;
            List<Int64> testSet = new List<Int64>() { 3, 3, 9, 9, 5 };


            Int64 maxSum = MaxModuloSubset.GetMaxModSum(testSet, modulo);

            Assert.AreEqual(6, maxSum);
        }

        [Test]
        [Category("reads test file")]
        public void MaxModuloSubset_GetMaxModSum_TestFile06()
        {
            using (StringReader output = new StringReader(myText.maxmod_output06))
            using (StringReader input = new StringReader(myText.maxmod_input06))
            {
                int tests = Convert.ToInt32(input.ReadLine());
                for (int t = 0; t < tests; t++)
                {
                    Int64[] length_mod = ReadStringIntoBigNumArray(input.ReadLine());
                    Int64 length = length_mod[0];
                    Int64 modulo = length_mod[1];
                    List<Int64> mySet = ReadStringIntoBigNumList(input.ReadLine());
                    Int64 expected = Convert.ToInt64(output.ReadLine());
                    
                    Int64 maxSum = MaxModuloSubset.GetMaxModSum(mySet, modulo);
                    
                    Assert.AreEqual(expected, maxSum);
                }
            }
        }

        #region Helper Methods
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
        #endregion  

    }
}
