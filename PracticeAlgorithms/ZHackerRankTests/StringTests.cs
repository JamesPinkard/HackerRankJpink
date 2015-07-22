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
    }
}
