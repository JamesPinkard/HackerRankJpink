using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using WarmupProblems;

namespace WarmupUnitTests
{
    [TestFixture]
    public class WarmupTests
    {
        string[] testString = new string[] {"3 5 7", "4 9 2","5 2 0"};

        [Test]
        public void ReadIntoGrid_YieldsArray()
        {
            // Setup

            int[,] grid = DiagonalSums.ReadIntoGrid(testString, 3, 3);

            Assert.AreEqual(0, grid[2, 2]);
            Assert.AreEqual(3, grid.GetLength(1));
        }

        [Test]
        public void GetDiagonalDifference_YieldsDifference()
        {
            int[,] grid = DiagonalSums.ReadIntoGrid(testString, 3, 3);

            int difference = DiagonalSums.GetDiagonalDifference(grid);

            
            Assert.AreEqual(21 - 12, difference);
        }
    }
}
