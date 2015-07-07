using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using WarmupProblems;
using System.Numerics;

namespace UnitHackerRankTests
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

        [Test]
        public void CaeserCipher_phrase_TwoRotations()
        {
            int length = 11;
            string testPhrase = "middle-Outz";
            int rotation = 2;

            string result = CaeserCipher.CaeserEncrypt(length, testPhrase, rotation);

            Assert.AreEqual("okffng-Qwvb", result);
        }

        [Test]
        public void DateTime_Test()
        {
            string date = "9 6 2015";
            string[] dateArray = date.TrimEnd().Split();

            int iday = Convert.ToInt32(dateArray[0]);
            int imonth = Convert.ToInt32(dateArray[1]);
            int iyear = Convert.ToInt32(dateArray[2]);

            DateTime dt = new DateTime(iyear, imonth, iday);

            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;

            Assert.AreEqual(6, month);
        }

        [Test]
        public void DateTime_MinusSpan_ReturnsDaysMonthsYears()
        {
            string returnedDate = "9 6 2015";
            string dueDate = "6 6 2015";

            DateTime retDate = LibraryFine.GetDate_DMY_Format(returnedDate);
            DateTime expectedDate = LibraryFine.GetDate_DMY_Format(dueDate);

            TimeSpan overdueTime = retDate - expectedDate;

            Assert.AreEqual(overdueTime.Days, 3);
        }

        [Test]
        public void ConsoleHelper_StringToIntArray()
        {
            int[] expected = new int[] { 1, 4, 5, 7, 9, 12 };
            string testString = "1 4 5 7 9 12";

            int[] result = ConsoleHelper.ReadStringIntoNumArray(testString);

            Assert.AreEqual(expected, result);
        }
    }
}
