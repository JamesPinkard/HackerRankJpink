using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using SearchProblems;

namespace ZHackerRankTests
{
    [TestFixture]
    public class SearchTests
    {
        [Test]
        public void MaxModuloSubset_GetMaxModSum_ReturnsSix()
        {
            int modulo = 7;
            List<int> testSet =  new List<int>(){3, 3, 9, 9, 5};


            int maxSum = MaxModuloSubset.GetMaxModSum(testSet, modulo);

            Assert.AreEqual(6, maxSum);
        }
    }
}
