using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using Implementation;

namespace ZHackerRankTests
{
    [TestFixture]
    public class ImplementationTests
    {
        [Test]
        [Category("fast")]
        public void CutTheSticks_GetCuts_ReturnsList()
        {
            List<int> input = new List<int>() { 5, 4, 4, 2, 2, 8 };

            List<int> numberOfCuts = CutTheSticks.GetCuts(input);

            Assert.AreEqual(new List<int>() {6,4,2,1},numberOfCuts);
        }

        [Test]
        [Category("fast")]
        public void SherlockBeast_NotPossible_ReturnsNegOne()
        {
            int test = 4;
            string expected = "-1";
            string result = SherlockBeast.Solve(test);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [Category("fast")]
        public void SherlockBeast_Eleven_ReturnsSixFivesFiveThrees()
        {
            int test = 11;
            string expected = "55555533333";
            string result = SherlockBeast.Solve(test);

            Assert.AreEqual(expected, result);
        }

        [Test]
        [Category("fast")]
        public void SherlockBeast_Sixteen()
        {
            int test = 16;
            string expected = "5555553333333333";
            string result = SherlockBeast.Solve(test);

            Assert.AreEqual(expected, result);
        }
    }
}
