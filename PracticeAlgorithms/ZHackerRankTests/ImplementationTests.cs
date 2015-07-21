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
        public void CutTheSticks_GetCuts_ReturnsList()
        {
            List<int> input = new List<int>() { 5, 4, 4, 2, 2, 8 };

            List<int> numberOfCuts = CutTheSticks.GetCuts(input);

            Assert.AreEqual(new List<int>() {6,4,2,1},numberOfCuts);
        }
    }
}
