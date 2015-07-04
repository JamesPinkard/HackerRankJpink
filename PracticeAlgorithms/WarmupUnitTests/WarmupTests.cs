using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using WarmupProblems;
using System.Numerics;

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

        [Test]
        public void Staircase_ReturnThreeStairs()
        {
            int numberOfStairs = 3;
            string stairs = "  #\r\n ##\r\n###";

            string result = Staircase.WriteStairs(numberOfStairs);

            Assert.AreEqual(stairs, result);
        }

        [Test]
        public void BigFactorial_TwentyFive()
        {
            BigInteger number = 25;
            BigInteger expected = BigInteger.Parse("15511210043330985984000000");

            BigInteger factorial = LongFactorials.CalculateFactorial(number);

            Assert.AreEqual(expected, factorial);
        }

        [Test]
        public void TimeConversion_MilitaryTime()
        {
            string expected = "19:05:45";

            DateTime dt = DateTime.Parse("07:05:45PM");
            string formattedDate = String.Format("{0:HH:mm:ss}", dt);
            Assert.AreEqual(expected, formattedDate);
        }
    }
}
