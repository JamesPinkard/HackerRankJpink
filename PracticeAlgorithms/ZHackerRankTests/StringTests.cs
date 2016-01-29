using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using StringProblems;

namespace ZHackerRankTests
{
    [TestFixture]
    public class StringTests
    {
        [Test]
        [Category("fast")]
        public void FunnyString_IsFunny_ReturnsTrue()
        {
            string funnyString = "acxz";

            string result = FunnyString.IsFunny(funnyString);

            Assert.AreEqual("Funny", result);
        }

        [Test]
        [Category("fast")]
        public void FunnyString_IsFunny_ReturnsFalse()
        {
            string notFunnyString = "bcxz";

            string result = FunnyString.IsFunny(notFunnyString);

            Assert.AreEqual("Not Funny", result);
        }

        [Test]
        [Category("fast")]
        public void GameOfThronesAnagram_aaabbbb_LetterCountHas3As()
        {
            string anagram = "aaabbbb";
            GameOfThronesAnagram gta = new GameOfThronesAnagram();

            gta.PopulateLetterCount(anagram);
            Dictionary<char, int> lc = gta.LetterCount;

            Assert.AreEqual(3, lc['a']);
        }

        [Test]
        [Category("fast")]
        public void GameOfThronesAnagram_aaabbbb_LetterCountHas4Bs()
        {
            string anagram = "aaabbbb";
            GameOfThronesAnagram gta = new GameOfThronesAnagram();

            gta.PopulateLetterCount(anagram);
            Dictionary<char, int> lc = gta.LetterCount;

            Assert.AreEqual(4, lc['b']);
        }

        [Test]
        [Category("fast")]
        public void GameOfThronesAnagram_aaabbbb_ReturnsYes()
        {
            string anagram = "aaabbbb";
            GameOfThronesAnagram gta = new GameOfThronesAnagram();

            string result = gta.IsAnagram(anagram);

            Assert.AreEqual("YES", result);
        }

        [Test]
        [Category("fast")]
        public void GameOfThronesAnagram_cdefghmnopqrstuvw_ReturnsNO()
        {
            string notAnagram = "cdefghmnopqrstuvw";
            GameOfThronesAnagram gta = new GameOfThronesAnagram();

            string result = gta.IsAnagram(notAnagram);

            Assert.AreEqual("NO", result);
        }
    }
}
